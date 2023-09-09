using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace UI1_2_3
{
    public partial class _Default : Page
    {
        protected void btnSubmit_CelsuiusToFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
                //celsius.Text = "Enter temperature in Celsius";
                // TextBox1.Text = "Temperature in Fahrenheit";
                int fahernheitValue = myClient.CelsiusToFahrenheit(int.Parse(celsius.Text));
                TextBox1.Text = fahernheitValue.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter an integer value.", "Not a valid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void btnSubmit_FahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
                // fahrenheit.Text = "Enter temperature in Fahrenheit";
                //TextBox2.Text = "Temperature in Celsius";
                int celsiusValue = myClient.FahrenheitToCelsius(int.Parse(fahrenheit.Text));
                TextBox2.Text = celsiusValue.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter an integer value.", "Not a valid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void btnSubmit_SortNumbers_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
                outputstring.Text = myClient.SortNumbers(inputstring.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter an integer value.", "Not a valid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}