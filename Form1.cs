using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMWorkSpace
{
    public partial class MainSpace : Form
    {
        public MainSpace()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void DiceThrowButton_Click(object sender, EventArgs e)
        {
            Random rDice20 = new Random();
            
            int D20DiceValue = int.Parse(Dice20.Text);                    
            int D20DiceBonus = int.Parse(Bonus20.Text);
            int D20DiceArray = int.Parse(Value20.Text);
           

            Resolt20.Text = Convert.ToString((rDice20.Next(1, D20DiceValue) * D20DiceArray + D20DiceBonus));

            int count = D20DiceArray;
            string[] adventage20 = new string[count];

            for (int i = 0; i < count; i++)
            {
                adventage20[i] = Convert.ToString((rDice20.Next(1, D20DiceValue+1) + D20DiceBonus));

            }
            Resolt20.Text =String.Join(",", adventage20);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DiceThrow12Button_Click(object sender, EventArgs e)
        {
            int D12DiceValue = int.Parse(Dice12.Text);
            int D12DiceBonus = int.Parse(Bonus12.Text);
            int D12DiceArray = int.Parse(Value12.Text);

            Random rDice12 = new Random();

            int count = D12DiceArray;
            string[] adventage12 = new string[count];

            for (int i = 0; i < count; i++)
            {
                adventage12[i] = Convert.ToString((rDice12.Next(1, D12DiceValue + 1)));

            }
            int[] sumarray = new int[adventage12.Length];
            for (int i = 0;i < adventage12.Length; i++)
            {
                sumarray[i] = int.Parse(adventage12[i]);            }
            Resolt12.Text =Convert.ToString(sumarray.Sum () + D12DiceBonus) ;
            


        }

        private void DiceThrow10Button_Click(object sender, EventArgs e)
        {
            int D10DiceValue = int.Parse(Dice10.Text);
            int D10DiceBonus = int.Parse(Bonus10.Text);
            int D10DiceArray = int.Parse(Value10.Text);

            Random rDice10 = new Random();

            int count = D10DiceArray;
            string[] adventage10 = new string[count];

            for (int i = 0; i < count; i++)
            {
                adventage10[i] = Convert.ToString((rDice10.Next(1, D10DiceValue + 1)));

            }
            int[] sumarray = new int[adventage10.Length];
            for (int i = 0; i < adventage10.Length; i++)
            {
                sumarray[i] = int.Parse(adventage10[i]);
            }
            Resolt10.Text = Convert.ToString(sumarray.Sum() + D10DiceBonus);



        }

        private void DiceThrow8Button_Click(object sender, EventArgs e)
        {
            int D8DiceValue = int.Parse(Dice8.Text);
            int D8DiceBonus = int.Parse(Bonus8.Text);
            int D8DiceArray = int.Parse(Value8.Text);

            Random rDice8 = new Random();

            int count = D8DiceArray;
            string[] adventage8 = new string[count];

            for (int i = 0; i < count; i++)
            {
                adventage8[i] = Convert.ToString((rDice8.Next(1, D8DiceValue + 1)));

            }
            int[] sumarray = new int[adventage8.Length];
            for (int i = 0; i < adventage8.Length; i++)
            {
                sumarray[i] = int.Parse(adventage8[i]);
            }
            Resolt8.Text = Convert.ToString(sumarray.Sum() + D8DiceBonus);
        }

        private void DiceThrow6Button_Click(object sender, EventArgs e)
        {
            int D6DiceValue = int.Parse(Dice6.Text);
            int D6DiceBonus = int.Parse(Bonus6.Text);
            int D6DiceArray = int.Parse(Value6.Text);

            Random rDice6 = new Random();

            int count = D6DiceArray;
            string[] adventage6 = new string[count];

            for (int i = 0; i < count; i++)
            {
                adventage6[i] = Convert.ToString((rDice6.Next(1, D6DiceValue + 1)));

            }
            int[] sumarray = new int[adventage6.Length];
            for (int i = 0; i < adventage6.Length; i++)
            {
                sumarray[i] = int.Parse(adventage6[i]);
            }
            Resolt6.Text = Convert.ToString(sumarray.Sum() + D6DiceBonus);
        }

        private void DiceThrow4Button_Click(object sender, EventArgs e)
        {
            int D4DiceValue = int.Parse(Dice4.Text);
            int D4DiceBonus = int.Parse(Bonus4.Text);
            int D4DiceArray = int.Parse(Value4.Text);

            Random rDice4 = new Random();

            int count = D4DiceArray;
            string[] adventage4 = new string[count];

            for (int i = 0; i < count; i++)
            {
                adventage4[i] = Convert.ToString((rDice4.Next(1, D4DiceValue + 1)));

            }
            int[] sumarray = new int[adventage4.Length];
            for (int i = 0; i < adventage4.Length; i++)
            {
                sumarray[i] = int.Parse(adventage4[i]);
            }
            Resolt4.Text = Convert.ToString(sumarray.Sum() + D4DiceBonus);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
