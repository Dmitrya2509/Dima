using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 reg = new Form2();
            reg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Sourse=login.mdb");
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select Count(*) From login where ligin ='" + textBox1.Text + "' and pass = '" + textBox2.Text + "'", connect);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form3 suc = new Form3();
                suc.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Вы ввели неверно логин и пороль!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}












