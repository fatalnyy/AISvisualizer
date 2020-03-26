using AISvisualizer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        protected Message()
        {

        }
        protected Message(Int16 messageType, IDecodeService decodeService)
        {
            Date = Date;
            MessageType = Enums.Enums.GetEnumDescription<Enums.Enums.MessageTypes>(messageType);
            Repeat = decodeService.GetInt16(6, 2);
            MMSI = decodeService.MMSI;
            Packet = decodeService.Packet;
            Channel = decodeService.Channel;
            Country = decodeService.GetCountry();
        }
    }

    public class MessageType1 : Message
    {
        public string Status { get; set; }
        public double? ROT { get; set; }
        public double? SOG { get; set; }
        public string Accuracy { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double? COG { get; set; }
        public Int16? HDG { get; set; }
        public Int16 Timestamp { get; set; }
        public string Maneuver { get; set; }
        public Int16 Spare { get; set; }
        public string RAIM { get; set; }
        public int RadioStatus { get; set; }
        public int MessageType5_Id { get; set; }

        [ForeignKey("MessageType5_Id")]
        public virtual MessageType5 MessageType5 { get; set; }

        public MessageType1(short messageType, IDecodeService decodeService)
            : base(messageType, decodeService)
        {
            Status = decodeService.GetNavigationStatus();
            ROT = decodeService.GetRateOfTurn();
            SOG = decodeService.GetSpeedOverGround(50, 10);
            Accuracy = decodeService.GetPositionAccuracy(60, 1);
            Longitude = decodeService.GetLongitude(61, 28);
            Latitude = decodeService.GetLatitude(89, 27);
            COG = decodeService.GetCourseOverGround(116, 12);
            HDG = decodeService.GetTrueHeading();
            Timestamp = decodeService.GetInt16(137, 6);
            Maneuver = decodeService.GetManeuverIndicator();
            RAIM = decodeService.GetRAIMFlag(148, 1);
        }

        public MessageType1() : base()
        {
        }
    }
    public class MessageType2 : MessageType1 
    {
        public MessageType2()
        {
        }

        public MessageType2(short messageType, IDecodeService decodeService)
            : base(messageType, decodeService)
        {
        }
    }
    public class MessageType3 : MessageType1
    {
        public MessageType3()
        {
        }

        public MessageType3(short messageType, IDecodeService decodeService)
            : base(messageType, decodeService)
        {
        }
    }

}
