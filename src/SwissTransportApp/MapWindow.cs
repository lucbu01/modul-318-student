using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace SwissTransportApp
{
    public partial class MapWindow : Form
    {
        ChromiumWebBrowser wbbshoww;
        public MapWindow(double latitude, double longitude)
        {
            
            InitializeComponent();
            string x = Convert.ToString(latitude).Replace(",", ".");
            string y = Convert.ToString(longitude).Replace(",", ".");
            Uri uri = new Uri("https://www.google.ch/maps/place/" + x + "," + y);
            wbbShow.Url = uri;
        }
    }
}
