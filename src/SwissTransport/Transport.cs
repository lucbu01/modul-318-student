using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
                var response = request.GetResponse();
                var responseStream = response.GetResponseStream();

                try
                {
                    var message = new StreamReader(responseStream).ReadToEnd();
                    var stations = JsonConvert.DeserializeObject<Stations>(message, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                    if (stations.StationList.Count > 0)
                    {
                        return stations;
                    }
                    throw new Exception();
                }
                catch (Exception)
                {
                    throw new NoResultsException();
                }
            }
            throw new SearchTextsTooShortException();
        }

        /// <summary>
        /// returns a stationboard by giving a station and optional queries. Query "queryname=value". Read more at https://transport.opendata.ch/docs.html#stationboard
        /// </summary>
        /// <param name="station"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public StationBoardRoot GetStationBoard(string station, params string[] queries)
        {
            // optional attributes can be given
            string query = (queries.Length > 0 ? "&" : "") + string.Join("&", queries);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            try
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard = JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                if (stationboard.Entries.Count > 0)
                {
                    return stationboard;
                }
                throw new Exception();
            }
            catch (Exception)
            {
                throw new NoResultsException();
            }
        }

        #region self-implemented
        /// <summary>
        /// Use the SwissTransport API to search stationboards from a station.
        /// </summary>
        /// <param name="station"></param>
        /// <param name="dateAndTime"></param>
        /// <returns>stationBoardRoot</returns>
        public StationBoardRoot searchStationboards(string station, DateTime dateAndTime)
        {
            if (!string.IsNullOrWhiteSpace(station))
            {
                List<string[]> rows = new List<string[]>();
                string datetime = "datetime=" + dateAndTime.ToString(@"yyyy-MM-dd HH:mm");
                return GetStationBoard(station, datetime);
            }
            throw new SearchTextsTooShortException();
        }
        #endregion

        /// <summary>
        /// returns connections by giving a start station, a end station and optional queries. Query "queryname=value". Read more at https://transport.opendata.ch/docs.html#connections
        /// </summary>
        /// <param name="fromStation"></param>
        /// <param name="toStation"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public Connections GetConnections(string fromStation, string toStation, params string[] queries)
        {
            // optional attributes can be given
            string query = (queries.Length > 0 ? "&" : "") + string.Join("&", queries);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation +query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            try
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections = JsonConvert.DeserializeObject<Connections>(readToEnd);
                if (connections.ConnectionList.Count > 0)
                {
                    return connections;
                }
                throw new Exception();
            }
            catch (Exception)
            {
                throw new NoResultsException();
            }
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }

        #region self-implemented
        /// <summary>
        /// Use the SwissTransport API to search connections between two stations.
        /// </summary>
        /// <param name="startStation"></param>
        /// <param name="endStation"></param>
        /// <param name="numberOfRows"></param>
        /// <param name="departOrArrival"></param>
        /// <param name="isArrival"></param>
        /// <returns>connections</returns>
        public Connections searchConnections(string startStation, string endStation, int numberOfRows, DateTime departOrArrival, bool isArrival)
        {
            // prevent unnecessary calls
            if (!string.IsNullOrWhiteSpace(startStation) && !string.IsNullOrWhiteSpace(endStation) && numberOfRows != 0 && departOrArrival != null)
            {
                string limit = "limit=" + numberOfRows;
                string date = "date=" + departOrArrival.ToString(@"yy-MM-dd");
                string time = "time=" + departOrArrival.ToString(@"HH:mm");
                string isArrivalTime = "isArrivalTime=" + (isArrival ? "1" : "0");
                return GetConnections(startStation, endStation, limit, date, time, isArrivalTime);
            }
            throw new SearchTextsTooShortException();
        }
        #endregion
    }
}
