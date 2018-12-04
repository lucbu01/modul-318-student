using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern");

            Assert.IsNotNull(connections);
        }

        #region self-implemented

        [TestMethod]
        public void transport_searchConnections_connections()
        {
            testee = new Transport();
            string stationFrom = "Sursee";
            string stationTo = "Luzern";
            DateTime dateAndTime = DateTime.Now;
            bool isArrivalTime = false;
            int limit = 4;

            Connections connections = testee.searchConnections(stationFrom, stationTo, limit, dateAndTime, isArrivalTime);

            Assert.AreEqual(4, connections.ConnectionList.Count);
            Assert.AreEqual("Sursee", connections.ConnectionList[0].From.Station.Name);
            Assert.AreEqual("Luzern", connections.ConnectionList[0].To.Station.Name);
        }

        [TestMethod]
        public void transport_searchStationboards_stationBoardRoot()
        {
            testee = new Transport();
            string station = "Sursee";
            DateTime dateAndTime = DateTime.Now;

            StationBoardRoot stationBoards = testee.searchStationboards(station, dateAndTime);
            
            Assert.AreEqual("Sursee", stationBoards.Station.Name);
        }

        #endregion
    }
}
