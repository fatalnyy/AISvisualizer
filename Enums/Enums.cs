using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AISvisualizer.Enums
{
    public class Enums
    {
        public enum MessageTypes
        {
            [Description("Position Report Class A")]
            MessageType1 = 1,
            [Description("Position Report Class A (Assigned schedule)")]
            MessageType2 = 2,
            [Description("Position Report Class A(Response to interrogation")]
            MessageType3 = 3,
            [Description("Base Station Report")]
            MessageType4 = 4,
            [Description("Static and Voyage Related Data")]
            MessageType5 = 5,
            [Description("Binary Addressed Message")]
            MessageType6 = 6,
            [Description("Binary Acknowledge")]
            MessageType7 = 7,
            [Description("Binary Broadcast Message")]
            MessageType8 = 8,
            [Description("Standard SAR Aircraft Position Report")]
            MessageType9 = 9,
            [Description("UTC and Date Inquiry")]
            MessageType10 = 10,
            [Description("UTC and Date Response")]
            MessageType11 = 11,
            [Description("Addressed Safety Related Message")]
            MessageType12 = 12,
            [Description("Safety Related Acknowledgement")]
            MessageType13 = 13,
            [Description("Safety Related Broadcast Message")]
            MessageType14 = 14,
            [Description("Interrogation")]
            MessageType15 = 15,
            [Description("Assignment Mode Command")]
            MessageType16 = 16,
            [Description("DGNSS Binary Broadcast Message")]
            MessageType17 = 17,
            [Description("Standard Class B CS Position Report")]
            MessageType18 = 18,
            [Description("Extended Class B Equipment Position Report")]
            MessageType19 = 19,
            [Description("Data Link Management")]
            MessageType20 = 20,
            [Description("Aid-to-Navigation Report")]
            MessageType21 = 21,
            [Description("Channel Management")]
            MessageType22 = 22,
            [Description("Group Assignment Command")]
            MessageType23 = 23,
            [Description("Static Data Report")]
            MessageType24 = 24,
            [Description("Single Slot Binary Message")]
            MessageType25 = 25,
            [Description("Multiple Slot Binary Message With Communications State")]
            MessageType26 = 26,
            [Description("Position Report For Long - Range Applications")]
            MessageType27 = 27
        }

        public enum NavigationStatus
        {
            [Description("Under way using engine")]
            UnderWayEngine = 0,
            [Description("At anchor")]
            AtAnchor = 1,
            [Description("Not under command")]
            NotUnderCommand = 2,
            [Description("Restricted manoeuverability")]
            Restricted = 3,
            [Description("Constrained by her draught")]
            Constrained = 4,
            [Description("Moored")]
            Moored = 5,
            [Description("Aground")]
            Aground = 6,
            [Description("Engaged in Fishing")]
            Engaged = 7,
            [Description("Under way sailing")]
            UnderWay = 8,
            [Description("Reserved for future amendment of Navigational Status for HSC")]
            Reserved9 = 9,
            [Description("Reserved for future amendment of Navigational Status for WIG")]
            Reserved10 = 10,
            [Description("Reserved for future use")]
            Reserved11 = 11,
            [Description("Reserved for future use")]
            Reserved12 = 12,
            [Description("Reserved for future use")]
            Reserved13 = 13,
            [Description("AIS-SART is active")]
            SART = 14,
            [Description("Not defined")]
            NotDefined = 15,
        }

        public enum EPFDfixTypes
        {
            [Description("Undefined")]
            Undefined = 0,
            [Description("GPS")]
            GPS = 1,
            [Description("GLONASS")]
            GLONASS = 2,
            [Description("Combined GPS/GLONASS")]
            Combined = 3,
            [Description("Loran-C")]
            Loran = 4,
            [Description("Chayka")]
            Chayka = 5,
            [Description("Integrated navigation system")]
            Integrated = 6,
            [Description("Surveyed")]
            Surveyed = 7,
            [Description("Galileo")]
            Galileo = 8
        }
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            if (fi != null)
            {
                DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
                else
                    value.ToString();
            }

            return "";
        }

        public static string GetEnumDescription<TEnum>(int value)
        {
            return GetEnumDescription((Enum)(object)(TEnum)(object)value);
        }
    }
}
