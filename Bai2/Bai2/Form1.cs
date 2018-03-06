using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string hostname;
            IPHostEntry iphost;
            iphost = Dns.Resolve(textBoxinput.Text);
            textBoxhostname.Text = iphost.HostName;
            listBoxalias.Items.Clear();
            listBoxip.Items.Clear();
            foreach(IPAddress ip in iphost.AddressList)
            {
                listBoxip.Items.Add(ip);
            }
            foreach (string s in iphost.Aliases)
            {
                listBoxalias.Items.Add(s);
            }
        }
    }
}
