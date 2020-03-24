using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AISvisualizer.Data;
using AISvisualizer.Models;
using AISvisualizer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AISvisualizer.Controllers
{
    [Route("api/[Controller]")]
    public class AISMessagesController : Controller
    {
        private readonly IAISRepository _repository;
        private readonly ILogger<AISMessagesController> _logger;
        private readonly IFileService _fileService;
        private readonly IDecodeService _decodeService;

        public AISMessagesController(IAISRepository repository, ILogger<AISMessagesController> logger, IFileService fileService, IDecodeService decodeService)
        {
            _repository = repository;
            _logger = logger;
            _fileService = fileService;
            _decodeService = decodeService;
        }

        [HttpGet]
        [Route("GetAllMessages")]
        public IActionResult GetMessages()
        {
            try
            {
                return Ok(_repository.GetAllMessages());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get messages: {ex}");
                return BadRequest("Failed to get messages");
            }
        }

        [HttpPost, DisableRequestSizeLimit]
        [Route("DecodeFromFiles")]
        public async Task<IActionResult> DecodeFromFiles([FromForm(Name = "files")] IEnumerable<IFormFile> files)
        {
            try
            {
                var files1 = Request.Form.Files;
                //var saveToDb = Convert.ToBoolean(Request.Form.Keys.FirstOrDefault());
                var saveToDb = false;
                var lineContents = _fileService.GetLineContents(files);

                var decodedMessages = await _decodeService.GetDecodedMessage(lineContents);
                //var messages = new List<Message>();
                //await foreach (var lineContent in lineContents)
                //{
                //    var decodedMessage = _decodeService.GetDecodedMessage(lineContent.AISmessage.Payload);

                //    if (decodedMessage != null) messages.Add(decodedMessage);
                //}

                if (saveToDb)
                {
                    _repository.AddMessages(decodedMessages.MessageType5s);
                    _repository.SaveAll();

                    return Created("/api/AISMessages", decodedMessages);
                }

                var messagetype123s = decodedMessages.MessageType123s;
                var messagetype5s = decodedMessages.MessageType5s;

                foreach (var message in messagetype123s)
                    message.MessageType5 = messagetype5s.Where(p => p.MMSI == message.MMSI).FirstOrDefault();

                return Ok(decodedMessages);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to decode AIS messages: {ex}");
                return BadRequest("Failed to decode AIS messages");
            }
        }
    }
    public class MyFileUploadClass
    {
        public IFormFile[] files { get; set; }
        // other properties
    }
}