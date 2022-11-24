using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText("./config.json"));

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }

            string host = Convert.ToString(jsonFile["host"]);
            string database = Convert.ToString(jsonFile["database"]);
            string username = Convert.ToString(jsonFile["username"]);
            string password = Convert.ToString(jsonFile["password"]);
            string constring = "Server=" + host + ";Database=" + database + ";Uid=" + username + ";Pwd=" + password + ";";

            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string query = "select fullname from users where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Welcome " + reader["fullname"].ToString(), "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("username and password incorrect", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DatabaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
