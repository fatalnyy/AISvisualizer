using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AISvisualizer.Data;
using AISvisualizer.Models;
using AISvisualizer.Services;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public AISMessagesController(IAISRepository repository, ILogger<AISMessagesController> logger, 
                                        IFileService fileService, IMessageService messageService,
                                        IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _fileService = fileService;
            _messageService = messageService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllMessages")]
        public IActionResult GetMessages(string type)
        {
            var type1 = Convert.ToInt16(type);

            try
            {
                switch (type1)
                {
                    case (Int16)Enums.Enums.MessageTypes.MessageType1:
                        return Ok(_repository.GetAllMessages<MessageType1>());
                    case (Int16)Enums.Enums.MessageTypes.MessageType2:
                        return Ok(_repository.GetAllMessages<MessageType2>());
                    case (Int16)Enums.Enums.MessageTypes.MessageType3:
                        return Ok(_repository.GetAllMessages<MessageType3>());
                    case (Int16)Enums.Enums.MessageTypes.MessageType4:
                        return Ok(_repository.GetAllMessages<MessageType4>());
                    case (Int16)Enums.Enums.MessageTypes.MessageType5:
                        return Ok(_repository.GetAllMessages<MessageType5>());
                    case (Int16)Enums.Enums.MessageTypes.MessageType9:
                        return Ok(_repository.GetAllMessages<MessageType9>());
                    case (Int16)Enums.Enums.MessageTypes.MessageType21:
                        return Ok(_repository.GetAllMessages<MessageType21>());
                }

                return BadRequest("Failed to get mesagges");
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
                var saveToDb = false;
                var lineContents = _fileService.GetLineContents(files);

                var decodedMessages = await _messageService.GetDecodedMessage(lineContents);

                if (saveToDb)
                {
                    _repository.AddMessages(decodedMessages);
                    _repository.SaveAll();
                }

                var decodedMessagesVM = _mapper.Map<DecodedMessages, DecodedMessagesViewModel>(decodedMessages);

                foreach (var message in decodedMessagesVM.MessagesType1)
                    message.MessageType5 = decodedMessages.MessagesType5.Where(p => p.MMSI == message.MMSI).FirstOrDefault();
                foreach (var message in decodedMessagesVM.MessagesType2)
                    message.MessageType5 = decodedMessages.MessagesType5.Where(p => p.MMSI == message.MMSI).FirstOrDefault();
                foreach (var message in decodedMessagesVM.MessagesType3)
                    message.MessageType5 = decodedMessages.MessagesType5.Where(p => p.MMSI == message.MMSI).FirstOrDefault();

                if (saveToDb) return Created("api/messages-list", decodedMessagesVM);
                else return Ok(decodedMessages);
            }
            catch (Exception ex)
            { 
                _logger.LogError($"Failed to decode AIS messages: {ex}");
                return BadRequest("Failed to decode AIS messages");
            }
        }
    }
}