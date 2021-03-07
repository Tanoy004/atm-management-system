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
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace CS_ATM
{
    public partial class Loan : Form
    {
        double monthlyInterestRate, interestRate, loanAmount, monthlyPayment, totalPayment;
        int numberOfYears;
        String iMonthlyPayment, iTotalPayment;

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("Loan Management Systems Calculator" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Enter amount of Loan" + "\t" + txtLoanAmount.Text + "\n");
            rtfReceipt.AppendText("Enter Number of Year" + "\t" + txtNumberOfYear.Text + "\n");
            rtfReceipt.AppendText("Enter Interest Rate" + "\t" + txtInterestRate.Text + "\n");
            rtfReceipt.AppendText("Monthly Payment" + "\t" + "\t" + txtMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Total Payment" + "\t" + "\t" + "\t" + txtTotalPayment.Text + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("-------------------Thank You----------------------------" + "\n");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtLoanAmount.Clear();
            txtNumberOfYear.Clear();
            txtInterestRate.Clear();
            txtMonthlyPayment.Clear();
            txtTotalPayment.Clear();
            rtfReceipt.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Receipt.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Loan Management Systems Calculator" + "\n----------------------------------------------------------" +
                "\nEnter amount of Loan   " + txtLoanAmount.Text + "\nEnter Number of Year   " + txtNumberOfYear.Text +
                "\nEnter Interest Rate       " + txtInterestRate.Text + "\nMonthly Payment         " + txtMonthlyPayment.Text +
                "\nTotal Payment             " + txtTotalPayment.Text + "\n----------------------------------------------------------" +
                "\n-------------------Thank You----------------------------" + "\n");
            doc.Add(paragraph);
            doc.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Form1 openForm = new Form1();
                openForm.Show();
            }
        }

        
        public Loan()
        {
            InitializeComponent();
        }

        private void btnLoanSystem_Click(object sender, EventArgs e)
        {
            interestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = interestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYear.Text);
            loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            monthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));
            //................................................................................................................
            iMonthlyPayment = Convert.ToString(monthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", monthlyPayment);
            txtMonthlyPayment.Text = (iMonthlyPayment);
            //...............................................................................................................
            totalPayment = monthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", totalPayment);
            txtTotalPayment.Text = (iTotalPayment);

            txtLoanAmount.Text = String.Format("{0:C}", loanAmount);
        }
    }
}
