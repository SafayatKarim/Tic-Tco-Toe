using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_toc_toe
{
    public partial class Form1 : Form
    {
        int counter = 0;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            
            if (counter == 0)
            {
                A1.Text = "X";
                counter++;
                textBox2.Text=("Playar2");
            }
            else if (counter == 1)
            {
                A1.Text = "O";
                counter--;
                textBox2.Text = ("Playar1");
            }
            A1.Enabled = false;
            check();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                A2.Text = "X";
                counter++;
                textBox2.Text = ("Playar2");
            }
            else if (counter == 1)
            {
                A2.Text = "O";
                counter--;
                textBox2.Text = ("Playar1");
            }
            A2.Enabled = false;
            check();


        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                A3.Text = "X";
                counter++;
                textBox2.Text = ("Playar2");
            }
            else if (counter == 1)
            {
                textBox2.Text = ("Playar2");
                A3.Text = "O";
                counter--;
                
            }
            A3.Enabled = false;
            check();

        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                B1.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                textBox2.Text = ("Playar2");
                B1.Text = "O";
                counter--;
            }
            B1.Enabled = false;
            check();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                B2.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                B2.Text = "O";
                counter--;
            }
            B2.Enabled = false;
            check();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                B3.Text = "X";
                counter++;
                textBox2.Text = "Playar2";
            }
            else if (counter == 1)
            {
                B3.Text = "O";
                counter--;
            }
            B3.Enabled = false;
            check();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                C1.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                C1.Text = "O";
                counter--;
            }
            C1.Enabled = false;
            check();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                C2.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                C2.Text = "O";
                counter--;
            }
            C2.Enabled = false;
            check();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                C3.Text = "X";
                counter++;
            }
            else if (counter == 1)
            {
                C3.Text = "O";
                counter--;
            }
            C3.Enabled = false;
            check();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            A1.Text = "";
            A1.Enabled = true;
            A2.Text = "";
            A2.Enabled = true;
            A3.Text = "";
            A3.Enabled = true;
            B1.Text = "";
            B1.Enabled = true;
            B2.Text = "";
            B2.Enabled = true;
            B3.Text = "";
            B3.Enabled = true;
            C1.Text = "";
            C1.Enabled = true;
            C2.Text = "";
            C2.Enabled = true;
            C3.Text = "";
            C3.Enabled = true;
            MessageBox.Show("Playar 1 turns First");
            counter = 1;

        }



        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            A1.Text = "";
            A1.Enabled = true;
            A2.Text = "";
            A2.Enabled = true;
            A3.Text = "";
            A3.Enabled = true;
            B1.Text = "";
            B1.Enabled = true;
            B2.Text = "";
            B2.Enabled = true;
            B3.Text = "";
            B3.Enabled = true;
            C1.Text = "";
            C1.Enabled = true;
            C2.Text = "";
            C2.Enabled = true;
            C3.Text = "";
            C3.Enabled = true;
            MessageBox.Show("Play again!");
            MessageBox.Show("Playar 2 turns First");
            counter = 1;
        }
  

        public void check()
        {

            if (A1.Text != "" && A2.Text != "" && A3.Text != "" &&
                B1.Text != "" && B2.Text != "" && B3.Text != "" &&
                C1.Text != "" && C2.Text != "" && C3.Text != "")
            {
                MessageBox.Show("Tied");
            }


            if (A1.Text == "X" && B2.Text == "X" && C3.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;                 
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }
            if (A3.Text == "X" && B2.Text == "X" && C1.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }

            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }
            if (B1.Text == "X" && B2.Text == "X" && B3.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }
            if (C1.Text == "X" && C2.Text == "X" && C3.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }

            if (A1.Text == "X" && B1.Text == "X" && C1.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
            }
            if (A2.Text == "X" && B2.Text == "X" && C2.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                if (A3.Text == "X" && B3.Text == "X" && C3.Text == "X")
                {
                    MessageBox.Show("Player 1 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }

 

                if (A1.Text == "O" && B2.Text == "O" && C3.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
                if (A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }

                if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
                if (B1.Text == "O" && B2.Text == "O" && B3.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
                if (C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;

                }

                if (A1.Text == "O" && B1.Text == "O" && C1.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }

                if (A2.Text == "O" && B2.Text == "O" && C2.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
                if (A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
                {
                    MessageBox.Show("Player 2 wins");
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }


             

            }

        }
      
    }
}
            
        
    

