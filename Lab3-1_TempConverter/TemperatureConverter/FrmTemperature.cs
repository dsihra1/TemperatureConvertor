using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Devon Sihra
namespace TemperatureConverter
{
    public partial class FrmTemperature : Form
    {
        public FrmTemperature()
        {
            InitializeComponent();
        }

        private void btnCalcFahrenheit_Click(object sender, EventArgs e)
        {
            //get value from user 
            double calcFah = double.Parse(txtTemperature.Text);
            double calcCel = double.Parse(txtTemperature.Text);

            calcFah = 9.0 / 5.0 * calcCel + 32.0;

            lblFahrenheit.Text = calcFah.ToString(); 

        }

        private void btnCalcCelsius_Click(object sender, EventArgs e)
        {
            //get val from user 
            double calcCel = double.Parse(txtTemperature.Text);
            double calcFah = double.Parse(txtTemperature.Text);

            calcCel = 5.0 / 9.0 * (calcFah - 32.0);            lblCelsius.Text = calcCel.ToString();
        }
    }
}
