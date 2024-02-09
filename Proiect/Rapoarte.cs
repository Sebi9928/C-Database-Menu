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
    public partial class Rapoarte : Form
    {
        public Rapoarte()
        {
            InitializeComponent();
        }

        private void Rapoarte_Load(object sender, EventArgs e)
        {

           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
          Rep1 r=new Rep1();
            r.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rep2 r = new Rep2();
            r.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Meniu meniuForm = new Meniu();

            // Show the Meniu form
            meniuForm.Show();

            // Close the current form (optional)
            this.Close();
        }
    }
}
