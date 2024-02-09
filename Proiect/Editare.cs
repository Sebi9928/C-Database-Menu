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
    public partial class Editare : Form
    {
        public Editare()
        {
            InitializeComponent();
        }
        class Global
        {
            public static OleDbConnection conexiune = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=Proiect.accdb");
            public static OleDbCommand cmd;
            public static DataTable dt;
        }

        private void Editare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Produse_noi' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'proiectDataSet1.Produse_noi' table. You can move, or remove it, as needed.
            this.produse_noiTableAdapter.Fill(this.proiectDataSet1.Produse_noi);
            this.produse_noiTableAdapter.Fill(this.proiectDataSet1.Produse_noi);
            string prod = "SELECT distinct Nume_produs,Pret FROM Produse_noi";
            DataSet prd = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(prod, Global.conexiune);
            da.Fill(prd, "Nume_produs,Pret");
            dataGridView1.DataSource = prd.Tables["Nume_produs,Pret"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_pret.Text, out double pretValue))
            {
                MessageBox.Show("Pretul trebuie sa fie un numar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "Insert into Produse_noi (Nume_produs,Categorie,Descriere,Pret) values" +
                           "(@nume_produs,@categorie_produs,@desciere,@pret)";
            Global.cmd = new OleDbCommand(query, Global.conexiune);
            Global.cmd.Parameters.AddWithValue("@nume_produs", txt_nume.Text);
            Global.cmd.Parameters.AddWithValue("@categorie_produs", txt_cat.Text);
            Global.cmd.Parameters.AddWithValue("@descriere", txt_desc.Text);
            Global.cmd.Parameters.AddWithValue("@pret", pretValue); 
            Global.conexiune.Open();
            Global.cmd.ExecuteNonQuery();
            Global.conexiune.Close();

            string mesaj = "Numele produsului: " + txt_nume.Text + "\nCategorie " + txt_cat.Text +
                           "\n au fost adaugate la pretul de: " + pretValue.ToString() + "\nLei";
            MessageBox.Show(mesaj);

            txt_nume.Text = "";
            txt_desc.Text = "";
            txt_pret.Text = "";
            txt_cat.Text = "";


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txt_pret.Text, out double pretValue))
            {
                MessageBox.Show("Pretul trebuie sa fie un numar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "UPDATE Produse_noi SET Nume_produs=@nume_produs, Categorie=@categorie_produs, Descriere=@descriere, Pret=@pret  WHERE ID=@id";

            Global.cmd = new OleDbCommand(query, Global.conexiune);
            
            Global.cmd.Parameters.AddWithValue("@nume_produs", txt_nume.Text);
            Global.cmd.Parameters.AddWithValue("@categorie_produs", txt_cat.Text);
            Global.cmd.Parameters.AddWithValue("@descriere", txt_desc.Text);
            Global.cmd.Parameters.AddWithValue("@pret", pretValue);
            Global.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            Global.conexiune.Open();
            Global.cmd.ExecuteNonQuery();
            Global.conexiune.Close();

            MessageBox.Show("Produsul a fost actualizat!");

            proiectDataSet1.Produse_noi.Clear();


            this.produse_noiTableAdapter.Fill(this.proiectDataSet1.Produse_noi);


            dataGridView2.Refresh();
            Editare_Load(sender, e);




    }


    private void button3_Click(object sender, EventArgs e)
        {
            string query = "delete from Produse_noi where ID=@id";
            Global.cmd = new OleDbCommand(query, Global.conexiune);
            Global.cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            Global.conexiune.Open();
            Global.cmd.ExecuteNonQuery();
            Global.conexiune.Close();
            MessageBox.Show("Produsul a fost sters!");
            this.Refresh();
        }

     

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_nume.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_cat.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_desc.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_pret.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string prod = "SELECT distinct Nume_produs, Pret FROM Produse_noi";
            DataSet prd = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(prod, Global.conexiune);
            da.Fill(prd, "Nume_produs,Pret");
            dataGridView1.DataSource = prd.Tables["Nume_produs,Pret"];

            // Reload the data for dataGridView2
            this.produse_noiTableAdapter.Fill(this.proiectDataSet1.Produse_noi);

            // Refresh both DataGridViews
            dataGridView1.Refresh();
            dataGridView2.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Meniu meniuForm = new Meniu();

            // Show the Meniu form
            meniuForm.Show();

            // Close the current form (optional)
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txt_nume.Text = "";
            txt_cat.Text = "";
            txt_desc.Text = "";
            txt_pret.Text = "";

        }
    }
}
