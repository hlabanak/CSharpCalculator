using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.Core.Repositories;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        //Fields
        private double resultValue = 0;
        private string operationPerformed = string.Empty;
        private bool isOperationPerformed = false;
        private const string DIVIDE_BY_ZERO = "Cannot divide by Zero.";
        private readonly ICalculator _calculator;
        // private Calculate calculate = new Calculate();

        public frmCalculator(ICalculator calculator)
        {
            _calculator = calculator;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This event fires the button numbers clicked to display the calculated values and validates nessesary calculations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (isOperationPerformed) || (txtResult.Text == DIVIDE_BY_ZERO))
            {
                txtResult.Clear();
            }
            
            Button button = (Button)sender;

            isOperationPerformed = false;
            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text = txtResult.Text + button.Text;
                }
            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }     
        }

        /// <summary>
        /// This event fires the mathematical operator for the button functions and display the results on the label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;

            try
            {
                resultValue = Double.Parse(txtResult.Text);
            }
            catch (FormatException)
            {

                txtResult.Text = string.Empty;
            }
            
            lblCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }
        /// <summary>
        /// Clears the entries entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        /// <summary>
        /// Clears the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }

        /// <summary>
        /// Perfoms the mathematical operation function the by parsing resultValue as first value and result as the second value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text != "0")
                {
                    txtResult.Text = _calculator.Calculate(resultValue, txtResult.Text, operationPerformed);
                }
                else
                {
                    txtResult.Text = DIVIDE_BY_ZERO;
                }

            }
            catch (Exception)
            {
                txtResult.Text = DIVIDE_BY_ZERO;
            }        
        }
    }
}
