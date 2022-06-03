using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SOLIDformExample.RentLogger;
using SOLIDformExample.Cars;

namespace SOLIDformExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            double days = Convert.ToDouble(textBox2.Text);

            var calculate = new HireCostCalculate();
            double result = days * calculate.Calculate(new BMW());

            textBox1.Text = result.ToString();



        }

        public BaseArac WhichCar() 
        {
            BaseArac[] cars = { new BMW(), new Hyundai(), new Kia(), new Mercedes(), new Volkswagen() };
            return (cars[comboBox2.SelectedIndex]);
        
        }


        private void button2_Click(object sender, EventArgs e)
        {
            new RentLogger(new CompanyLogger()).Log("");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RentLogger(new InsuranceLogger()).Log("");

        }
    }
}
