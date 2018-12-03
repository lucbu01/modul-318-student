using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using SwissTransportApp;

namespace SwissTransportAppTest
{
    [TestFixture]
    class DataCollectorTest
    {
        [Test]
        public void getConnections()
        {
            string stationFrom = "Sursee";
            string stationTo = "Luzern";
            DateTime dateAndTime = DateTime.Now;
            bool isArrivalTime = false;
            int limit = 4;

            List<string[]> rows = DataCollector.getConnections(stationFrom, stationTo, limit, dateAndTime, isArrivalTime);

            Assert.AreEqual(4, rows.Count);
        }

        [Test]
        public void getStationboards()
        {
            string station = "Sursee";
            DateTime dateAndTime = DateTime.Now;

            List<string[]> rows = DataCollector.getStationboards(station, dateAndTime);

            Assert.AreEqual(40, rows.Count);
        }
    }
}
