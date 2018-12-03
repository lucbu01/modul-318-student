using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportApp
{
    class DataCollector
    {
        private static Transport transport = new Transport();
        private static string dateTimeFormatter = @"dd\.MM\.yyyy \u\m HH\:mm \U\h\r";

        /// <summary>
        /// Use the SwissTransport API to search connections between two stations.
        /// Returns a list of rows. Each row is a string array with the values departure, platform, duration and arrival.
        /// </summary>
        /// <param name="startStation"></param>
        /// <param name="endStation"></param>
        /// <param name="numberOfRows"></param>
        /// <param name="departOrArrival"></param>
        /// <param name="isArrival"></param>
        /// <returns></returns>
        public static List<string[]> getConnections(string startStation, string endStation, int numberOfRows, DateTime departOrArrival, bool isArrival)
        {
            if (!string.IsNullOrEmpty(startStation) && !string.IsNullOrEmpty(endStation) &&  numberOfRows != 0 && departOrArrival != null)
            {
                string limit = "limit=" + numberOfRows;
                string date = "date=" + departOrArrival.ToString(@"yy-MM-dd");
                string time = "time=" + departOrArrival.ToString(@"HH:mm");
                string isArrivalTime = "isArrivalTime=" + (isArrival ? "1" : "0");
                Connections connections = transport.GetConnections(startStation, endStation, limit, date, time, isArrivalTime);
                List<string[]> rows = new List<string[]>();

                foreach (Connection connection in connections.ConnectionList)
                {
                    string departure = Convert.ToDateTime(connection.From.Departure).ToString(dateTimeFormatter);
                    string duration = Duration.parse(connection.Duration).toString();
                    string platform = connection.From.Platform;
                    string arrival = Convert.ToDateTime(connection.To.Arrival).ToString(dateTimeFormatter);
                    rows.Add(new string[] { departure, platform, duration, arrival });
                }
                return rows;
            }

            return null;
        }

        /// <summary>
        /// Use the SwissTransport API to search stationboards from a station.
        /// Returns a list of rows. Each row is a string array with the values departure, name and goal.
        /// </summary>
        /// <param name="station"></param>
        /// <param name="dateAndTime"></param>
        /// <returns></returns>
        public static List<string[]> getStationboards(string station, DateTime dateAndTime)
        {
            List<string[]> rows = new List<string[]>();
            string datetime = "datetime=" + dateAndTime.ToString(@"yyyy-MM-dd HH:mm");
            string id = null; ;

            try
            {
                id = transport.GetStations(station).StationList[0].Id;
            }
            catch { }

            if (id != null)
            {
                StationBoardRoot root = transport.GetStationBoard(station, id, datetime);
                List<StationBoard> stationBoards = root.Entries;
                foreach (StationBoard stationBoard in stationBoards)
                {
                    string departure = Convert.ToDateTime(stationBoard.Stop.Departure).ToString(dateTimeFormatter);
                    string name = stationBoard.Name;
                    string goal = stationBoard.To;
                    rows.Add(new string[] { departure, name, goal });
                }
                return rows;
            }
            else
            {
                return null;
            }
        }
    }
}
