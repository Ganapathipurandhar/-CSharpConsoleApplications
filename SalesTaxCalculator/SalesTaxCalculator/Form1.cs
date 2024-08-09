using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SalesTaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validation if the user does not enter anything and clicks submit
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                // this is for the pop-up message box 
                MessageBox.Show("Please enter an amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this is to append the text (exception) to the ExceptionFile.txt
                File.AppendAllText("ExceptionFile.txt", $"Empty input exception occurred. Date: {DateTime.Now:yyyy/MM/dd} Time: {DateTime.Now:HH:mm:ss}{Environment.NewLine}{Environment.NewLine}");
                return;
            }

            // Validation if the amount entered is less than 0
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount < 0)
            {
                // this is for the pop-up message box
                MessageBox.Show("Invalid input! Please enter a valid non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this is to append the text (exception) to the ExceptionFile.txt 
                File.AppendAllText("ExceptionFile.txt", $"Invalid input exception occurred. Date: {DateTime.Now:yyyy/MM/dd} Time: {DateTime.Now:HH:mm:ss}{Environment.NewLine}{Environment.NewLine}");
                return;
            }

            try
            {
                // create the variables for the Tax calculation
                decimal taxRate = numTax.Value / 100;
                decimal taxAmount = amount * taxRate;
                decimal totalAmount = amount + taxAmount;

                // print the result
                string result = $"Amount: R{amount}, Tax: {numTax.Value}%, Total: R{totalAmount}, Date: {DateTime.Now:yyyy/MM/dd} Time: {DateTime.Now:HH:mm:ss}";
                // this is to append the text (Tax Calculation) to the TaxCalculation.txt 
                File.AppendAllText("TaxCalculation.txt", result + Environment.NewLine + Environment.NewLine);

                // open a new windows application
                DisplayResultForm resultForm = new DisplayResultForm(amount, taxAmount);
                // to display the text (Tax Calculation)
                resultForm.ShowDialog();
            }

            // catch Format exception
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input! Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("ExceptionFile.txt", $"Invalid input exception occurred. Date: {DateTime.Now:yyyy/MM/dd} Time: {DateTime.Now:HH:mm:ss}{Environment.NewLine}{ex.Message}{Environment.NewLine}{Environment.NewLine}");
            }

            // catch Input Output exception (for the two files)
            catch (IOException ex)
            {
                MessageBox.Show("An error occurred while accessing the file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("ExceptionFile.txt", $"File access exception occurred. Date: {DateTime.Now:yyyy/MM/dd} Time: {DateTime.Now:HH:mm:ss}{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
            }

            // catch unauthorized access exception (for the two files)
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("You don't have permission to access the file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("ExceptionFile.txt", $"File access exception occurred. Date: {DateTime.Now:yyyy/MM/dd} Time: {DateTime.Now:HH:mm:ss}{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
            }

            // catch general exception
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                File.AppendAllText("ExceptionFile.txt", $"Exception occurred. Date: {DateTime.Now:yyyy/MM/dd} Time: {DateTime.Now:HH:mm:ss}{Environment.NewLine}{ex.ToString()}{Environment.NewLine}{Environment.NewLine}");
            }
        }

        // Event handler for the Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear(); // clear the amount text box when the Clear button is clicked
        }

        // Event handler for the Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit the application when the Exit button is clicked
        }
    }
}
