using AISvisualizer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Models
{
    public abstract class Message
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string MessageType { get; set; }
        public Int16 Repeat { get; set; }
        public Int64 MMSI { get; set; }
        public string Packet { get; set; }
        public string Channel { get; set; }
        public string Country { get; set; }

        protected Message() {}
        protected Message(Int16 messageType, IDecodeService decodeService)
        {
            Date = decodeService.Date;
            MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType);
            Repeat = decodeService.GetInt16(6, 2);
            MMSI = decodeService.MMSI;
            Packet = decodeService.Packet;
            Channel = decodeService.Channel;
            Country = decodeService.GetCountry();
        }
    }
}
