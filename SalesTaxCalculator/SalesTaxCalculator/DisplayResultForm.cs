using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCalculator
{
    public partial class DisplayResultForm : Form
    {
        public DisplayResultForm(decimal amount, decimal taxAmount)
        {
            InitializeComponent();

            decimal totalAmount = amount + taxAmount;

            lblResult.Text = $"Tax on R{amount} at {taxAmount / amount * 100:0}% is R{taxAmount:F2}.\nThe total is R{totalAmount:F2}.";
        }

        // okButton event handler
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form when the OK button is clicked
        }
    }
}
