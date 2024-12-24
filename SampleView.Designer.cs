namespace HotelManagment
{
    partial class SampleView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.AllowDrop = true;
            guna2Panel1.Controls.Add(btnAdd);
            guna2Panel1.Controls.Add(txtSearch);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1267, 189);
            guna2Panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.AllowDrop = true;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.Teal;
            btnAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(43, 121);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(50, 50);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+";
            btnAdd.TextOffset = new Point(1, -5);
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.AllowDrop = true;
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            txtSearch.CustomizableEdges = customizableEdges2;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.ForeColor = Color.FromArgb(64, 64, 64);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(993, 118);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtSearch.Size = new Size(262, 53);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(993, 94);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(43, 78);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 3;
            label1.Text = "Header";
            label1.Click += label1_Click;
            // 
            // guna2MessageDialog1
            // 
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            guna2MessageDialog1.Caption = "House Hotel";
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            guna2MessageDialog1.Parent = null;
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            guna2MessageDialog1.Text = null;
            // 
            // SampleView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 737);
            Controls.Add(guna2Panel1);
            Name = "SampleView";
            Text = "SampleView";
            Load += SimpleView_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        public Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Label label1;
        public Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        public Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}