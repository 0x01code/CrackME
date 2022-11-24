using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btn_login_db_Click(object sender, EventArgs e)
        {
            Hide();
            DatabaseForm form = new DatabaseForm();
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string pathConfig = "./config.json";
            if (!File.Exists(pathConfig))
            {
                using (var sw = new StreamWriter(pathConfig, true))
                {
                    sw.WriteLine("{\r\n    \"host\": \"localhost\",\r\n    \"database\": \"crackme\",\r\n    \"username\": \"root\",\r\n    \"password\": \"\"\r\n}");
                }
            }

            string pathSql = "./database.sql";
            if (!File.Exists(pathSql))
            {
                using (var sw = new StreamWriter(pathSql, true))
                {
                    sw.WriteLine("SET SQL_MODE = \"NO_AUTO_VALUE_ON_ZERO\";\r\nSTART TRANSACTION;\r\nSET time_zone = \"+00:00\";\r\n\r\nCREATE TABLE `users` (\r\n  `id` int(11) NOT NULL,\r\n  `username` varchar(255) NOT NULL,\r\n  `password` varchar(255) NOT NULL,\r\n  `fullname` varchar(255) NOT NULL\r\n) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;\r\n\r\nINSERT INTO `users` (`id`, `username`, `password`, `fullname`) VALUES\r\n(1, 'admin', 'admin', 'administrator'),\r\n(2, 'user01', '1234', 'User 01');\r\n\r\nALTER TABLE `users`\r\nADD PRIMARY KEY (`id`);\r\n\r\nALTER TABLE `users`\r\n  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;\r\nCOMMIT;");
                }
            }
        }

        private void btn_http_requests_Click(object sender, EventArgs e)
        {
            Hide();
            DatabaseForm form = new DatabaseForm();
            form.Show();
        }
    }
}
