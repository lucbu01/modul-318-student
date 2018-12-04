using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Connections
    {
        [JsonProperty("connections")]
        public List<Connection> ConnectionList { get; set; } 
    }

    public class Connection : DataGridObject
    {
        [JsonProperty("from")]
        public ConnectionPoint From  { get; set; }

        [JsonProperty("to")]
        public ConnectionPoint To { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("products")]
        public string[] products { get; set; }
        
        private const string DATETIME_FORMATTER = @"dd\.MM\.yyyy \u\m HH\:mm \U\h\r";

        /// <summary>
        /// Returns the values departure, duration and arrival in a string array for a GridView row
        /// </summary>
        /// <returns></returns>
        public string[] toRow()
        {
            string departure = Convert.ToDateTime(this.From.Departure).ToString(DATETIME_FORMATTER);
            string duration = SwissTransport.Duration.userOutput(SwissTransport.Duration.parse(this.Duration));
            string arrival = Convert.ToDateTime(this.To.Arrival).ToString(DATETIME_FORMATTER);
            return new string[] { departure, duration, arrival };
        }
    }

    public class ConnectionPoint
    {
        [JsonProperty("station")]
        public Station Station { get; set; }

        public string Arrival { get; set; }

        public string ArrivalTimestamp { get; set; }

        public string Departure { get; set; }

        public string DepartureTimestamp { get; set; }

        public int? Delay { get; set; }

        public string Platform { get; set; }

        public string RealtimeAvailability { get; set; }
    }
}