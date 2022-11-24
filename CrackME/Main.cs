using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackME
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_find_password_Click(object sender, EventArgs e)
        {
            Hide();
            PasswordCheck form = new PasswordCheck();
            form.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_serial_key_Click(object sender, EventArgs e)
        {
            Hide();
            SerialKeyForm form = new SerialKeyForm();
            form.Show();
        }
    }
}
