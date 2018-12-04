using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class Duration
    {

        /// <summary>
        /// Converts the reponse string "duration" of the SwissTransportAPI
        /// </summary>
        /// <param name="swissTransportFormat"></param>
        /// <returns>Converted Duration</returns>
        public static TimeSpan parse(string swissTransportFormat)
        {
            try
            {
                return TimeSpan.Parse(swissTransportFormat.Replace("d", "."));
            }
            catch (Exception)
            {
                throw new FormatException("Die Zeitspanne hat das falsche Format. Es wird ein Format nach folgendem Beispiel verlangt: 00d00:43:00");
            }
        }

        /// <summary>
        /// Converts the duration to a string.
        /// </summary>
        /// <returns>String for GUI Output</returns>
        public static string userOutput(TimeSpan timeSpan)
        {
            List<string> duration = new List<string>();
            if (timeSpan.Days != 0)
            {
                duration.Add(timeSpan.Days + (timeSpan.Days == 1 ? " Tag" : " Tage"));
            }
            if (timeSpan.Hours != 0)
            {
                duration.Add(timeSpan.Hours + (timeSpan.Hours == 1 ? " Stunde" : " Stunden"));
            }
            if (timeSpan.Minutes != 0)
            {
                duration.Add(timeSpan.Minutes + (timeSpan.Minutes == 1 ? " Minute" : " Minuten"));
            }
            return string.Join(", ", duration);
        }
    }
}
