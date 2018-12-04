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
                    rows.AddRange(connections.ConnectionList);
                }
                else
                {
                    stationBoards = transport.searchStationboards(startStation, departOrArrival);
                    rows.AddRange(stationBoards.Entries);
                }

                foreach (DataGridObject row in rows)
                {
                    tblOutput.Rows.Add(row.toRow());
                }

                tblOutput.Focus();
            }
            catch (Exception ex)
            {
                handleException(ex);
            }
            this.Cursor = Cursors.Default;
        }

        private void showStations(TextBox txbSearch, ListBox lsbShow)
        {
            this.Cursor = Cursors.WaitCursor;
            lsbShow.Items.Clear();
            try
            {
                Stations stations = transport.GetStations(txbSearch.Text);

                foreach (Station station in stations.StationList)
                {
                    lsbShow.Items.Add(station.Name);
                }

                lsbShow.Enabled = true;
                this.AcceptButton = null;
                lsbShow.Focus();
            } catch (Exception ex)
            {
                handleException(ex);
                lsbShow.Enabled = false;
                lsbShow.Items.Clear();
            }
            this.Cursor = Cursors.Default;
        }

        private void txbSelectStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                showStations(txbSelectStartStation, lsbSelectStartStation);
            }
        }

        private void txbSelectEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                showStations(txbSelectEndStation, lsbSelectEndStation);
            }
        }

        private void lsbSelectStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Escape))
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    txbSelectStartStation.Text = Convert.ToString(lsbSelectStartStation.SelectedItem);
                    txbSelectEndStation.Focus();
                }
                else
                {
                    txbSelectStartStation.Focus();
                }

                lsbSelectStartStation.Enabled = false;
                lsbSelectStartStation.Items.Clear();
                this.AcceptButton = btnSearchConnections;
            }
        }

        private void lsbSelectEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) || e.KeyCode.Equals(Keys.Escape))
            {
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    txbSelectEndStation.Focus();
                }
                else
                {
                    txbSelectEndStation.Text = Convert.ToString(lsbSelectEndStation.SelectedItem);
                    if (rdbArrival.Checked)
                    {
                        rdbArrival.Focus();
                    }
                    else
                    {
                        rdbDepart.Focus();
                    }
                }

                lsbSelectEndStation.Enabled = false;
                lsbSelectEndStation.Items.Clear();
                this.AcceptButton = btnSearchConnections;
            }
        }

        private void grbChooseAction_CheckedChanged(object sender, EventArgs e)
        {
            tblOutput.Columns.Clear();

            // change the action
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
        // double click or more
            if (e.Clicks > 1)
            {
                tblOutput_KeyDown(sender, new KeyEventArgs(Keys.Enter));
            }
        }

        private void tblOutput_KeyDown(object sender, KeyEventArgs e)
        {
        // search connections and pressed key enter
            if (rdbSearchConnections.Checked && e.KeyCode.Equals(Keys.Enter))
            {
                int index = tblOutput.CurrentRow.Index;
                ConnectionWindow cw = new ConnectionWindow(connections.ConnectionList[index]);
                cw.ShowDialog(this);
            }
            else
            {
                MainWindow_KeyDown(sender, e);
            }
        }

        enum MessageState { CONNECTION_FAILURE, NO_RESULTS, SEARCH_TOO_SHORT, TOO_MANY_REQUESTS, INTERNET_ERROR }
        private void showMessageBox(MessageState state)
        {
            switch(state)
            {
                case MessageState.CONNECTION_FAILURE:
                    MessageBox.Show(this, "Bitte überprüfen Sie Ihre Internetverbindung!", "Verbindung überprüfen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MessageState.NO_RESULTS:
                    MessageBox.Show(this, "Es wurden keine Ergebnisse gefunden!\nBitte passen Sie Ihre Suche an.", "Keine Ergebnisse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case MessageState.SEARCH_TOO_SHORT:
                    MessageBox.Show(this, "Bitte geben Sie einen genaueren Suchbegriff ein!", "Suche zu kurz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case MessageState.TOO_MANY_REQUESTS:
                    MessageBox.Show(this, "Die Anzahl maximale Aufrufe pro Tag wurde aufgebraucht!\nPro Tag und IP können nur 1000 Abfragen gemacht werden.", "Anfragen aufgebraucht", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case MessageState.INTERNET_ERROR:
                    MessageBox.Show(this, "Es ist ein Internet Problem aufgetreten!", "Internet Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void handleException(Exception ex)
        {
            if (ex.GetType() == typeof(WebException))
            {
                WebException webEx = (WebException)ex;
                if (ex.Message.Contains("Too Many Requests"))
                {
                    showMessageBox(MessageState.TOO_MANY_REQUESTS);
                }
                else if(webEx.Status == WebExceptionStatus.ConnectFailure)
                {
                    showMessageBox(MessageState.CONNECTION_FAILURE);
                }
                else
                {
                    showMessageBox(MessageState.INTERNET_ERROR);
                }
            }
            else if (ex.GetType() == typeof(NoResultsException))
            {
                showMessageBox(MessageState.NO_RESULTS);
            }
            else if (ex.GetType() == typeof(SearchTextsTooShortException))
            {
                showMessageBox(MessageState.SEARCH_TOO_SHORT);
            }

        }
    }
}
