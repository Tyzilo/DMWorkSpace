using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMWorkSpace
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int strValue = int.Parse(StrNumber.Text);

            if (MasteryStr.Checked == true)
            {

                StrMod.Text = (strValue / 2 - 5 + int.Parse(MasteryBonusNumber.Text)).ToString();
            }
            else
            {
                StrMod.Text = (strValue / 2 - 5).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainSpace().Show();
        }

        private void MasteryBonusNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AglNumber_TextChanged(object sender, EventArgs e)
        {
            int AglValue = int.Parse(AglNumber.Text);
            if (MasteryAgl.Checked == true)
            {

                AglMod.Text = (AglValue / 2 - 5 + int.Parse(MasteryBonusNumber.Text)).ToString();
            }
            else
            {
                AglMod.Text = (AglValue / 2 - 5).ToString();
            }
        }

        private void StmNumber_TextChanged(object sender, EventArgs e)
        {
            int StamValue = int.Parse(StmNumber.Text);
            if (MasteryStam.Checked == true)
            {

                StamMod.Text = (StamValue / 2 - 5 + int.Parse(MasteryBonusNumber.Text)).ToString();
            }
            else
            {
                StamMod.Text = (StamValue / 2 - 5).ToString();
            }
        }

        private void IntNumber_TextChanged(object sender, EventArgs e)
        {
            int intValue = int.Parse(IntNumber.Text);
            if (MasteryInt.Checked == true)
            {

                IntMod.Text = (intValue / 2 - 5 + int.Parse(MasteryBonusNumber.Text)).ToString();
            }
            else
            {
                IntMod.Text = (intValue / 2 - 5).ToString();
            }
        }

        private void WisNumber_TextChanged(object sender, EventArgs e)
        {
            int WisValue = int.Parse(WisNumber.Text);
            if (MasteryWis.Checked == true)
            {

                WisMod.Text = (WisValue / 2 - 5 + int.Parse(MasteryBonusNumber.Text)).ToString();
            }
            else
            {
                WisMod.Text = (WisValue / 2 - 5).ToString();
            }
        }

        private void CharNumber_TextChanged(object sender, EventArgs e)
        {
            int CharValue = int.Parse(CharNumber.Text);

            if (MasteryStr.Checked == true)
            {
                CharMod.Text = (CharValue / 2 - 5 + int.Parse(MasteryBonusNumber.Text)).ToString();
            }
            else
            {
                CharMod.Text = (CharValue / 2 - 5).ToString();
            }

        }

        private void MasteryStr_CheckedChanged(object sender, EventArgs e)
        {
            if (MasteryStr.Checked == true)
            {
                int plusMasteryStr = int.Parse(StrMod.Text) + int.Parse(MasteryBonusNumber.Text);
                StrMod.Text = Convert.ToString(plusMasteryStr);
            }
            else
            {
                int plusMasteryStr = int.Parse(StrMod.Text) - int.Parse(MasteryBonusNumber.Text);
                StrMod.Text = Convert.ToString(plusMasteryStr);
            }
        }

        private void MasteryAgl_CheckedChanged(object sender, EventArgs e)
        {
            if (MasteryAgl.Checked == true)
            {
                int plusMasteryAgl = int.Parse(AglMod.Text) + int.Parse(MasteryBonusNumber.Text);
                AglMod.Text = Convert.ToString(plusMasteryAgl);
            }
            else
            {
                int plusMasteryAgl = int.Parse(AglMod.Text) - int.Parse(MasteryBonusNumber.Text);
                AglMod.Text = Convert.ToString(plusMasteryAgl);
            }
        }

        private void MasteryStam_CheckedChanged(object sender, EventArgs e)
        {
            if (MasteryStam.Checked == true)
            {
                int plusMasteryStam = int.Parse(StamMod.Text) + int.Parse(MasteryBonusNumber.Text);
                StamMod.Text = Convert.ToString(plusMasteryStam);
            }
            else
            {
                int plusMasteryStam = int.Parse(StamMod.Text) - int.Parse(MasteryBonusNumber.Text);
                StamMod.Text = Convert.ToString(plusMasteryStam);
            }
        }

        private void MasteryInt_CheckedChanged(object sender, EventArgs e)
        {
            if (MasteryInt.Checked == true)
            {
                int plusMasteryInt = int.Parse(IntMod.Text) + int.Parse(MasteryBonusNumber.Text);
                IntMod.Text = Convert.ToString(plusMasteryInt);
            }
            else
            {
                int plusMasteryInt = int.Parse(IntMod.Text) - int.Parse(MasteryBonusNumber.Text);
                IntMod.Text = Convert.ToString(plusMasteryInt);
            }
        }

        private void MasteryWis_CheckedChanged(object sender, EventArgs e)
        {
            if (MasteryWis.Checked == true)
            {
                int plusMasteryWis = int.Parse(WisMod.Text) + int.Parse(MasteryBonusNumber.Text);
                WisMod.Text = Convert.ToString(plusMasteryWis);
            }
            else
            {
                int plusMasteryWis = int.Parse(WisMod.Text) - int.Parse(MasteryBonusNumber.Text);
                WisMod.Text = Convert.ToString(plusMasteryWis);
            }
        }

        private void MasteryChar_CheckedChanged(object sender, EventArgs e)
        {
            if (MasteryChar.Checked == true)
            {
                int plusMasteryChar = int.Parse(CharMod.Text) + int.Parse(MasteryBonusNumber.Text);
                CharMod.Text = Convert.ToString(plusMasteryChar);
            }
            else
            {
                int plusMasteryChar = int.Parse(CharMod.Text) - int.Parse(MasteryBonusNumber.Text);
                CharMod.Text = Convert.ToString(plusMasteryChar);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void AccBonus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (BonusChose.SelectedIndex)
            {
                case 0:
                    AccBonus.Text = Convert.ToString(int.Parse(StrNumber.Text) / 2 - 5 + int.Parse(MasteryBonusNumber.Text));
                    break;
                case 1:

                    AccBonus.Text = Convert.ToString(int.Parse(AglNumber.Text) / 2 - 5 + int.Parse(MasteryBonusNumber.Text));
                    break;
                case 2:
                    AccBonus.Text = Convert.ToString(int.Parse(StmNumber.Text) / 2 - 5 + int.Parse(MasteryBonusNumber.Text));
                    break;
                case 3:
                    AccBonus.Text = Convert.ToString(int.Parse(IntNumber.Text) / 2 - 5 + int.Parse(MasteryBonusNumber.Text));
                    break;
                case 4:
                    AccBonus.Text = Convert.ToString(int.Parse(WisNumber.Text) / 2 - 5 + int.Parse(MasteryBonusNumber.Text));
                    break;
                case 5:
                    AccBonus.Text = Convert.ToString(int.Parse(CharNumber.Text) / 2 - 5 + int.Parse(MasteryBonusNumber.Text));
                    break;
            }
        }

        private void DamageBonus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (BonusChose.SelectedIndex)
            {
                case 0:
                    DamageBonus.Text = Convert.ToString(int.Parse(StrNumber.Text) / 2 - 5);
                    break;
                case 1:

                    DamageBonus.Text = Convert.ToString(int.Parse(AglNumber.Text) / 2 - 5);
                    break;
                case 2:
                    DamageBonus.Text = Convert.ToString(int.Parse(StmNumber.Text) / 2 - 5  );
                    break;
                case 3:
                    DamageBonus.Text = Convert.ToString(int.Parse(IntNumber.Text) / 2 - 5);
                    break;
                case 4:
                    DamageBonus.Text = Convert.ToString(int.Parse(WisNumber.Text) / 2 - 5);
                    break;
                case 5:
                    DamageBonus.Text = Convert.ToString(int.Parse(CharNumber.Text) / 2 - 5);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = NameCreacher.Text + ".txt";

            string[]  valuesToWrite = {NameCreacher.Text , HPValue.Text , ACValue.Text, MasteryBonusNumber.Text};
    }
}
