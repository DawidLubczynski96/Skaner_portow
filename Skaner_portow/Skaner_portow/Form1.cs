using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Skaner_portow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przycisk_skanuj_Click(object sender, EventArgs e)
        {
            short[] ListaPortow = { 20, 21, 22, 80, 111, 30000 };
            string host = adres.Text;
            info.Items.Add("Skanowanie portów dla " + host);
            info.Items.Add("To może chwilę potrwać... ");
            foreach (short port in ListaPortow)
            {
                this.Refresh();
                try
                {
                    TcpClient klient = new TcpClient(host, port);
                    info.Items.Add("Port: " + port.ToString() + "jest otwarty");
                }
                catch
                {
                    info.Items.Add("Port: " + port.ToString() + "jest zamknięty ");
                }
            }
        }
    }
}
