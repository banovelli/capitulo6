using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, 
                healthyBox.Checked ,fancyBox.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDown2.Value,
                checkBox1.Checked, textBox1.Text);
            DisplayBirthdayPartyCost();

        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            label7.Text = Cost.ToString("c");

        }

        private void DisplayBirthdayPartyCost()
        {
            textBox1.Text = birthdayParty.CakeWriting;
            decimal Cost = birthdayParty.CalculateCost();
            label5.Text = Cost.ToString("c");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDown2.Value;
            birthdayParty.calculateCostOfDecorations(checkBox1.Checked);
            DisplayBirthdayPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.calculateCostOfDecorations(checkBox1.Checked);
            DisplayBirthdayPartyCost();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBox1.Text;
            DisplayBirthdayPartyCost();
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyBox_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyBox_CheckedChanged_1(object sender, EventArgs e)
        {
            dinnerParty.setHeathyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
