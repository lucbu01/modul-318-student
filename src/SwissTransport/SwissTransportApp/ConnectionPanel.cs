using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissTransportApp
{
    class ConnectionPanel : TableLayoutPanel {
        Connection connection;
        public ConnectionPanel(Connection connection) {
            this.connection = connection;
            this.Width = 100;
            this.Height = 50;
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Label lblStartTime = new Label();
            lblStartTime.Text = connection.From.DepartureTimestamp;
            Label lblEndTime = new Label();
            lblEndTime.Text = connection.To.ArrivalTimestamp;
            Controls.Add(lblStartTime, 0, 0);
            Controls.Add(lblEndTime, 1, 0);
        }
    }
}
