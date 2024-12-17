namespace HotelManagment.Model
{
    partial class frmTypeAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtDesc = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel2
            // 
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel2.Size = new Size(800, 70);
            guna2Panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(265, 21);
            label1.Size = new Size(263, 30);
            label1.TabIndex = 0;
            label1.Text = "Ajouter Type de Chambre";
            // 
            // txtDesc
            // 
            txtDesc.AllowDrop = true;
            txtDesc.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            txtDesc.CustomizableEdges = customizableEdges7;
            txtDesc.DefaultText = "";
            txtDesc.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDesc.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDesc.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDesc.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDesc.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDesc.Font = new Font("Segoe UI", 9F);
            txtDesc.ForeColor = Color.FromArgb(64, 64, 64);
            txtDesc.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDesc.Location = new Point(344, 189);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Name = "txtDesc";
            txtDesc.PasswordChar = '\0';
            txtDesc.PlaceholderText = "";
            txtDesc.SelectedText = "";
            txtDesc.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtDesc.Size = new Size(444, 53);
            txtDesc.TabIndex = 1;
            // 
            // label3
            // 
            label3.AllowDrop = true;
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(344, 156);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // txtName
            // 
            txtName.AllowDrop = true;
            txtName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            txtName.CustomizableEdges = customizableEdges9;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.ForeColor = Color.FromArgb(64, 64, 64);
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(31, 189);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtName.Size = new Size(262, 53);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(31, 156);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 8;
            label2.Text = "Nom";
            // 
            // frmTypeAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(txtDesc);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "frmTypeAdd";
            Text = "frmTypeAdd";
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(txtDesc, 0);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtDesc;
        public Label label3;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Label label2;
    }
}