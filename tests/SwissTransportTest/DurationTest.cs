using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissTransport
{
    [TestClass]
    public class DurationTest
    {
        [TestMethod]
        public void apiDuration_parse_timeSpan()
        {
            string apiDuration = "02d05:33:33";

            TimeSpan duration = Duration.parse(apiDuration);

            Assert.AreEqual(new TimeSpan(2, 5, 33, 33), duration);
       }
       
       [TestMethod]
       public void timeSpan_userOutput_output()
       {
            TimeSpan duration = new TimeSpan(35, 8, 1, 35);

            string userOutput = Duration.userOutput(duration);

            Assert.AreEqual("35 Tage, 8 Stunden, 1 Minute", userOutput);
       }
    }
}
