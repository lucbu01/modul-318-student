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
    public partial class DepartWindow : Form
    {
        private StationBoard stationBoard;
        private Station station;
        private const string DATETIME_FORMATTER = @"dd\.MM\.yyyy \u\m HH\:mm \U\h\r";

        public DepartWindow(Station station, StationBoard stationBoard)
        {
            InitializeComponent();
            this.station = station;
            this.stationBoard = stationBoard;
            txbName.Text = stationBoard.Name;
            txbFrom.Text = station.Name;
            txbGoal.Text = stationBoard.To;
            txbDepart.Text = stationBoard.Stop.Departure.ToString(DATETIME_FORMATTER);
            txbOrganisation.Text = stationBoard.Operator;
        }

        private void btnViewLocation_Click(object sender, EventArgs e)
        {
            string x = Convert.ToString(station.Coordinate.XCoordinate).Replace(",", ".");
            string y = Convert.ToString(station.Coordinate.YCoordinate).Replace(",", ".");
            Process.Start("https://www.google.ch/maps/place/" + x + "," + y);
        }

        private void DepartWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                Close();
            }
        }
    }
}
