using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int clic = 0;
        bool NoWin = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button1.Text != "X" && NoWin == true)
            {
                button1.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button1.Text != "0" && NoWin == true)
            {
                button1.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                NoWin = false;
                label1.Text = "Player X won the game !!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button2.Text != "X" && NoWin == true)
            {
                button2.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button2.Text != "0" && NoWin == true)
            {
                button2.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                NoWin = false;
                label1.Text = "Player X won the game !!!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button3.Text != "X" && NoWin == true)
            {
                button3.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button3.Text != "0" && NoWin == true)
            {
                button3.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                NoWin = false;
                label1.Text = "Player X won the game !!!";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button6.Text != "X" && NoWin == true)
            {
                button6.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button6.Text != "0" && NoWin == true)
            {
                button6.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button5.Text != "X" && NoWin == true)
            {
                button5.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button5.Text != "0" && NoWin == true)
            {
                button5.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button4.Text != "X" && NoWin == true)
            {
                button4.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button4.Text != "0" && NoWin == true)
            {
                button4.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button9.Text != "X" && NoWin == true)
            {
                button9.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button9.Text != "0" && NoWin == true)
            {
                button9.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button8.Text != "X" && NoWin == true)
            {
                button8.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button8.Text != "0" && NoWin == true)
            {
                button8.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && button7.Text != "X" && NoWin == true)
            {
                button7.Text = "0";
                label1.Text = "Player's turn X";
                clic++;
            }
            if (clic % 2 == 1 && button7.Text != "0" && NoWin == true)
            {
                button7.Text = "X";
                label1.Text = "Player's turn 0";
                clic++;
            }
        }
    }
}
