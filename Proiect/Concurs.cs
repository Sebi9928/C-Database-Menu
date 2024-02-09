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
    public partial class Concurs : Form
    {
        Image[] images = new Image[5];
        private int countdownValue = 5; // Initial countdown value
        private string[] itemNames = { "CUPON 10 LEI", "IPHONE 15 PRO MAX", "PS5", "CUPON 100 LEI", "LAPTOP GAMING TUF" };

        public Concurs()
        {
            InitializeComponent();
        }

        private void Concurs_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < images.Length; i++)
            {
                images[i] = Image.FromFile("photos\\" + (i + 1) + ".jpg");
            }

            // Initialize the countdown label
            lbl_rotiri.Text = countdownValue.ToString();
        }

        Random pictures = new Random();
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int pctOne = pictures.Next(0, 5);
            int pctTwo = pictures.Next(0, 5);
            int pctThree = pictures.Next(0, 5);

            pbxNumberOne.Image = images[pctOne];
            pbxNumberTwo.Image = images[pctTwo];
            pbxNumberThree.Image = images[pctThree];

            // Decrement the countdown value
            countdownValue--;

            // Update the countdown label
            lbl_rotiri.Text = countdownValue.ToString();

            // Check if the countdown has reached 0
            if (countdownValue == 0)
            {
                MessageBox.Show("Ai ramas fara rotiri :(." +
                    "Poate ai mai mult noroc maine :D");
                Meniu meniuForm = new Meniu();

                // Show the Meniu form
                meniuForm.Show();

                // Close the current form (optional)
                this.Close();

                // Reset the countdown value for the next attempt
                countdownValue = 5;

                // Update the countdown label
                lbl_rotiri.Text = countdownValue.ToString();
            }

            // Check for a winning condition
            if (pctOne == pctTwo && pctTwo == pctThree)
            {
                string itemName = itemNames[pctOne];
                MessageBox.Show("Ai castigat! " + itemName);
                MessageBox.Show("Revino maine pentru si mai multe premii!!!");

                Meniu meniuForm = new Meniu();

                // Show the Meniu form
                meniuForm.Show();

                // Close the current form (optional)
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Meniu meniu = new Meniu();
            meniu.Show();
            this.Hide();
        }
    }
}
