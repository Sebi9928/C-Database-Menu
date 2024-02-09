using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Rep2 : Form
    {
        public Rep2()
        {
            InitializeComponent();
        }

       

        private void Rep2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proiectDataSet5.Produse_noi' table. You can move, or remove it, as needed.
            this.produse_noiTableAdapter.Fill(this.proiectDataSet5.Produse_noi);

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Rapoarte r = new Rapoarte();
            r.Show();
            this.Hide();
        }
    }
}
