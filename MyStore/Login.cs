﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyStore
{
    public partial class Login : Form
    {
        Code.Query_DB qd=new Code.Query_DB();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qd.EMAIL = Email.Text;
            qd.PASSWORD = Password.Text;
            if (qd.VerifyUser(qd))
            {
                qd = qd.GetUserDetails(qd);
                DeshBoard ad = new DeshBoard(qd);
                
                ad.Show();
                Email.Text = "";
                Password.Text = "";
                Wrong.Text = "";

            }
            else
                {
                    Wrong.Text = "** Wrong Username OR Password **";

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Email.Text = "";
            Password.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Email.Text = "nitin@gmail.com";
            Password.Text = "12345";
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
