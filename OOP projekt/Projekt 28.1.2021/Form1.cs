using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2; //even = x turn; odd = 0 turn;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        //counting wins for both players and draws;


        
        private void buttonCLick(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";
                    button.BackColor = Color.Crimson;
                    player++;
                    turns++;
                }
                else
                {
                    button.Text = "O";
                    button.BackColor = Color.DodgerBlue;
                    player++;
                    turns++;
                }
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Izjednaceno!");
                    sd++;
                    
                    NewGame();
                    
                }

                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X je pobjednik!");
                        s1++;
                        
                        NewGame();
                        
                    }
                    else
                    {
                        MessageBox.Show("O je pobjednik!");
                        s2++;
                        
                        NewGame();
                        
                    }
                    
                }
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized; za prosirivanje
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Izjednacenih: " + sd;
            
        }

        void NewGame()
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                btn.UseVisualStyleBackColor = true;
                btn.BackColor = Control.DefaultBackColor;
            }
            player = 2;
            turns = 0;
            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Izjednacenih: " + sd;
            

        }

        /* private void NGButton_Click(object sender, EventArgs e)
         {

         }*/

        bool CheckDraw()
        {
            if ((turns == 9) && CheckWinner() == false)
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            //horizontalna provjera
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            //vertikalna provjera
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            //dijagonalna provjera
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && A02.Text != "")
                return true;
            else
                return false;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void EButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}