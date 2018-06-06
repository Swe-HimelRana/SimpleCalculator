using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
         
        public Calculator()
        {
            
            InitializeComponent();
        }
         
        

        // Number Storage
        double numStorage;
        String sign = "";
        string result;
        

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            
           // this.numStorage = 0.0D;
            this.sign = "";
        }
        // Clear Second Value
        private void SecondClear_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
        }
        // Dot
        private void btnDot_Click(object sender, EventArgs e)
        {
            // I don't want to alow dot more then one time :p
            if (resultBox.Text.ToLower().Contains('.'))
            {
              resultBox.Text =  resultBox.Text.Replace(".", string.Empty);
                 
            }
            resultBox.Text = resultBox.Text + '.';
        }
        // Zeor
        private void btnZero_Click(object sender, EventArgs e)
        {
            
            resultBox.Text = resultBox.Text + 0;
        }
        // One
        private void btnOne_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 1;
        }
        // Two
        private void btnTwo_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 2;
        }
        // Three
        private void btnThree_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 3;
        }
        // Four
        private void btnFour_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 4;
        }
        // Five
        private void btnFive_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 5;
        }
        // Six
        private void btnSix_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 6;
        }
        // Seven
        private void btnSeven_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 7;
        }
        // Eight
        private void btnEight_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 8;
        }
        // Nine
        private void btnNine_Click(object sender, EventArgs e)
        {
            resultBox.Text = resultBox.Text + 9;
        }
       
        // Method for Taking a valid input for calculation
        private void validCalculation(String whattodo)
        {
            try
            {
                this.sign = whattodo;
                this.numStorage = double.Parse(resultBox.Text);
                resultBox.Clear();
                
            }
            catch
            {
               // MessageBox.Show("Give Valid Input to start Calculation!");
               // Something heppening here.. May be one fix needed.
            }
        }
        // Addition
        private void btnAddition_Click(object sender, EventArgs e)
        {
            validCalculation("+");
            lblCalculation.Text = this.numStorage.ToString() + " + "; // Showing what's going on
        }
        // Substruction
        private void btnSubstruction_Click(object sender, EventArgs e)
        {
            validCalculation("-");
            lblCalculation.Text = this.numStorage.ToString() + " - "; // Showing what's going on
        }
        // Multiplication
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            validCalculation("x");
            lblCalculation.Text = this.numStorage.ToString() + " x "; // Showing what's going on

        }

        // Division
        private void btnDivision_Click(object sender, EventArgs e)
        {
            validCalculation("/");
            lblCalculation.Text = this.numStorage.ToString() + " / "; // Showing what's going on
        }

        // Squire 
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(resultBox.Text);

                resultBox.Text = Calculation.squire(input).ToString();
            }
            catch
            {
                MessageBox.Show("Give me Correct Input!");
            }
        }
        // Sqrt
        private void btnRoot_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(resultBox.Text);

                resultBox.Text = Calculation.sqrt(input).ToString();
            }
            catch
            {
                MessageBox.Show("Give me Correct Input!");
            }
        }


        // Finally Start Calculation
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (sign == "")
            {
                MessageBox.Show("Input some data and make a condition for Calculation");
            }
            else
            {
                try
                {
                    double secondInput = Double.Parse(resultBox.Text);
                    double firstInput = this.numStorage;
                    switch (sign)
                    {
                        case "+":
                            this.result = Calculation.addition(firstInput, secondInput).ToString();
                            resultBox.Text = this.result;
                            lblCalculation.Text = lblCalculation.Text + secondInput.ToString() + " = " + this.result; // Showing what's going on
                            
                            break;
                        case "-":
                            this.result = Calculation.substruction(firstInput, secondInput).ToString();
                            resultBox.Text = this.result;
                            lblCalculation.Text = lblCalculation.Text + secondInput.ToString() + " = " + this.result; // Showing what's going on
                            break;
                        case "x":
                            this.result = Calculation.multiplication(firstInput, secondInput).ToString();
                            resultBox.Text = this.result;
                            lblCalculation.Text = lblCalculation.Text + secondInput.ToString() + " = " + this.result; // Showing what's going on
                            break;
                        case "/":
                            this.result = Calculation.division(firstInput, secondInput).ToString();
                            resultBox.Text = this.result;
                            lblCalculation.Text = lblCalculation.Text + secondInput.ToString() + " = " + this.result; // Showing what's going on
                            break;
                        default:
                            Console.WriteLine("Default Case. Omm This time no need to do anyting!! :p");
                            break;
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Your Inputs not valid for Numerical calculation!" +
                        " First of all learn Mathmetics basics!!!!");
                }
                
            }
            
        }

        
    }
}
