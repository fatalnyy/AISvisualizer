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
        private readonly IMessageService _messageService;

        public AISMessagesController(IAISRepository repository, ILogger<AISMessagesController> logger, IFileService fileService, IMessageService messageService)
        {
            _repository = repository;
            _logger = logger;
            _fileService = fileService;
            _messageService = messageService;
        }

        [HttpGet]
        [Route("GetAllMessages")]
        public IActionResult GetMessages()
        {
            try
            {
                return null;// return Ok(_repository.GetAllMessages());
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
                //var saveToDb = Convert.ToBoolean(Request.Form.Keys.FirstOrDefault());
                var saveToDb = true;
                var lineContents = _fileService.GetLineContents(files);

                var decodedMessages = await _messageService.GetDecodedMessage(lineContents);

                if (saveToDb)
                {
                    _repository.AddMessages(decodedMessages);
                    _repository.SaveAll();

                    var x = _repository.GetAllMessages<MessageType1>();
                    return Created("/api/AISMessages", decodedMessages);
                }
                int counter = 0;
                //var messagetype123s = decodedMessages.MessageType123s;
                //var messagetype5s = decodedMessages.MessageType5s;

                //foreach (var message in decodedMessages.MessagesType1)
                //    message.MessageType5 = decodedMessages.MessageType5s.Where(p => p.MMSI == message.MMSI).FirstOrDefault();
                //foreach (var message in decodedMessages.MessageType123s)
                //{
                //    if (message.MessageType5 != null) counter++;
                //}
                return null;//return Ok(decodedMessages);
            }
            catch (Exception ex)
            { 
                _logger.LogError($"Failed to decode AIS messages: {ex}");
                return BadRequest("Failed to decode AIS messages");
            }
        }
    }
}