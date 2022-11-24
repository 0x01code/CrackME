using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKGL;

namespace CrackME
{
    public partial class SerialKeyForm : Form
    {
        private string key = "NAULO-WEFXC-NMSCI-LPTAB";
        public SerialKeyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }

            SerialKey serialKey = new SerialKey();
            int dayleft = serialKey.validate(textBox1.Text);
            label2.Text = dayleft.ToString();
            if (dayleft <= 0)
            {
                MessageBox.Show("Serial Key Expired.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Good Luck!", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SerialKeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SerialKeyForm_Load(object sender, EventArgs e)
        {
            SerialKey serialKey = new SerialKey();
            label2.Text = serialKey.validate(key).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SerialKey serialKey = new SerialKey();
            //textBox2.Text = serialKey.generate(Convert.ToInt32(textBox3.Text));
        }
    }
}
