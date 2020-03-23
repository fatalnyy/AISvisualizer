using AISvisualizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public interface IDecodeService
    {
        string BinaryPayload { get; set; }
        Task<DecodedMessages> GetDecodedMessage(IAsyncEnumerable<LineContent> lineContents);
        public MessageType123 GetMessageType123(Int16 messageType);
        MessageType4 GetMessageType4(Int16 messageType);
        MessageType5 GetMessageType5(Int16 messageType);
        MessageType9 GetMessageType9(Int16 messageType);
        MessageType21 GetMessageType21(Int16 messageType);
        Int16 GetMessageType();
        Int16 GetRepeatIndicator();
        Int64 GetMMSI();
        string GetNavigationStatus();
        Int16? GetRateOfTurn();
        double? GetSpeedOverGround(int startIndex, int length);
        string GetPositionAccuracy(int startIndex, int length);
        double GetLongitude(int startIndex, int length);
        double GetLatitude(int startIndex, int length);
        double? GetCourseOverGround(int startIndex, int length);
        Int16? GetTrueHeading();
        string GetTimestamp(int startIndex, int length);
        string GetManeuverIndicator();
        string GetRAIMFlag(int startIndex, int length);
        string GetRadioStatus();
        DateTime? GetDateOfMessageType4();
        string GetEPFD(int startIndex, int length);
        string GetAISversion();
        Int64 GetIMOnumber();
        string GetString(int startIndex, int length);
        string GetShipType();
        string GetDimensionToBowOrToStern(int startIndex, int length);
        string GetDimensionToPortOrToStarboard(int startIndex, int length);
        Int16? GetPartOfDate(int startIndex, int length, bool month = false, bool day = false, bool hour = false, bool minute = false);
        double GetDraught(int startIndex, int length);
        string GetDTE(int startIndex, int length);
        string GetAltitude(int startIndex, int length);
        string GetAssinged(int startIndex, int length);
        string GetAidType();
        string GetOffPositionIndicator();
        string GetVirtualAidFlag();

    }
}
