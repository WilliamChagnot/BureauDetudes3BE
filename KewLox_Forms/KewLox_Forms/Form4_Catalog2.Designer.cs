﻿namespace KewLox_Forms
{
    partial class Form4_Catalog2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_Catalog2));
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Label();
            this.Basket = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Filter1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.accessoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glasWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Return_btn = new System.Windows.Forms.Button();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.closet_multicolor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Glass = new System.Windows.Forms.Button();
            this.Cup = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Pink = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closet_multicolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Your Closet";
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logo.Location = new System.Drawing.Point(243, -5);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(199, 59);
            this.Logo.TabIndex = 17;
            this.Logo.Text = "KewLox";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logo.Click += new System.EventHandler(this.Title_Click);
            // 
            // Basket
            // 
            this.Basket.Location = new System.Drawing.Point(847, 0);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(137, 51);
            this.Basket.TabIndex = 16;
            this.Basket.Text = "Basket";
            this.Basket.UseVisualStyleBackColor = true;
            this.Basket.Click += new System.EventHandler(this.Basket_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Filter1,
            this.accessoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(108, 550);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Filter1
            // 
            this.Filter1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripTextBox1,
            this.toolStripSeparator3,
            this.toolStripTextBox2});
            this.Filter1.Name = "Filter1";
            this.Filter1.Size = new System.Drawing.Size(101, 19);
            this.Filter1.Text = "Dimension Filter";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 23);
            this.toolStripSeparator1.Text = "Length";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Width";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox2.Text = "Number of Case required";
            // 
            // accessoriesToolStripMenuItem
            // 
            this.accessoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glasWindowToolStripMenuItem,
            this.cupToolStripMenuItem});
            this.accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            this.accessoriesToolStripMenuItem.Size = new System.Drawing.Size(101, 19);
            this.accessoriesToolStripMenuItem.Text = "Accessories";
            // 
            // glasWindowToolStripMenuItem
            // 
            this.glasWindowToolStripMenuItem.Name = "glasWindowToolStripMenuItem";
            this.glasWindowToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.glasWindowToolStripMenuItem.Text = "Glas Window";
            // 
            // cupToolStripMenuItem
            // 
            this.cupToolStripMenuItem.Name = "cupToolStripMenuItem";
            this.cupToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cupToolStripMenuItem.Text = "Cup";
            // 
            // Return_btn
            // 
            this.Return_btn.Location = new System.Drawing.Point(780, 494);
            this.Return_btn.Name = "Return_btn";
            this.Return_btn.Size = new System.Drawing.Size(100, 30);
            this.Return_btn.TabIndex = 24;
            this.Return_btn.Text = "Return";
            this.Return_btn.UseVisualStyleBackColor = true;
            this.Return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(886, 494);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(100, 30);
            this.Confirm_btn.TabIndex = 23;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // closet_multicolor
            // 
            this.closet_multicolor.Image = ((System.Drawing.Image)(resources.GetObject("closet_multicolor.Image")));
            this.closet_multicolor.Location = new System.Drawing.Point(243, 121);
            this.closet_multicolor.Name = "closet_multicolor";
            this.closet_multicolor.Size = new System.Drawing.Size(245, 379);
            this.closet_multicolor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closet_multicolor.TabIndex = 25;
            this.closet_multicolor.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Glass
            // 
            this.Glass.Location = new System.Drawing.Point(731, 290);
            this.Glass.Name = "Glass";
            this.Glass.Size = new System.Drawing.Size(48, 23);
            this.Glass.TabIndex = 27;
            this.Glass.Text = "Glass";
            this.Glass.UseVisualStyleBackColor = true;
            // 
            // Cup
            // 
            this.Cup.Location = new System.Drawing.Point(731, 319);
            this.Cup.Name = "Cup";
            this.Cup.Size = new System.Drawing.Size(48, 23);
            this.Cup.TabIndex = 28;
            this.Cup.Text = "Cup";
            this.Cup.UseVisualStyleBackColor = true;
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(825, 319);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(55, 23);
            this.Blue.TabIndex = 30;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(825, 290);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(55, 23);
            this.Red.TabIndex = 29;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // Orange
            // 
            this.Orange.Location = new System.Drawing.Point(883, 319);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(56, 23);
            this.Orange.TabIndex = 32;
            this.Orange.Text = "Orange";
            this.Orange.UseVisualStyleBackColor = true;
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(883, 290);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(56, 23);
            this.Green.TabIndex = 31;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            // 
            // Pink
            // 
            this.Pink.Location = new System.Drawing.Point(945, 319);
            this.Pink.Name = "Pink";
            this.Pink.Size = new System.Drawing.Size(48, 23);
            this.Pink.TabIndex = 34;
            this.Pink.Text = "Pink";
            this.Pink.UseVisualStyleBackColor = true;
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(945, 290);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(48, 23);
            this.Yellow.TabIndex = 33;
            this.Yellow.Text = "Yellow";
            this.Yellow.UseVisualStyleBackColor = true;
            // 
            // Material
            // 
            this.Material.AutoSize = true;
            this.Material.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.Material.Location = new System.Drawing.Point(728, 271);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(59, 16);
            this.Material.TabIndex = 35;
            this.Material.Text = "Material";
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.Color.Location = new System.Drawing.Point(822, 271);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(40, 16);
            this.Color.TabIndex = 36;
            this.Color.Text = "Color";
            // 
            // Form4_Catalog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.Pink);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Cup);
            this.Controls.Add(this.Glass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closet_multicolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Return_btn);
            this.Controls.Add(this.Confirm_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4_Catalog2";
            this.Text = "Form4_Catalog2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closet_multicolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.Button Basket;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Filter1;
        private System.Windows.Forms.ToolStripTextBox toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Button Return_btn;
        private System.Windows.Forms.Button Confirm_btn;
        private System.Windows.Forms.ToolStripMenuItem accessoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glasWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cupToolStripMenuItem;
        private System.Windows.Forms.PictureBox closet_multicolor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Glass;
        private System.Windows.Forms.Button Cup;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Pink;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Label Material;
        private System.Windows.Forms.Label Color;
    }
}