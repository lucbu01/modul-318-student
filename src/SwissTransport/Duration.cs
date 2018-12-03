using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransport
{
    public class Duration
    {
        public int days { get; }
        public int hours { get; }
        public int minutes { get; }

        public Duration(int days, int hours, int minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }

        /// <summary>
        /// Converts the reponse string "duration" of the SwissTransportAPI
        /// </summary>
        /// <param name="swissTransportFormat"></param>
        /// <returns>Converted Duration</returns>
        public static Duration parse(String swissTransportFormat)
        {
            try
            {
                int durationDays = Convert.ToInt32(swissTransportFormat.Substring(0, 2));
                int durationHours = Convert.ToInt32(swissTransportFormat.Substring(3, 2));
                int durationMinutes = Convert.ToInt32(swissTransportFormat.Substring(6, 2));
                return new Duration(durationDays, durationHours, durationMinutes);
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
        public string toString()
        {
            List<string> duration = new List<string>();
            if (days != 0)
            {
                duration.Add(days + " Tage");
            }
            if (hours != 0)
            {
                duration.Add(hours + " Stunden");
            }
            if (minutes != 0)
            {
                duration.Add(minutes + " Minuten");
            }
            return string.Join(", ", duration);
        }
    }
}
