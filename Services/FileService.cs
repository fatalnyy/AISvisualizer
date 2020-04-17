using AISvisualizer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public class FileService : IFileService
    {
        private int linesCount;
        private int currentLine;
        private readonly ILogger<FileService> _logger;
        public FileService(ILogger<FileService> logger)
        {
            _logger = logger;
        }
        public async IAsyncEnumerable<LineContent> GetLineContents(IEnumerable<IFormFile> files)
        {
            Startup.Progress = 0;
            currentLine = 0;
            linesCount = GetLinesCount(files);

            foreach (var file in files)
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    while (reader.Peek() >= 0)
                    {
                        var line = await reader.ReadLineAsync();
                        
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        currentLine++;
                        Startup.Progress = (int)(((float)currentLine / (float)linesCount) * 100);

                        var splittedLine = Regex.Split(line, "\t");
                        var splittedAISmessage = Regex.Split(splittedLine[2], ",");

                        if (splittedAISmessage[0][0] != '!')
                        {
                            _logger.LogError("Invalid AIS sentence: Sentence has to start with!", splittedLine[2]);
                            continue;
                        }

                        var checksumIndex = splittedLine[2].IndexOf('*');
                        if (checksumIndex == -1)
                        {
                            _logger.LogError("Invalid AIS sentence: Unable to find checksum!", splittedLine[2]);
                            continue;
                        }

                        if (!CheckHeader(splittedAISmessage[0]))
                        {
                            _logger.LogError($"Unrecognised AIS message: header {splittedAISmessage[0]}!", splittedLine[2]);
                            continue;
                        }


                        yield return new LineContent
                        {
                            Date = splittedLine[0],
                            Time = splittedLine[1],
                            AISsentence = new AISsentence
                            {
                                Format = splittedAISmessage[0],
                                MessageCount = splittedAISmessage[1],
                                MessageNumber = splittedAISmessage[2],
                                SequenceId = splittedAISmessage[3],
                                Channel = splittedAISmessage[4],
                                Payload = splittedAISmessage[5],
                                Size = splittedAISmessage[6]
                            }
                        };
                    }
                }
            }
        }

        public bool CheckHeader(string header)
        {
            return header == "!AIVDM" || header == "!AIVDO";
        }

        private int GetLinesCount(IEnumerable<IFormFile> files)
        {
            int linesCount = 0;
            foreach (var file in files)
            {
                var reader = new StreamReader(file.OpenReadStream()).ReadToEnd();
                var lines = reader.Split(new char[] { '\n' });
                linesCount += lines.Count();
            }

            return linesCount;
        }
    }
}
