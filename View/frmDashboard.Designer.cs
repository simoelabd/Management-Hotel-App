namespace HotelManagment.View
{
    partial class frmDashboard
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            totalReservation = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            totalChambres = new Label();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            totalClients = new Label();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            totalUsers = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(totalReservation);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(136, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 130);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.reservationdash;
            pictureBox1.Location = new Point(121, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // totalReservation
            // 
            totalReservation.AutoSize = true;
            totalReservation.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalReservation.ForeColor = Color.White;
            totalReservation.Location = new Point(13, 52);
            totalReservation.Name = "totalReservation";
            totalReservation.Size = new Size(36, 42);
            totalReservation.TabIndex = 2;
            totalReservation.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 1;
            label1.Text = "Reservation";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(totalChambres);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(401, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 130);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.beddash;
            pictureBox2.Location = new Point(121, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // totalChambres
            // 
            totalChambres.AutoSize = true;
            totalChambres.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalChambres.ForeColor = Color.White;
            totalChambres.Location = new Point(13, 52);
            totalChambres.Name = "totalChambres";
            totalChambres.Size = new Size(36, 42);
            totalChambres.TabIndex = 2;
            totalChambres.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 29);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 1;
            label4.Text = "Chambres";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(totalClients);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(667, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 130);
            panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.groupusers;
            pictureBox3.Location = new Point(121, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 94);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // totalClients
            // 
            totalClients.AutoSize = true;
            totalClients.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalClients.ForeColor = Color.White;
            totalClients.Location = new Point(13, 52);
            totalClients.Name = "totalClients";
            totalClients.Size = new Size(36, 42);
            totalClients.TabIndex = 2;
            totalClients.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 29);
            label6.Name = "label6";
            label6.Size = new Size(61, 23);
            label6.TabIndex = 1;
            label6.Text = "Clients";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(totalUsers);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(934, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 130);
            panel4.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(121, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(116, 94);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // totalUsers
            // 
            totalUsers.AutoSize = true;
            totalUsers.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalUsers.ForeColor = Color.White;
            totalUsers.Location = new Point(13, 52);
            totalUsers.Name = "totalUsers";
            totalUsers.Size = new Size(36, 42);
            totalUsers.TabIndex = 2;
            totalUsers.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 29);
            label8.Name = "label8";
            label8.Size = new Size(94, 23);
            label8.TabIndex = 1;
            label8.Text = "Utilisateurs";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 758);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDashboard";
            ShowIcon = false;
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label totalReservation;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label totalChambres;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label totalClients;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Label totalUsers;
        private Label label8;
    }
}