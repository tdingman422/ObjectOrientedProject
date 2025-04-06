using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProject
{
    public partial class Form1 : Form
    {
        readonly Register register;
        public Form1()
        {
            InitializeComponent();
            register = File_IO_Management.CreateRegister();
            RefreshAmounts();
        }

        //Refreshes amounts of each item on main page
        public void RefreshAmounts()
        {
            label2.Text = "Twenties:" + register.GetTwenties();
            label3.Text = "Tens: " + register.GetTens();
            label4.Text = "Fives: " + register.GetFives();
            label5.Text = "Ones: " + register.GetOnes();
            label6.Text = "Quarters: " + register.GetQuarters();
            label7.Text = "Dimes: " + register.GetDimes();
            label8.Text = "Nickels: " + register.GetNickels();
            label9.Text = "Pennies: " + register.GetPennies();
            string data = register.GetTwenties() + "," + register.GetTens() + "," + register.GetFives() + "," + register.GetOnes()
                + "," + register.GetQuarters() + "," + register.GetDimes() + "," + register.GetNickels() + "," + register.GetPennies();
            File_IO_Management.SaveData(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            ValueEditor.Show();
            textBox16.Text = register.GetTwenties().ToString();
            textBox15.Text = register.GetTens().ToString();
            textBox14.Text = register.GetFives().ToString();
            textBox13.Text = register.GetOnes().ToString();
            textBox12.Text = register.GetQuarters().ToString();
            textBox11.Text = register.GetDimes().ToString();
            textBox10.Text = register.GetNickels().ToString();
            textBox9.Text = register.GetPennies().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                register.SetTwenties(Convert.ToInt32(textBox16.Text));
                register.SetTens(Convert.ToInt32(textBox15.Text));
                register.SetFives(Convert.ToInt32(textBox14.Text));
                register.SetOnes(Convert.ToInt32(textBox13.Text));
                register.SetQuarters(Convert.ToInt32(textBox12.Text));
                register.SetDimes(Convert.ToInt32(textBox11.Text));
                register.SetNickels(Convert.ToInt32(textBox10.Text));
                register.SetPennies(Convert.ToInt32(textBox9.Text));
                RefreshAmounts();
                ValueEditor.Hide();
                MainPanel.Show();
                label32.Text = "";
            }
            catch 
            {
                label32.Text = "All values must be integers.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            Calculate.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshAmounts();
            Calculate.Hide();
            MainPanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label23.Hide();
            double change = 0;
            try
            {
                double price = Convert.ToDouble(textBox1.Text);
                double paid = Convert.ToDouble(textBox2.Text);
                change = paid - price;
                label33.Text = "";
            } 
            catch 
            {
                label33.Text = "Values must be numbers.";
                return;
            }

            //fixes float precision issues
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);

            //determines number of each bill needed using methods in Register class
            int twenties = register.NumTwenties(change);
            change -= (twenties * 20);
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);
            int tens = register.NumTens(change);
            change -= (tens * 10);
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);
            int fives = register.NumFives(change);
            change -= (fives * 5);
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);
            int ones = register.NumOnes(change);
            change -= ones;
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);
            int quarters = register.NumQuarters(change);
            change -= (quarters * 0.25);
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);
            int dimes = register.NumDimes(change);
            change -= (dimes * 0.1);
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);
            int nickels = register.NumNickels(change);
            change -= (nickels * 0.05);
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);
            int pennies = register.NumPennies(change);
            change -= (pennies * 0.01);
            change = Math.Round(change, 2, MidpointRounding.AwayFromZero);

            if (change > 0 || change < 0)
            {
                label23.Show();
            }
            else
            {
                label24.Text += twenties;
                register.DecrementTwenties(twenties);
                label26.Text += tens;
                register.DecrementTens(tens);
                label28.Text += fives;
                register.DecrementFives(fives);
                label30.Text += ones;
                register.DecrementOnes(ones);
                label31.Text += quarters;
                register.DecrementQuarters(quarters);
                label29.Text += dimes;
                register.DecrementDimes(dimes);
                label27.Text += nickels;
                register.DecrementNickels(nickels);
                label25.Text += pennies;
                register.DecrementPennies(pennies);
            }
        }
    }
}
