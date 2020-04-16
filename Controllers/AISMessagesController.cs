using System;
using System.Collections.Generic;
using System.Data;
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
        private readonly IDatabaseService _databaseService;

        public AISMessagesController(IAISRepository repository, ILogger<AISMessagesController> logger, 
                                        IFileService fileService, IMessageService messageService,
                                        IMapper mapper, IDatabaseService databaseService)
        {
            _repository = repository;
            _logger = logger;
            _fileService = fileService;
            _messageService = messageService;
            _mapper = mapper;
            _databaseService = databaseService;
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
                var saveToDb = Convert.ToBoolean(Request.Form["saveToDb"]);
                var lineContents = _fileService.GetLineContents(files);

                var decodedMessages = await _messageService.GetDecodedMessage(lineContents);
                saveToDb = false;
                if (saveToDb)
                {
                    string iud = "add";
                    DataTable dataTable;

                    if (decodedMessages.MessagesType1.Count > 0)
                    {
                        dataTable = _databaseService.GetDataTableParameter(decodedMessages.MessagesType1, (Int16)Enums.Enums.MessageTypes.MessageType1);
                        if (dataTable != null && dataTable.Rows.Count > 0) _databaseService.RunPrcDataTableType(iud, "dbo.prc_addMessageType123", dataTable);
                    }

                    if (decodedMessages.MessagesType2.Count > 0)
                    {
                        dataTable = _databaseService.GetDataTableParameter(decodedMessages.MessagesType2, (Int16)Enums.Enums.MessageTypes.MessageType2);
                        if (dataTable != null && dataTable.Rows.Count > 0) _databaseService.RunPrcDataTableType(iud, "dbo.prc_addMessageType123", dataTable);
                    }

                    if (decodedMessages.MessagesType3.Count > 0)
                    {
                        dataTable = _databaseService.GetDataTableParameter(decodedMessages.MessagesType3, (Int16)Enums.Enums.MessageTypes.MessageType3);
                        if (dataTable != null && dataTable.Rows.Count > 0) _databaseService.RunPrcDataTableType(iud, "dbo.prc_addMessageType123", dataTable);
                    }

                    if (decodedMessages.MessagesType4.Count > 0)
                    {
                        dataTable = _databaseService.GetDataTableParameter(decodedMessages.MessagesType4);
                        if (dataTable != null && dataTable.Rows.Count > 0) _databaseService.RunPrcDataTableType(iud, "dbo.prc_addMessageType4", dataTable);
                    }

                    if (decodedMessages.MessagesType5.Count > 0)
                    {
                        dataTable = _databaseService.GetDataTableParameter(decodedMessages.MessagesType5);
                        if (dataTable != null && dataTable.Rows.Count > 0) _databaseService.RunPrcDataTableType(iud, "dbo.prc_addMessageType5", dataTable);
                    }

                    if (decodedMessages.MessagesType9.Count > 0)
                    {
                        dataTable = _databaseService.GetDataTableParameter(decodedMessages.MessagesType9);
                        if (dataTable != null && dataTable.Rows.Count > 0) _databaseService.RunPrcDataTableType(iud, "dbo.prc_addMessageType9", dataTable);
                    }

                    if (decodedMessages.MessagesType21.Count > 0)
                    {
                        dataTable = _databaseService.GetDataTableParameter(decodedMessages.MessagesType21);
                        if (dataTable != null && dataTable.Rows.Count > 0) _databaseService.RunPrcDataTableType(iud, "dbo.prc_addMessageType21", dataTable);
                    }
                }

                var decodedMessagesVM = _mapper.Map<DecodedMessages, DecodedMessagesViewModel>(decodedMessages);

                foreach (var message in decodedMessagesVM.MessagesType1)
                    message.MessageType5 = decodedMessages.MessagesType5.Where(p => p.MMSI == message.MMSI).FirstOrDefault();
                foreach (var message in decodedMessagesVM.MessagesType2)
                    message.MessageType5 = decodedMessages.MessagesType5.Where(p => p.MMSI == message.MMSI).FirstOrDefault();
                foreach (var message in decodedMessagesVM.MessagesType3)
                    message.MessageType5 = decodedMessages.MessagesType5.Where(p => p.MMSI == message.MMSI).FirstOrDefault();
                var messages = new List<MessageType1ViewModel>();
                foreach (var item in decodedMessagesVM.MessagesType1)
                {
                    if (item.Latitude <= -90.0 || item.Latitude >= 90.0) continue;
                    if (item.Longitude <= -180.0 || item.Longitude >= 180.0) continue;

                    messages.Add(item);
                }
                decodedMessagesVM.MessagesType1 = messages;

                if (saveToDb) return Created("api/messages-list", decodedMessagesVM);
                else return Ok(decodedMessagesVM);
            }
            catch (Exception ex)
            { 
                _logger.LogError($"Failed to decode AIS messages: {ex}");
                return BadRequest("Failed to decode AIS messages");
            }
        }
    }
}