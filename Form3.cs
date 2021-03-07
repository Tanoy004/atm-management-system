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
    public partial class Withdraw : Form
    {
        double amount;
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "Withdraw", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Form1 openForm = new Form1();
                openForm.Show();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(txtAmount.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("Withdraw System" + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Enter amount    " + "\t" + txtAmount.Text + "\n");
            rtfReceipt.AppendText("----------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("-------------------Thank You----------------------------" + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Receipt.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("Withdraw System" + "\n----------------------------------------------------------\nEnter amount    " 
                + "\t" + txtAmount.Text + "\n----------------------------------------------------------" + "\n-------------------Thank You----------------------------" + "\n");

            doc.Add(paragraph);
            doc.Close();
        }
    }
}
