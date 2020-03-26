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
        //string FragmentOfPayload { get; set; }
        //string EncodedPayload { get; set; }
        string Packet { get; set; }
        string Channel { get; set; }
        Int64 MMSI { get; set; }
        DateTime? Date { get; set; }
        //Task<DecodedMessages> GetDecodedMessage(IAsyncEnumerable<LineContent> lineContents);
        //public MessageType123 GetMessageType123(Int16 messageType);
        //MessageType4 GetMessageType4(Int16 messageType);
        //MessageType5 GetMessageType5(Int16 messageType);
        //MessageType9 GetMessageType9(Int16 messageType);
        //MessageType21 GetMessageType21(Int16 messageType);
        Int16 GetInt16(int startIndex, int length);
        Int64 GetInt64(int startIndex, int length);

        Int16 GetMessageType();
        string GetNavigationStatus();
        double? GetRateOfTurn();
        double? GetSpeedOverGround(int startIndex, int length);
        string GetPositionAccuracy(int startIndex, int length);
        double GetLongitude(int startIndex, int length);
        double GetLatitude(int startIndex, int length);
        double? GetCourseOverGround(int startIndex, int length);
        Int16? GetTrueHeading();
        string GetManeuverIndicator();
        string GetRAIMFlag(int startIndex, int length);
        string GetRadioStatus();
        DateTime? GetDateOfMessageType4();
        string GetEPFD(int startIndex, int length);
        string GetAISversion();
        string GetString(int startIndex, int length);
        string GetShipType();
        Int16? GetPartOfDate(int startIndex, int length, bool month = false, bool day = false, bool hour = false, bool minute = false);
        double GetDraught(int startIndex, int length);
        string GetDTE(int startIndex, int length);
        string GetAltitude(int startIndex, int length);
        string GetAssinged(int startIndex, int length);
        string GetAidType();
        string GetOffPositionIndicator();
        string GetVirtualAidFlag();
        string GetCountry();

    }
}
