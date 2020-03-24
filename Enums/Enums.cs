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

        public enum MIDcountries
        {
            Albania = 201,
            Andorra = 202,
            Austria = 203,
            Portugal = 204,
            Belgium = 205,
            Belarus = 206,
            Bulgaria = 207,
            Vatican = 208,
            Cyprus = 209,
            Cyprus1 = 210,
            Germany = 211,
            Cyprus2 = 212,
            Georgia = 213,
            Moldova = 214,
            Malta = 215,
            Armenia = 216,
            Germany1 = 218,
            Denmark = 219,
            Denmark1 = 220,
            Spain = 224,
            Spain1 = 225,
            France = 226,
            France1 = 227,
            France2 = 228,
            Malta1 = 229,
            Finland = 230,
            FaroeIslands = 231,
            UnitedKingdom = 232,
            UnitedKingdom1 = 233,
            UnitedKingdom2 = 234,
            UnitedKingdom3 = 235,
            Gibraltar = 236,
            Greece = 237,
            Croatia = 238,
            Greece1 = 239,
            Greece2 = 240,
            Greece3 = 241,
            Morocco = 242,
            Hungary = 243,
            Netherlands = 244,
            Netherlands1 = 245,
            Netherlands2 = 246,
            Italy = 247,
            Malta2 = 248,
            Malta3 = 249,
            Ireland = 250,
            Iceland = 251,
            Liechtenstein = 252,
            Luxembourg = 253,
            Monaco = 254,
            Portugal1 = 255,
            Malta4 = 256,
            Norway = 257,
            Norway1 = 258,
            Norway2 = 259,
            Poland = 261,
            Montenegro = 262,
            Portugal2 = 263,
            Romania = 264,
            Sweden = 265,
            Sweden1 = 266,
            Slovakia = 267,
            SanMarino = 268,
            Switzerland = 269,
            CzechRepublic = 270,
            Turkey = 271,
            Ukraine = 272,
            Russia = 273,
            FYRMacedonia = 274,
            Latvia = 275,
            Estonia = 276,
            Lithuania = 277,
            Slovenia = 278,
            Serbia = 279,
            Anguilla = 301,
            USA = 303,
            AntiguaBarbuda = 304,
            AntiguaBarbuda1 = 305,
            Curacao = 306,
            Aruba = 307,
            Bahamas = 308,
            Bahamas1 = 309,
            Bermuda = 310,
            Bahamas2 = 311,
            Belize = 312,
            Barbados = 314,
            Canada = 316,
            CaymanIs = 319,
            CostaRica = 321,
            Cuba = 323,
            Dominica = 325,
            DominicanRep = 327,
            Guadeloupe = 329,
            Grenada = 330,
            Greenland = 331,
            Guatemala = 332,
            Honduras = 334,
            Haiti = 336,
            USA1 = 338,
            Jamaica = 339,
            StKittsNevis = 341,
            StLucia = 343,
            Mexico = 345,
            Martinique = 347,
            Montserrat = 348,
            Nicaragua = 350,
            Panama = 351,
            Panama1 = 352,
            Panama2 = 353,
            Panama3 = 354,
            Panama4 = 355,
            Panama5 = 356,
            Panama6 = 357,
            PuertoRico = 358,
            ElSalvador = 359,
            StPierreMiquelon = 361,
            TrinidadTobago = 362,
            TurksCaicosIs = 364,
            USA2 = 366,
            USA3 = 367,
            USA4 = 368,
            USA5 = 369,
            Panama7 = 370,
            Panama8 = 371,
            Panama9 = 372,
            Panama10 = 373,
            Panama11 = 374,
            StVincentGrenadines1 = 375,
            StVincentGrenadines2 = 376,
            StVincentGrenadines3 = 377,
            BritishVirginIs = 378,
            USVirginIs = 379,
            Afghanistan = 401,
            SaudiArabia = 403,
            Bangladesh = 405,
            Bahrain = 408,
            Bhutan = 410,
            China = 412,
            China1 = 413,
            China2 = 414,
            Taiwan = 416,
            SriLanka = 417,
            India = 419,
            Iran = 422,
            Azerbaijan = 423,
            Iraq = 425,
            Israel = 428,
            Japan = 431,
            Japan1 = 432,
            Turkmenistan = 434,
            Kazakhstan = 436,
            Uzbekistan = 437,
            Jordan = 438,
            Korea = 440,
            Korea1 = 441,
            Palestine = 443,
            DPRKorea = 445,
            Kuwait = 447,
            Lebanon = 450,
            KyrgyzRepublic = 451,
            Macao = 453,
            Maldives = 455,
            Mongolia = 457,
            Nepal = 459,
            Oman = 461,
            Pakistan = 463,
            Qatar = 466,
            Syria = 468,
            UAE = 470,
            Tajikistan = 472,
            Yemen = 473,
            Yemen1 = 475,
            HongKong = 477,
            BosniaandHerzegovina = 478,
            Antarctica = 501,
            Australia = 503,
            Myanmar = 506,
            Brunei = 508,
            Micronesia = 510,
            Palau = 511,
            NewZealand = 512,
            Cambodia = 514,
            Cambodia1 = 515,
            ChristmasIs = 516,
            CookIs = 518,
            Fiji = 520,
            CocosIs = 523,
            Indonesia = 525,
            Kiribati = 529,
            Laos = 531,
            Malaysia = 533,
            NMarianaIs = 536,
            MarshallIs = 538,
            NewCaledonia = 540,
            Niue = 542,
            Nauru = 544,
            FrenchPolynesia = 546,
            Philippines = 548,
            PapuaNewGuinea = 553,
            PitcairnIs = 555,
            SolomonIs = 557,
            AmericanSamoa = 559,
            Samoa = 561,
            Singapore = 563,
            Singapore1 = 564,
            Singapore2 = 565,
            Singapore3 = 566,
            Thailand = 567,
            Tonga = 570,
            Tuvalu = 572,
            Vietnam = 574,
            Vanuatu = 576,
            Vanuatu1 = 577,
            WallisFutunaIs = 578,
            SouthAfrica = 601,
            Angola = 603,
            Algeria = 605,
            StPaulAmsterdamIs = 607,
            AscensionIs = 608,
            Burundi = 609,
            Benin = 610,
            Botswana = 611,
            CenAfrRep = 612,
            Cameroon = 613,
            Congo = 615,
            Comoros = 616,
            CapeVerde = 617,
            Antarctica1 = 618,
            IvoryCoast = 619,
            Comoros1 = 620,
            Djibouti = 621,
            Egypt = 622,
            Ethiopia = 624,
            Eritrea = 625,
            Gabon = 626,
            Ghana = 627,
            Gambia = 629,
            GuineaBissau = 630,
            EquGuinea = 631,
            Guinea = 632,
            BurkinaFaso = 633,
            Kenya = 634,
            Antarctica2 = 635,
            Liberia = 636,
            Liberia1 = 637,
            Libya = 642,
            Lesotho = 644,
            Mauritius = 645,
            Madagascar = 647,
            Mali = 649,
            Mozambique = 650,
            Mauritania = 654,
            Malawi = 655,
            Niger = 656,
            Nigeria = 657,
            Namibia = 659,
            Reunion = 660,
            Rwanda = 661,
            Sudan = 662,
            Senegal = 663,
            Seychelles = 664,
            StHelena = 665,
            Somalia = 666,
            SierraLeone = 667,
            SaoTomePrincipe = 668,
            Swaziland = 669,
            Chad = 670,
            Togo = 671,
            Tunisia = 672,
            Tanzania = 674,
            Uganda = 675,
            DRCongo = 676,
            Tanzania2 = 677,
            Zambia = 678,
            Zimbabwe = 679,
            Argentina = 701,
            Brazil = 710,
            Bolivia = 720,
            Chile = 725,
            Colombia = 730,
            Ecuador = 735,
            UK = 740,
            Guiana = 745,
            Guyana = 750,
            Paraguay = 755,
            Peru = 760,
            Suriname = 765,
            Uruguay = 770,
            Venezuela = 775,

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
