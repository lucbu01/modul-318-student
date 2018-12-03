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
            txbDuration.Text = Duration.parse(connection.Duration).toString();
            txbFrom.Text = connection.From.Station.Name;
            txbTo.Text = connection.To.Station.Name;
            txbDepart.Text = Convert.ToDateTime(connection.From.Departure).ToString(DATETIME_FORMATTER);
            txbArrival.Text = Convert.ToDateTime(connection.To.Arrival).ToString(DATETIME_FORMATTER);
            txbDepartPlatform.Text = connection.From.Platform;
            txbArrivalPlatform.Text = connection.To.Platform;
         }

        private void btnViewStartLocation_Click(object sender, EventArgs e)
        {
            new MapWindow(connection.From.Station.Coordinate.XCoordinate, connection.From.Station.Coordinate.YCoordinate).Show();
        }

        private void btnViewEndLocation_Click(object sender, EventArgs e)
        {
            new MapWindow(connection.To.Station.Coordinate.XCoordinate, connection.To.Station.Coordinate.YCoordinate).Show();
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
        }
    }
}
