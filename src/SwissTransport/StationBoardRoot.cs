using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class StationBoardRoot
    {
        [JsonProperty("Station")]
        public Station Station { get; set; }

        [JsonProperty("stationboard")]
        public List<StationBoard> Entries { get; set; }
    }


    public class StationBoard : DataGridObject
    {
        private const string DATETIME_FORMATTER = @"dd\.MM\.yyyy \u\m HH\:mm \U\h\r";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("Number")]
        public string Number { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("stop")]
        public Stop Stop { get; set; }

        /// <summary>
        /// 
        /// Returns the values departure, name and goal in a string array for a GridView row
        /// </summary>
        /// <returns></returns>
        public string[] toRow()
        {
            string departure = Convert.ToDateTime(this.Stop.Departure).ToString(DATETIME_FORMATTER);
            string name = this.Name;
            string goal = this.To;
            return new string[] { departure, name, goal };
        }
    }

    public class Stop
    {
        [JsonProperty("departure")]
        public DateTime Departure { get; set; }
    }
}