using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var DiceSound = new SoundPlayer(Properties.Resources.Dice_1D6);

  
            
            label5.Text = "";
            label5.Update();
          
            int n = Convert.ToInt32(numericUpDown1.Value);
            int i = 1;

            int Dice;
            int Sum = 0;




            while (i <= n)

            {
           
                DiceSound.PlaySync();
                Random cRandom = new System.Random();


                Dice = 1 + cRandom.Next(5);

                Sum = Sum + Dice;


                label1.Text = Convert.ToString(Sum);

       
                
               
                
                label5.Text = "Dice Roll Complete";
                i++;
              
            }
   
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var DiceSound = new SoundPlayer(Properties.Resources.Dice_1D6);
            label5.Text = "";
            label5.Update();

            int n = Convert.ToInt32(numericUpDown1.Value);
            int i = 1;

            int Dice;
            int Sum = 0;
            while (i <= n)
            {
                DiceSound.PlaySync();
                Random cRandom = new System.Random();


                Dice = 1 + cRandom.Next(7);

                Sum = Sum + Dice;


                label1.Text = Convert.ToString(Sum);

                label5.Text = "Dice Roll Complete";

                i++;
            }


        }
        private void button3_Click(object sender, EventArgs e)
        {
            var DiceSound = new SoundPlayer(Properties.Resources.Dice_1D6);
            label5.Text = "";
            label5.Update();

            int n = Convert.ToInt32(numericUpDown1.Value);
            int i = 1;

            int Dice;
            int Sum = 0;
            while (i <= n)
            {
                DiceSound.PlaySync();
                Random cRandom = new System.Random();


                Dice = 1 + cRandom.Next(9);

                Sum = Sum + Dice;


                label1.Text = Convert.ToString(Sum);

                label5.Text = "Dice Roll Complete";

                i++;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var DiceSound = new SoundPlayer(Properties.Resources.Dice_1D6);
            label5.Text = "";
            label5.Update();

            int n = Convert.ToInt32(numericUpDown1.Value);
            int i = 1;

            int Dice;
            int Sum = 0;
            while (i <= n)
            {
                DiceSound.PlaySync();
                Random cRandom = new System.Random();


                Dice = 1 + cRandom.Next(11);

                Sum = Sum + Dice;


                label1.Text = Convert.ToString(Sum);

                label5.Text = "Dice Roll Complete";

                i++;
            }


        }
        private void button5_Click(object sender, EventArgs e)
        {
            var DiceSound = new SoundPlayer(Properties.Resources.Dice_1D6);
            label5.Text = "";
            label5.Update();

            int n = Convert.ToInt32(numericUpDown1.Value);
            int i = 1;

            int Dice;
            int Sum = 0;
            while (i <= n)
            {
                DiceSound.PlaySync();
                Random cRandom = new System.Random();


                Dice = 1 + cRandom.Next(19);

                Sum = Sum + Dice;


                label1.Text = Convert.ToString(Sum);

                label5.Text = "Dice Roll Complete";

                i++;
            }


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


  


    }
}
