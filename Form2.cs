using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace GRIFINDO_TOYS
{
    public partial class Form2 : Form
    {
        public int Monthly_Salary { get; private set; }

        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "payrol";
            string username = "root";
            int port = 3306;
            string password = "2002mudhitha#";

            string constring = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query= "DELETE FROM test WHERE Employee_ID=" + int.Parse(textBox1.Text);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Succesfully Deleted... Thank you...");
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "payrol";
            string username = "root";
            int port = 3306;
            string password = "2002mudhitha#";

            string constring = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "INSERT INTO test VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            //MySqlDataReader reder = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
            conn.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "payrol";
            string username = "root";
            int port = 3306;
            string password = "2002mudhitha#";

            string constring = "SERVER=" + server + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();

            string query = "SELECT * FROM test WHERE Employee_ID =" + int.Parse(textBox1.Text);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reder = cmd.ExecuteReader();
  

            if (reder.Read())
            {
                textBox2.Text = reder.GetString("Employee_Name");

                double monthsalary = reder.GetDouble("Monthly_Salary");
                textBox3.Text = monthsalary.ToString();

                double eovertime = reder.GetDouble("Overtime_rates");
                textBox4.Text = eovertime.ToString();

                double allowences = reder.GetDouble("Allowences");
                textBox5.Text = allowences.ToString();

                conn.Close();
            }
            else
            {
                MessageBox.Show("Not maching... try again");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
