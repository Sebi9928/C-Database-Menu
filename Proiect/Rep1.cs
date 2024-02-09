using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class Rep1 : Form
    {
        public Rep1()
        {
            InitializeComponent();
        }

       
        private void Rep1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiectDataSet5.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.proiectDataSet5.Produse);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Rapoarte r = new Rapoarte();
            r.Show();
            this.Hide();
        }
    }
}
