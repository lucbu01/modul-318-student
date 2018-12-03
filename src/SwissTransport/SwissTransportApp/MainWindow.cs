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
        private DataGridViewTextBoxColumn clmName = new DataGridViewTextBoxColumn();
        private DataGridViewTextBoxColumn clmGoal = new DataGridViewTextBoxColumn();

        private ITransport transport = new Transport();
        public MainWindow()
        {
            InitializeComponent();
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmGoal.HeaderText = "Ziel";
            this.clmGoal.Name = "clmGoal";
            this.clmGoal.ReadOnly = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lsbSelectStartStation.Focus();
        }

        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            tblOutput.Rows.Clear();
            List<string[]> rows;
            string startStation = txbSelectStartStation.Text.Trim();
            DateTime date = dtpDepartOrArrivalDate.Value;
            DateTime time = dtpDepartOrArrivalTime.Value;
            DateTime departOrArrival = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
            if (rdbSearchConnections.Checked)
            {
                string endStation = txbSelectEndStation.Text.Trim();
                bool isArrival = rdbArrival.Checked;
                rows = DataCollector.getConnections(startStation, endStation, 5, departOrArrival, isArrival);
            }
            else
            {
                rows = DataCollector.getStationboards(startStation, departOrArrival);
            }
            if (rows != null)
            {
                foreach (string[] row in rows)
                {
                    tblOutput.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show(this, "Es wurden keine Ergebnisse gefunden!\nBitte passen Sie Ihre Suche an.", "Keine Ergebnisse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tblOutput.Focus();
            this.Cursor = Cursors.Default;
        }

        private void lsbSelectStartStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSelectStartStation.Text = Convert.ToString(lsbSelectStartStation.SelectedItem);
        }
        private void lsbSelectEndStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbSelectEndStation.Text = Convert.ToString(lsbSelectEndStation.SelectedItem);
        }

        private void showStations(TextBox txbSearch, ListBox lsbShow)
        {
            this.Cursor = Cursors.WaitCursor;
            lsbShow.Items.Clear();
            if (!string.IsNullOrEmpty(txbSearch.Text.Trim()))
            {
                Stations stations = transport.GetStations(txbSearch.Text);

                foreach (Station station in stations.StationList)
                {
                    lsbShow.Items.Add(station.Name);
                }

                lsbShow.Enabled = true;
                lsbShow.Focus();

                if(lsbShow.Items.Count > 0)
                {
                    lsbShow.SelectedIndex = 0;
                }
            }
            else
            {
                lsbShow.Enabled = false;
            }
            this.Cursor = Cursors.Default;
        }

        private void txbSelectStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                showStations(txbSelectStartStation, lsbSelectStartStation);
                this.AcceptButton = null;
            }
        }

        private void txbSelectEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                showStations(txbSelectEndStation, lsbSelectEndStation);
                this.AcceptButton = null;
            }
        }

        private void lsbSelectStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                txbSelectEndStation.Focus();
                lsbSelectStartStation.Enabled = false;
                lsbSelectStartStation.Items.Clear();
                this.AcceptButton = btnSearchConnections;
            }
        }

        private void lsbSelectEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (rdbArrival.Checked)
                {
                    rdbArrival.Focus();
                }
                else
                {
                    rdbDepart.Focus();
                }

                lsbSelectEndStation.Enabled = false;
                lsbSelectEndStation.Items.Clear();
                this.AcceptButton = btnSearchConnections;
            }
        }

        private void grbChooseAction_CheckedChanged(object sender, EventArgs e)
        {
            tblOutput.Columns.Clear();

            if (rdbSearchConnections.Checked)
            {
                btnSearchConnections.Text = "Verbindungen suchen";
                lblSelectStartStation.Text = "Startstation auswählen (Autocomp: F1)";
                pnlSelectEndStation.Enabled = true;
                grbDepartOrArrival.Enabled = true;
                tblOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                clmDeparture,
                clmPlatform,
                clmDuration,
                clmArrival});
            }
            else
            {
                btnSearchConnections.Text = "Abfahrten suchen";
                lblSelectStartStation.Text = "Station auswählen (Autocomp: F1)";
                pnlSelectEndStation.Enabled = false;
                grbDepartOrArrival.Enabled = false;
                tblOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                clmDeparture,
                clmName,
                clmGoal});
            }
            lsbSelectStartStation.Focus();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.F2)) {
                bool check = rdbSearchConnections.Checked;
                rdbSearchConnections.Checked = !check;
                rdbSearchDeparts.Checked = check;
                grbChooseAction_CheckedChanged(sender, e);
            }
        }
    }
}
