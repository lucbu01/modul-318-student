using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace SwissTransport
{
    public class Transport : ITransport
    {
        public Stations GetStations(string query)
        {
            var request = CreateWebRequest("http://transport.opendata.ch/v1/locations?query=" + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var message = new StreamReader(responseStream).ReadToEnd();
                var stations = JsonConvert.DeserializeObject<Stations>(message
                    , new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                return stations;
            }

            return null;
        }

        /// <summary>
        /// returns a stationboard by giving a station and optional queries. Query "queryname=value". Read more at https://transport.opendata.ch/docs.html#stationboard
        /// </summary>
        /// <param name="station"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public StationBoardRoot GetStationBoard(string station, params string[] queries)
        {
            string query = (queries.Length > 0 ? "&" : "") + string.Join("&", queries);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/stationboard?station=" + station + query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var stationboard =
                    JsonConvert.DeserializeObject<StationBoardRoot>(readToEnd);
                return stationboard;
            }

            return null;
        }

        /// <summary>
        /// returns connections by giving a start station, a end station and optional queries. Query "queryname=value". Read more at https://transport.opendata.ch/docs.html#connections
        /// </summary>
        /// <param name="fromStation"></param>
        /// <param name="toStation"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        public Connections GetConnections(string fromStation, string toStation, params string[] queries)
        {
            string query = (queries.Length > 0 ? "&" : "") + string.Join("&", queries);
            var request = CreateWebRequest("http://transport.opendata.ch/v1/connections?from=" + fromStation + "&to=" + toStation +query);
            var response = request.GetResponse();
            var responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                var readToEnd = new StreamReader(responseStream).ReadToEnd();
                var connections =
                    JsonConvert.DeserializeObject<Connections>(readToEnd);
                return connections;
            }

            return null;
        }

        private static WebRequest CreateWebRequest(string url)
        {
            var request = WebRequest.Create(url);
            var webProxy = WebRequest.DefaultWebProxy;

            webProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
            request.Proxy = webProxy;
            
            return request;
        }
    }
}
