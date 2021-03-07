﻿using System;
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblPin.Text = lblPin.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
            lblPin1.Text = "";
            txtUser.Text = "";

            btnLoan.Enabled = false;
            btnWithdraw.Enabled = false;
            btnDeposite.Enabled = false;
            btnBalance.Enabled = false;
         
        }

       

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            Deposite openDeposite = new Deposite();
            openDeposite.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw openWithdraw = new Withdraw();
            openWithdraw.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to exit", "ATM System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            btnLoan.Enabled = false;
            btnWithdraw.Enabled = false;
            btnDeposite.Enabled = false;
            btnBalance.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String pin1 = String.Format(lblPin.Text);
            String pin2 = String.Format(txtUser.Text);

            if (pin1=="1234" && pin2=="misbah")
            {

                btnLoan.Enabled = true;
                btnWithdraw.Enabled = true;
                btnDeposite.Enabled = true;
                btnBalance.Enabled = true;
                lblPin.Text = "";
                txtUser.Text = "";
            }
            else if (pin1 == "2345" && pin2=="razib")
            {

                btnLoan.Enabled = true;
                btnWithdraw.Enabled = true;
                btnDeposite.Enabled = true;
                btnBalance.Enabled = true;
                lblPin.Text = "";
                txtUser.Text = "";
            }
            else if (pin1 == "3456" && pin2=="tanoy")
            {
               
                btnLoan.Enabled = true;
                btnWithdraw.Enabled = true;
                btnDeposite.Enabled = true;
                btnBalance.Enabled = true;
                lblPin.Text = "";
                txtUser.Text = "";
            }
            else if (pin1 == "4567" && pin2=="rahabul")
            {
                
                btnLoan.Enabled = true;
                btnWithdraw.Enabled = true;
                btnDeposite.Enabled = true;
                btnBalance.Enabled = true;
                lblPin.Text = "";
                txtUser.Text = "";
            }
            else if (pin1 == "1111" && pin2=="admin")
            {
                
                
                lblPin.Text = "";
                txtUser.Text = "";

                Admin openAdmin = new Admin();
                openAdmin.Show();
            }
            else
            {
                lblPin1.Text = "Invalid Information";
               
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Loan openLoan = new Loan();
            openLoan.Show();
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }
    }
}
