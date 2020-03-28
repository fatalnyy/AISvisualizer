using AISvisualizer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AISvisualizer.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _config;
        public DatabaseService(ILogger<DatabaseService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration;
        }

        public long RunPrcDataTableType(string iud, string prc_name, DataTable dt)
        {
            long res = 1;

            try
            {
                using (SqlConnection connection = new SqlConnection(_config.GetConnectionString("AisConnectionString")))
                {
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = prc_name;
                    SqlParameter param = null;
                    param = cmd.Parameters.AddWithValue("@i_dt", dt);

                    if (!string.IsNullOrWhiteSpace(iud))
                        param = cmd.Parameters.AddWithValue(@"i_iud", iud);

                    param = cmd.Parameters.Add("@o_result", SqlDbType.NVarChar);
                    param.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    res = (int)cmd.Parameters["@o_result"].Value;
                    return res;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to execute database procedure: {ex}");
                return res;
            }
        }

        public DataTable GetDataTableParameter(IEnumerable<MessageType1> messages, int type)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("MessageType", typeof(string));
            dt.Columns.Add("Repeat", typeof(Int16));
            dt.Columns.Add("MMSI", typeof(Int64));
            dt.Columns.Add("Packet", typeof(string));
            dt.Columns.Add("Channel", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("ROT", typeof(double));
            dt.Columns.Add("SOG", typeof(double));
            dt.Columns.Add("Accuracy", typeof(string));
            dt.Columns.Add("Longitude", typeof(double));
            dt.Columns.Add("Latitude", typeof(double));
            dt.Columns.Add("COG", typeof(double));
            dt.Columns.Add("HDG", typeof(Int16));
            dt.Columns.Add("Timestamp", typeof(Int16));
            dt.Columns.Add("Maneuver", typeof(string));
            dt.Columns.Add("Spare", typeof(Int16));
            dt.Columns.Add("RAIM", typeof(string));
            dt.Columns.Add("RadioStatus", typeof(int));
            dt.Columns.Add("Type", typeof(string));

            foreach (var message in messages)
            {
                DataRow rw = dt.NewRow();

                rw["Id"] = message.Id;
                rw["Date"] = message.Date ?? (object)DBNull.Value;
                rw["MessageType"] = message.MessageType;
                rw["Repeat"] = message.Repeat;
                rw["MMSI"] = message.MMSI;
                rw["Packet"] = message.Packet;
                rw["Channel"] = message.Channel;
                rw["Country"] = message.Country;
                rw["Status"] = message.Status;
                rw["ROT"] = message.ROT ?? (object)DBNull.Value;
                rw["SOG"] = message.SOG ?? (object)DBNull.Value;
                rw["Accuracy"] = message.Accuracy;
                rw["Longitude"] = message.Longitude;
                rw["Latitude"] = message.Latitude;
                rw["COG"] = message.COG ?? (object)DBNull.Value;
                rw["HDG"] = message.HDG ?? (object)DBNull.Value;
                rw["Timestamp"] = message.Timestamp;
                rw["Maneuver"] = message.Maneuver;
                rw["Spare"] = message.Spare;
                rw["RAIM"] = message.RAIM;
                rw["RadioStatus"] = message.RadioStatus;
                rw["Type"] = type.ToString();

                dt.Rows.Add(rw);
            }
            return dt;
        }

        public DataTable GetDataTableParameter(IEnumerable<MessageType4> messages)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("MessageType", typeof(string));
            dt.Columns.Add("Repeat", typeof(Int16));
            dt.Columns.Add("MMSI", typeof(Int64));
            dt.Columns.Add("Packet", typeof(string));
            dt.Columns.Add("Channel", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Year", typeof(Int16));
            dt.Columns.Add("Month", typeof(Int16));
            dt.Columns.Add("Day", typeof(Int16));
            dt.Columns.Add("Hour", typeof(Int16));
            dt.Columns.Add("Minute", typeof(Int16));
            dt.Columns.Add("Second", typeof(Int16));
            dt.Columns.Add("FixQuality", typeof(string));
            dt.Columns.Add("Longitude", typeof(double));
            dt.Columns.Add("Latitude", typeof(double));
            dt.Columns.Add("EPFD", typeof(string));
            dt.Columns.Add("RAIM", typeof(string));
            dt.Columns.Add("Spare", typeof(Int16));
            dt.Columns.Add("RadioStatus", typeof(int));

            foreach (var message in messages)
            {
                DataRow rw = dt.NewRow();

                rw["Id"] = message.Id;
                rw["Date"] = message.Date ?? (object)DBNull.Value;
                rw["MessageType"] = message.MessageType;
                rw["Repeat"] = message.Repeat;
                rw["MMSI"] = message.MMSI;
                rw["Packet"] = message.Packet;
                rw["Channel"] = message.Channel;
                rw["Country"] = message.Country;
                rw["Year"] = message.Year;
                rw["Month"] = message.Month;
                rw["Day"] = message.Day;
                rw["Hour"] = message.Hour;
                rw["Minute"] = message.Minute;
                rw["Second"] = message.Second;
                rw["FixQuality"] = message.FixQuality;
                rw["Longitude"] = message.Longitude;
                rw["Latitude"] = message.Latitude;
                rw["EPFD"] = message.EPFD;
                rw["RAIM"] = message.RAIM;
                rw["Spare"] = message.Spare;
                rw["RadioStatus"] = message.RadioStatus;

                dt.Rows.Add(rw);
            }
            return dt;
        }

        public DataTable GetDataTableParameter(IEnumerable<MessageType5> messages)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("MessageType", typeof(string));
            dt.Columns.Add("Repeat", typeof(Int16));
            dt.Columns.Add("MMSI", typeof(Int64));
            dt.Columns.Add("Packet", typeof(string));
            dt.Columns.Add("Channel", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("AisVersion", typeof(string));
            dt.Columns.Add("ImoNumber", typeof(Int64));
            dt.Columns.Add("CallSign", typeof(string));
            dt.Columns.Add("VesselName", typeof(string));
            dt.Columns.Add("ShipType", typeof(string));
            dt.Columns.Add("DimensionToBow", typeof(Int16));
            dt.Columns.Add("DimensionToStern", typeof(Int16));
            dt.Columns.Add("DimensionToPort", typeof(Int16));
            dt.Columns.Add("DimensionToStarboard", typeof(Int16));
            dt.Columns.Add("EPFD", typeof(string));
            dt.Columns.Add("Month", typeof(Int16));
            dt.Columns.Add("Day", typeof(Int16));
            dt.Columns.Add("Hour", typeof(Int16));
            dt.Columns.Add("Minute", typeof(Int16));
            dt.Columns.Add("Draught", typeof(double));
            dt.Columns.Add("Destination", typeof(string));
            dt.Columns.Add("Spare", typeof(Int16));
            dt.Columns.Add("DTE", typeof(string));

            foreach (var message in messages)
            {
                DataRow rw = dt.NewRow();

                rw["Id"] = message.Id;
                rw["Date"] = message.Date ?? (object)DBNull.Value;
                rw["MessageType"] = message.MessageType;
                rw["Repeat"] = message.Repeat;
                rw["MMSI"] = message.MMSI;
                rw["Packet"] = message.Packet;
                rw["Channel"] = message.Channel;
                rw["Country"] = message.Country;
                rw["AisVersion"] = message.AisVersion;
                rw["ImoNumber"] = message.ImoNumber;
                rw["CallSign"] = message.CallSign;
                rw["VesselName"] = message.VesselName;
                rw["ShipType"] = message.ShipType;
                rw["DimensionToBow"] = message.DimensionToBow;
                rw["DimensionToStern"] = message.DimensionToStern;
                rw["DimensionToPort"] = message.DimensionToPort;
                rw["DimensionToStarboard"] = message.DimensionToStarboard;
                rw["EPFD"] = message.EPFD;
                rw["Month"] = message.Month ?? (object)DBNull.Value;
                rw["Day"] = message.Day ?? (object)DBNull.Value;
                rw["Hour"] = message.Hour ?? (object)DBNull.Value;
                rw["Minute"] = message.Minute ?? (object)DBNull.Value;
                rw["Draught"] = message.Draught;
                rw["Destination"] = message.Destination;
                rw["Spare"] = message.Spare;
                rw["DTE"] = message.DTE;

                dt.Rows.Add(rw);
            }
            return dt;
        }

        public DataTable GetDataTableParameter(IEnumerable<MessageType9> messages)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("MessageType", typeof(string));
            dt.Columns.Add("Repeat", typeof(Int16));
            dt.Columns.Add("MMSI", typeof(Int64));
            dt.Columns.Add("Packet", typeof(string));
            dt.Columns.Add("Channel", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Altitude", typeof(string));
            dt.Columns.Add("SOG", typeof(double));
            dt.Columns.Add("Accuracy", typeof(string));
            dt.Columns.Add("Longitude", typeof(double));
            dt.Columns.Add("Latitude", typeof(double));
            dt.Columns.Add("COG", typeof(double));
            dt.Columns.Add("Timestamp", typeof(Int16));
            dt.Columns.Add("Reserved", typeof(Int16));
            dt.Columns.Add("DTE", typeof(string));
            dt.Columns.Add("Assigned", typeof(string));
            dt.Columns.Add("RAIM", typeof(string));
            dt.Columns.Add("Spare", typeof(Int16));
            dt.Columns.Add("RadioStatus", typeof(int));

            foreach (var message in messages)
            {
                DataRow rw = dt.NewRow();

                rw["Id"] = message.Id;
                rw["Date"] = message.Date ?? (object)DBNull.Value;
                rw["MessageType"] = message.MessageType;
                rw["Repeat"] = message.Repeat;
                rw["MMSI"] = message.MMSI;
                rw["Packet"] = message.Packet;
                rw["Channel"] = message.Channel;
                rw["Country"] = message.Country;
                rw["Altitude"] = message.Altitude;
                rw["SOG"] = message.SOG ?? (object)DBNull.Value;
                rw["Accuracy"] = message.Accuracy;
                rw["Longitude"] = message.Longitude;
                rw["Latitude"] = message.Latitude;
                rw["COG"] = message.COG ?? (object)DBNull.Value;
                rw["Timestamp"] = message.Timestamp;
                rw["Reserved"] = message.Reserved;
                rw["DTE"] = message.DTE;
                rw["Assigned"] = message.Assigned;
                rw["RAIM"] = message.RAIM;
                rw["Spare"] = message.Spare;
                rw["RadioStatus"] = message.RadioStatus;

                dt.Rows.Add(rw);
            }
            return dt;
        }

        public DataTable GetDataTableParameter(IEnumerable<MessageType21> messages)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Date", typeof(DateTime));
            dt.Columns.Add("MessageType", typeof(string));
            dt.Columns.Add("Repeat", typeof(Int16));
            dt.Columns.Add("MMSI", typeof(Int64));
            dt.Columns.Add("Packet", typeof(string));
            dt.Columns.Add("Channel", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("AidType", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Accuracy", typeof(string));
            dt.Columns.Add("Longitude", typeof(double));
            dt.Columns.Add("Latitude", typeof(double));
            dt.Columns.Add("DimensionToBow", typeof(Int16));
            dt.Columns.Add("DimensionToStern", typeof(Int16));
            dt.Columns.Add("DimensionToPort", typeof(Int16));
            dt.Columns.Add("DimensionToStarboard", typeof(Int16));
            dt.Columns.Add("EPFD", typeof(string));
            dt.Columns.Add("Second", typeof(Int16));
            dt.Columns.Add("OffPosition", typeof(string));
            dt.Columns.Add("Reserved", typeof(Int16));
            dt.Columns.Add("Spare", typeof(Int16));
            dt.Columns.Add("RAIM", typeof(string));
            dt.Columns.Add("VirtualAidFlag", typeof(string));
            dt.Columns.Add("Assigned", typeof(string));

            foreach (var message in messages)
            {
                DataRow rw = dt.NewRow();

                rw["Id"] = message.Id;
                rw["Date"] = message.Date ?? (object)DBNull.Value;
                rw["MessageType"] = message.MessageType;
                rw["Repeat"] = message.Repeat;
                rw["MMSI"] = message.MMSI;
                rw["Packet"] = message.Packet;
                rw["Channel"] = message.Channel;
                rw["Country"] = message.Country;
                rw["AidType"] = message.AidType;
                rw["Name"] = message.Name;
                rw["Accuracy"] = message.Accuracy;
                rw["Longitude"] = message.Longitude;
                rw["Latitude"] = message.Latitude;
                rw["DimensionToBow"] = message.DimensionToBow;
                rw["DimensionToStern"] = message.DimensionToStern;
                rw["DimensionToPort"] = message.DimensionToPort;
                rw["DimensionToStarboard"] = message.DimensionToStarboard;
                rw["EPFD"] = message.EPFD;
                rw["Second"] = message.Second;
                rw["OffPosition"] = message.OffPosition;
                rw["Reserved"] = message.Reserved;
                rw["Spare"] = message.Spare;
                rw["RAIM"] = message.RAIM;
                rw["VirtualAidFlag"] = message.VirtualAidFlag;
                rw["Assigned"] = message.Assigned;

                dt.Rows.Add(rw);
            }
            return dt;
        }

    }
}
