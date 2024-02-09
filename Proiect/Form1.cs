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

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Proiect.accdb");
            con.Open();
            OleDbCommand c = new OleDbCommand();
            c.CommandText = "SELECT * FROM Utilizatori WHERE Utilizator=@u AND Parola =@p";
            c.Connection = con;
            c.Parameters.AddWithValue("@u", textBox1.Text);
            c.Parameters.AddWithValue("@p", textBox2.Text);
            OleDbDataReader r = c.ExecuteReader();
            int count = 0;
            while (r.Read())
            {
                count =count+1;
            }
            if (count == 1)
            {
                Meniu f = new Meniu();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizator sau parola incorecte!");
                textBox1.Text = String.Empty; 
                textBox2.Text=String.Empty;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
