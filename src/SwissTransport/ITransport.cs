using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, params string[] queries);
        StationBoardRoot searchStationboards(string station, DateTime dateAndTime);
        Connections GetConnections(string fromStation, string toStattion, params string[] queries);
        Connections searchConnections(string startStation, string endStation, int numberOfRows, DateTime departOrArrival, bool isArrival);
    }
}