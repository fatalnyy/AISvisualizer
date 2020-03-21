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
        Message GetDecodedMessage(string payload);
        Int16 GetMessageType();
        Int16 GetRepeatIndicator();
        Int64 GetMMSI();
        string GetNavigationStatus();
        Int16? GetRateOfTurn();
        double? GetSpeedOverGround();
        string GetPositionAccuracy();
        double GetLongitude();
        double GetLatitude();
        double? GetCourseOverGround();
        Int16? GetTrueHeading();
        string GetTimestamp();
        string GetManeuverIndicator();
        string GetRAIMFlag();
        string GetRadioStatus();
    }
}
