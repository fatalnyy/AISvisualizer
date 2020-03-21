using AISvisualizer.Models;
using Microsoft.AspNetCore.Http;
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
        public async IAsyncEnumerable<LineContent> GetLineContents(IEnumerable<IFormFile> files)
        {
            foreach (var file in files)
            {
                using (var reader = new StreamReader(files.FirstOrDefault().OpenReadStream()))
                {
                    while (reader.Peek() >= 0)
                    {
                        var line = await reader.ReadLineAsync();
                        var splittedLine = Regex.Split(line, "\t");
                        var splittedAISmessage = Regex.Split(splittedLine[2], ",");
                        yield return new LineContent
                        {
                            Date = splittedLine[0],
                            Time = splittedLine[1],
                            AISmessage = new AISmessage
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
    }
}
