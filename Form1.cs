using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCoinCounter
{
    public partial class Form1 : Form
    {
        int PennyCount = 0;
        int TwoPennyCount = 0;
        int FivePennyCount = 0;
        int TenPennyCount = 0;
        int TwentyPennyCount = 0;
        int FiftyPennyCount = 0;
        int OnePoundCount = 0;
        int TwoPoundCount = 0;

        double PennyCountTotal = 0.01;
        double TwoPennyCountTotal = 0.02;
        double FivePennyCountTotal = 0.05;
        double TenPennyCountTotal = 0.10;
        double TwentyPennyCountTotal = 0.20;
        double FiftyPennyCountTotal = 0.50;
        double OnePoundCountTotal = 1.00;
        double TwoPoundCountTotal = 2.00;

        double FullTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PennyCount++;
            label2.Text = Convert.ToString(PennyCount);

            FullTotal += PennyCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TwoPennyCount++;
            label3.Text = TwoPennyCount.ToString();

            FullTotal += TwoPennyCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FivePennyCount++;
            label4.Text = FivePennyCount.ToString();

            FullTotal += FivePennyCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TenPennyCount++;
            label5.Text = TenPennyCount.ToString();

            FullTotal += TenPennyCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TwentyPennyCount++;
            label6.Text = TwentyPennyCount.ToString();

            FullTotal += TwentyPennyCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FiftyPennyCount++;
            label7.Text = FiftyPennyCount.ToString();

            FullTotal += FiftyPennyCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OnePoundCount++;
            label8.Text = OnePoundCount.ToString();

            FullTotal += OnePoundCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TwoPoundCount++;
            label9.Text = TwoPoundCount.ToString();

            FullTotal += TwoPoundCountTotal;
            label1.Text = Convert.ToString(FullTotal);
            label10.Text = Convert.ToString(FullTotal);
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(0);
            label2.Text = Convert.ToString(0);
            label3.Text = Convert.ToString(0);
            label4.Text = Convert.ToString(0);
            label5.Text = Convert.ToString(0);
            label6.Text = Convert.ToString(0);
            label7.Text = Convert.ToString(0);
            label8.Text = Convert.ToString(0);
            label9.Text = Convert.ToString(0);
            label10.Text = Convert.ToString(0);
            label11.Text = Convert.ToString(0);



        }
    }
}
