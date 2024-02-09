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
using System.Data.SqlTypes;

namespace Proiect
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
        }
        class Global
        {
            public static OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Proiect.accdb");
            public static OleDbCommand cmd;
            public static DataTable dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Liste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiectDataSet5.Produse_noi' table. You can move, or remove it, as needed.
            this.produse_noiTableAdapter.Fill(this.proiectDataSet5.Produse_noi);
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataSet1.Produse);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet dsg = new DataSet();
            OleDbDataAdapter adapterg = new OleDbDataAdapter();
            adapterg.SelectCommand = new OleDbCommand(
                "select * from Produse where Nume_produs like '%" + textBox1.Text + "%'", Global.conexiune);
            adapterg.Fill(dsg, "Nume_produs");
            dataGridView1.DataSource = dsg.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataSet dsg = new DataSet();
            OleDbDataAdapter adapterg = new OleDbDataAdapter();
            adapterg.SelectCommand = new OleDbCommand(
                "select * from Produse_noi where Nume_produs like '%" + textBox2.Text + "%'", Global.conexiune);
            adapterg.Fill(dsg, "Nume_produs");
            dataGridView2.DataSource = dsg.Tables[0];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Meniu m = new Meniu();
            m.Show();
            this.Hide();
        }
    }
}
