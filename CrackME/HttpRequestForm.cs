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

namespace CrackME
{
    public partial class HttpRequestForm : Form
    {
        WebClient webClient = new WebClient();
        public HttpRequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serverLicense = webClient.DownloadString("https://raw.githubusercontent.com/0x01code/CrackME/master/http_requests.txt");
            if (textBox1.Text == serverLicense)
            {
                MessageBox.Show("Activate Key Success..","System",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Activate Key Failed!", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HttpRequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
