using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;

namespace SwissTransportApp
{
    //This class is only for describe the Code Guidelines in the documentation
    class DataSearcher
    {
        private static Transport swissTransportApi = new Transport();
        private const int LIMIT_OF_ROWS = 16;

    /// <summary>
    /// Search a list of Stations with a query and returns them
    /// </summary>
    /// <param name="stationName">query</param>
    /// <returns>stations</returns>
    public static List<string> searchStations(string stationName)
    {
            List<string> stations = new List<string>();

            
            foreach (string station in stations)
            {
                // Code ...
            }

            if (stations.Count > 1)
            {
                // Code if ...
            }
            else if (stations.Count == 1)
            {
                // Code else if ...
            }
            else
            {
                //Code else ...
            }
            
            return stations;
        }
    }
}
