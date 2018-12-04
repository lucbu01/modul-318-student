using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportApp
{
    public partial class ConnectionWindow : Form
    {
        private Connection connection;
        private const string DATETIME_FORMATTER = @"dd\.MM\.yyyy \u\m HH\:mm \U\h\r";

        public ConnectionWindow(Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
            txbProducts.Text = string.Join(", ", connection.products);
            txbDuration.Text = Duration.parse(connection.Duration).userOutput();
            txbFrom.Text = connection.From.Station.Name;
            txbTo.Text = connection.To.Station.Name;
            txbDepart.Text = Convert.ToDateTime(connection.From.Departure).ToString(DATETIME_FORMATTER);
            txbArrival.Text = Convert.ToDateTime(connection.To.Arrival).ToString(DATETIME_FORMATTER);
            txbDepartPlatform.Text = connection.From.Platform;
            txbArrivalPlatform.Text = connection.To.Platform;
            Select();
         }

        private void btnViewStartLocation_Click(object sender, EventArgs e)
        {
            openMapsLink(connection.From.Station.Coordinate);
        }

        private void btnViewEndLocation_Click(object sender, EventArgs e)
        {
            openMapsLink(connection.To.Station.Coordinate);
        }

        private void openMapsLink(Coordinate coordinate)
        {
            string x = Convert.ToString(coordinate.XCoordinate).Replace(",", ".");
            string y = Convert.ToString(coordinate.YCoordinate).Replace(",", ".");
            Process.Start("https://www.google.ch/maps/place/" + x + "," + y);
        }

        private void ConnectionWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                btnViewStartLocation_Click(sender, e);
            } 
            else if (e.KeyCode.Equals(Keys.F2))
            {
                btnViewEndLocation_Click(sender, e);
            }
            else if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Escape))
            {
                Close();
            }
        }
    }
}
