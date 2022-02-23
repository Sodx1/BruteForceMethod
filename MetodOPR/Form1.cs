using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetodOPR
{
    public partial class Form1 : Form
    {
   

        
        delegate double f(double x);
        private f func;
        //
        void grah(int n, double a, double b)
        {

            for (int i = 0; i < 4; i++)
            {
                chart1.Series[i].Points.Clear();
            }





            switch (n)
            {
                case 1:
                    func = f1;
                    break;
                case 2:
                    func = f2;
                    break;
                case 3:
                    func = f3;
                    break;
            }

            double x, f;
            x = a;

            while (x <= b)
            {
                f = func(x);
                chart1.Series[0].Points.AddXY(x, f);
                x += (b - a)*0.1;
                
            }
            chart1.Series[0].Points.AddXY(b, func(x));

        }
        //
        
        public Form1()
        {
            InitializeComponent();
        }

        double f1(double x)
        {
            return Math.Pow(x, 2);
        }
        double f2(double x)
        {
            return Math.Cos(x);
        }

        double f3(double x)
        {
            return Math.Exp(x);        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double min=double.MinValue, max=double.MaxValue, a, b, currX, f;
            double eps;
            int n;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            eps = Convert.ToDouble(textBox3.Text);
            double currXmin = a, currXmax = a;
            n = Convert.ToInt32((b - a) / eps);
            max = func(a);
            min = func(a);
            currX = a;

            for (int i = 0; i <= n; i++)
            {
                currX = a + (i * (b - a)) / n;
                //currX = a + (i * ((b + 1)-a)) / n;
                f = func(currX);
                if (f > max)
                {
                    currXmax = currX;
                    max = f;
                    chart1.Series[3].Points.AddXY(currX, max);
                }
                if (f <= min)
                {
                    currXmin = currX;
                    min = f;
                    chart1.Series[3].Points.AddXY(currX,min);
                }

            }

            if (radioButton1.Checked) {
                label4.Text = Convert.ToString(max);
                label8.Text = "";
                chart1.Series[2].Points.AddXY(currXmax, max);
                chart1.Series[1].Points.Clear();

            }
            if (radioButton2.Checked)
            {
                label8.Text = Convert.ToString(min);
                label4.Text = "";
                chart1.Series[1].Points.AddXY(currXmin, min);
                chart1.Series[2].Points.Clear();
            }
           

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

    

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double a, b;
            int u = Convert.ToInt32(listBox1.SelectedItem);
            switch (u)
            {
                case 1:
                    textBox1.Text = "1";
                    textBox2.Text = "1,50";
                    break;
                case 2:
                    textBox1.Text = "-3,50";
                    textBox2.Text = "1,0";
                    break;
                case 3:
                    textBox1.Text = "-1,50";
                    textBox2.Text = "1,50";
                    break;
            }

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            grah(u, a, b);

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}