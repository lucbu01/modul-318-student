using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportApp
{
    public partial class MainWindow : Form
    {

        private ITransport transport = new Transport();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            tblShowConnections.Rows.Clear();
            
            Connections connections = transport.GetConnections(txbSelectStartStation.Text, txbSelectEndStation.Text);
            
            foreach(Connection connection in connections.ConnectionList) {
                string departure = Convert.ToDateTime(connection.From.Departure).ToString(@"dd\.MM\.yy \u\m HH\:mm");
                int durationDays = Convert.ToInt32(connection.Duration.Substring(0, 2));
                int durationHours = Convert.ToInt32(connection.Duration.Substring(3, 2));
                int durationMinutes = Convert.ToInt32(connection.Duration.Substring(6, 2));
                List<string> duration = new List<string>();
                if (durationDays != 0) {
                    duration.Add(durationDays + " Tage");
                }
                if (durationHours != 0) {
                    duration.Add(durationHours + " Stunden");
                }
                if (durationMinutes != 0) {
                    duration.Add(durationMinutes + " Minuten");
                }
                string arrival = Convert.ToDateTime(connection.To.Arrival).ToString(@"dd\.MM\.yy \u\m HH\:mm");
                tblShowConnections.Rows.Add(new string[] { departure, string.Join(", ", duration), arrival });
            }
        }

        private void lsbSelectStartStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSelectStartStation.Text = Convert.ToString(lsbSelectStartStation.SelectedItem);
        }
        private void lsbSelectEndStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSelectEndStation.Text = Convert.ToString(lsbSelectEndStation.SelectedItem);
        }

        private void showStations(TextBox searcher, ListBox shower) {
            shower.Items.Clear();
            if (!string.IsNullOrEmpty(searcher.Text.Trim())) {
                if (searcher.Focused) {
                    Stations stations = transport.GetStations(searcher.Text);
                    foreach (Station station in stations.StationList)
                    {
                        shower.Items.Add(station.Name);
                    }
                    shower.Focus();
                }
                shower.Enabled = true;
            } else {
                shower.Enabled = false;
            }
        }

        private void txbSelectStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) {
                showStations(txbSelectStartStation, lsbSelectStartStation);
            }
        }

        private void txbSelectEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter)) {
                showStations(txbSelectEndStation, lsbSelectEndStation);
            }
        }

        private void lsbSelectStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                txbSelectEndStation.Focus();
                lsbSelectStartStation.Enabled = false;
                lsbSelectStartStation.Items.Clear();
            }
        }

        private void lsbSelectEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnSearchConnections.Focus();
                btnSearchConnections_Click(sender, e);
                lsbSelectEndStation.Enabled = false;
                lsbSelectEndStation.Items.Clear();
            }
        }
    }
}
