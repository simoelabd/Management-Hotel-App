namespace HotelManagment
{
    partial class SampleAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Gainsboro;
            guna2Panel1.Controls.Add(btnClose);
            guna2Panel1.Controls.Add(btnSave);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 349);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(714, 72);
            guna2Panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Animated = true;
            btnClose.AutoRoundedCorners = true;
            btnClose.BorderRadius = 19;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(156, 19);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(97, 41);
            btnClose.TabIndex = 1;
            btnClose.Text = "CLOSE";
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Animated = true;
            btnSave.AutoRoundedCorners = true;
            btnSave.BorderRadius = 19;
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.SeaGreen;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 19);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(97, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.Click += btnSave_Click;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Teal;
            guna2Panel2.Controls.Add(label1);
            guna2Panel2.CustomizableEdges = customizableEdges7;
            guna2Panel2.Dock = DockStyle.Top;
            guna2Panel2.ForeColor = Color.DimGray;
            guna2Panel2.Location = new Point(0, 0);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel2.Size = new Size(714, 70);
            guna2Panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 2;
            label1.Text = "Header";
            label1.Click += label1_Click;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = "House Hotel";
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            guna2MessageDialog1.Parent = this;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            guna2MessageDialog1.Text = null;
            // 
            // SampleAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 421);
            Controls.Add(guna2Panel2);
            Controls.Add(guna2Panel1);
            Name = "SampleAdd";
            Text = "SampleAdd";
            Load += SampleAdd_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        public Label label1;
    }
}