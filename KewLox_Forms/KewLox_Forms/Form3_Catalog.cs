﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KewLox_Forms
{
    public partial class Form3_Catalog : Form
    {
        public Form3_Catalog()
        {
            InitializeComponent();
        }

        private void Form3_Catalog_Load(object sender, EventArgs e)
        {

        }
        //To return to Main Menu
        private void Title_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form();
            frm.Show();
            Hide();
        }
        //To show the Basket of the Client
        private void Basket_Click(object sender, EventArgs e)
        {
            Basket_form frm = new Basket_form();
            frm.Show();
            Hide();
        }

        //To go backward
        private void Return_btn_Click(object sender, EventArgs e)
        {
            Welcome_form frm = new Welcome_form();
            frm.Show();
            Hide();
        }

        //To go forward
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            if (choice == true)
            {
                Form4_Catalog2 frm = new Form4_Catalog2();
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("You have to choose some closet to go furter");
            }
               
        }






        private void list(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        //To select one of the recommand closet
        bool choice = false;
        private void closet_multicolor_Click(object sender, EventArgs e)
        {
            choice = true;
        }

        private void closet_glass_Click(object sender, EventArgs e)
        {
            choice = true;
        }

        private void closet_orange_blue_Click(object sender, EventArgs e)
        {
            choice = true;
        }

        private void closet_white_Click(object sender, EventArgs e)
        {
            choice = true;
        }

        private void closet_wood_Click(object sender, EventArgs e)
        {
            choice = true;
        }

        private void tiny_closet_Click(object sender, EventArgs e)
        {
            choice = true;
        }
    }
}
