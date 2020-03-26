using AISvisualizer.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Data
{
    public class AisMappingProfile : Profile
    {
        public AisMappingProfile()
        {
            CreateMap<MessageType1, MessageType1ViewModel>();
            CreateMap<MessageType2, MessageType2ViewModel>();
            CreateMap<MessageType3, MessageType3ViewModel>();
            CreateMap<DecodedMessages, DecodedMessagesViewModel>();
        }    
    }
}
