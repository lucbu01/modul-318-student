using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private Connections connections;
        private StationBoardRoot stationBoards;

        private Transport transport = new Transport();
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
            List<DataGridObject> rows = new List<DataGridObject>();
            string startStation = txbSelectStartStation.Text.Trim();
            DateTime date = dtpDepartOrArrivalDate.Value;
            DateTime time = dtpDepartOrArrivalTime.Value;
            DateTime departOrArrival = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);

            try
            {
                if (rdbSearchConnections.Checked)
                {
                    string endStation = txbSelectEndStation.Text.Trim();
                    bool isArrival = rdbArrival.Checked;
                    connections = transport.searchConnections(startStation, endStation, 5, departOrArrival, isArrival);
                    if(connections != null)
                    {
                        rows.AddRange(connections.ConnectionList);
                    }
                }
                else
                {
                    stationBoards = transport.searchStationboards(startStation, departOrArrival);
                    if(stationBoards != null)
                    {
                        rows.AddRange(stationBoards.Entries);
                    }
                }

                if (rows.Count > 0)
                {
                    foreach (DataGridObject row in rows)
                    {
                        tblOutput.Rows.Add(row.toRow());
                    }
                }
                else
                {
                    MessageBox.Show(this, "Es wurden keine Ergebnisse gefunden!\nBitte passen Sie Ihre Suche an.", "Keine Ergebnisse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                tblOutput.Focus();
                this.Cursor = Cursors.Default;
            }
            catch (WebException ex)
            {
                if(ex.Message.Contains("Too Many Requests"))
                {
                    MessageBox.Show(this, "Die Anzahl maximale Aufrufe pro Tag wurde aufgebraucht!\nPro Tag und IP können nur 1000 Abfragen gemacht werden.", "Anfragen aufgebraucht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

                if (lsbShow.Items.Count > 0)
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
            if (e.KeyCode.Equals(Keys.F2)) {
                bool check = rdbSearchConnections.Checked;
                rdbSearchConnections.Checked = !check;
                rdbSearchDeparts.Checked = check;
                grbChooseAction_CheckedChanged(sender, e);
            }
        }

        private void tblOutput_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1)
            {
                tblOutput_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            }
        }

        private void tblOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (rdbSearchConnections.Checked)
            {
                int index = tblOutput.CurrentRow.Index;
                new ConnectionWindow(connections.ConnectionList[index]).Show();
            }
        }
    }
}
