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

        public enum ShipType
        {
            NotAvailable,
            WingInGround = 20,
            WingInGroundHazardousCategoryA = 21,
            WingInGroundHazardousCategoryB = 22,
            WingInGroundHazardousCategoryC = 23,
            WingInGroundHazardousCategoryD = 24,
            WingInGroundReserved1 = 25,
            WingInGroundReserved2 = 26,
            WingInGroundReserved3 = 27,
            WingInGroundReserved4 = 28,
            WingInGroundReserved5 = 29,
            Fishing = 30,
            Towing = 31,
            TowingLarge = 32,
            DredgingOrUnderwaterOps = 33,
            DivingOps = 34,
            MilitaryOps = 35,
            Sailing = 36,
            PleasureCraft = 37,
            Reserved1 = 38,
            Reserved2 = 39,
            HighSpeedCraft = 40,
            HighSpeedCraftHazardousCategoryA = 41,
            HighSpeedCraftHazardousCategoryB = 42,
            HighSpeedCraftHazardousCategoryC = 43,
            HighSpeedCraftHazardousCategoryD = 44,
            HighSpeedCraftReserved1 = 45,
            HighSpeedCraftReserved2 = 46,
            HighSpeedCraftReserved3 = 47,
            HighSpeedCraftReserved4 = 48,
            HighSpeedCraftNoAdditionalInformation = 49,
            PilotVessel = 50,
            SearchAndRescueVessel = 51,
            Tug = 52,
            PortTender = 53,
            AntiPollutionEquipment = 54,
            LawEnforcement = 55,
            SpareLocalVessel1 = 56,
            SpareLocalVessel2 = 57,
            MedicalTransport = 58,
            NonCombatantShip = 59,
            Passenger = 60,
            PassengerHazardousCategoryA = 61,
            PassengerHazardousCategoryB = 62,
            PassengerHazardousCategoryC = 63,
            PassengerHazardousCategoryD = 64,
            PassengerReserved1 = 65,
            PassengerReserved2 = 66,
            PassengerReserved3 = 67,
            PassengerReserved4 = 68,
            PassengerNoAdditionalInformation = 69,
            Cargo = 70,
            CargoHazardousCategoryA = 71,
            CargoHazardousCategoryB = 72,
            CargoHazardousCategoryC = 73,
            CargoHazardousCategoryD = 74,
            CargoReserved1 = 75,
            CargoReserved2 = 76,
            CargoReserved3 = 77,
            CargoReserved4 = 78,
            CargoNoAdditionalInformation = 79,
            Tanker = 80,
            TankerHazardousCategoryA = 81,
            TankerHazardousCategoryB = 82,
            TankerHazardousCategoryC = 83,
            TankerHazardousCategoryD = 84,
            TankerReserved1 = 85,
            TankerReserved2 = 86,
            TankerReserved3 = 87,
            TankerReserved4 = 88,
            TankerNoAdditionalInformation = 89,
            OtherType = 90,
            OtherTypeHazardousCategoryA = 91,
            OtherTypeHazardousCategoryB = 92,
            OtherTypeHazardousCategoryC = 93,
            OtherTypeHazardousCategoryD = 94,
            OtherTypeReserved1 = 95,
            OtherTypeReserved2 = 96,
            OtherTypeReserved3 = 97,
            OtherTypeReserved4 = 98,
            OtherTypeNoAdditionalInformation = 99,
        }

        public enum AidType
        {
            [Description("Not specified")]
            NotSpecified,
            [Description("Reference point")]
            ReferencePoint,
            [Description("RACON")]
            Racon,
            [Description("Fixed structure off shore")]
            FixedStuctureOffShore,
            [Description("Spare")]
            Spare,
            [Description("Light, without sectors")]
            LightWithoutSectors,
            [Description("Light, with sectors")]
            LightWithSectors,
            [Description("Leading Light Front")]
            LeadingLightFront,
            [Description("Leading Light Rear")]
            LeadingLigthRear,
            [Description("Beacon, Cardinal N")]
            BeaconCardinalN,
            [Description("Beacon, Cardinal E")]
            BeaconCardinalE,
            [Description("Beacon, Cardinal S")]
            BeaconCardinalS,
            [Description("Beacon, Cardinal W")]
            BeaconCardinalW,
            [Description("Beacon, Port hand")]
            BeaconPortHand,
            [Description("Beacon, Starboard hand")]
            BeaconStarboardHand,
            [Description("Beacon, Preferred Channel port hand")]
            BeaconPreferredChannelPortHand,
            [Description("Beacon, Preferred Channel starboard hand")]
            BeaconPreferredChannelStarboardHand,
            [Description("Beacon, Isolated danger")]
            BeaconIsolatedDanger,
            [Description("Beacon, Safe water")]
            BeaconSafeWater,
            [Description("Beacon, Special mark")]
            BeaconSpecialMark,
            [Description("Cardinal Mark N")]
            CardinalMarkN,
            [Description("Cardinal Mark E")]
            CardinalMarkE,
            [Description("Cardinal Mark S")]
            CardinalMarkS,
            [Description("Cardinal Mark W")]
            CardinalMarkW,
            [Description("Port hand Mark")]
            PortHandMark,
            [Description("Starboard hand Mark")]
            StarboardHandMark,
            [Description("Preferred Channel Port hand")]
            PreferredChannelPortHand,
            [Description("Preferred Channel Starboard hand")]
            PreferredChannelStarboardHand,
            [Description("Isolated danger")]
            IsolatedDanger,
            [Description("Safe Water")]
            SafeWater,
            [Description("Special Mark")]
            SpecialMark,
            [Description("Light Vessel")]
            LightVessel
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
