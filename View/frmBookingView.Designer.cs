namespace HotelManagment.View
{
    partial class frmBookingView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvSr = new DataGridViewTextBoxColumn();
            dgvID = new DataGridViewTextBoxColumn();
            dgvcusID = new DataGridViewTextBoxColumn();
            dgvCustomer = new DataGridViewTextBoxColumn();
            dgvRoomID = new DataGridViewTextBoxColumn();
            dgvRoom = new DataGridViewTextBoxColumn();
            dgvIn = new DataGridViewTextBoxColumn();
            dgvOut = new DataGridViewTextBoxColumn();
            dgvDay = new DataGridViewTextBoxColumn();
            dgvPrix = new DataGridViewTextBoxColumn();
            dgvAmount = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            dgvRece = new DataGridViewTextBoxColumn();
            dgvedite = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            dgvPrint = new DataGridViewImageColumn();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnExcel = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(btnExcel);
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Panel1.Size = new Size(1143, 189);
            guna2Panel1.Controls.SetChildIndex(label1, 0);
            guna2Panel1.Controls.SetChildIndex(label2, 0);
            guna2Panel1.Controls.SetChildIndex(txtSearch, 0);
            guna2Panel1.Controls.SetChildIndex(btnAdd, 0);
            guna2Panel1.Controls.SetChildIndex(btnExcel, 0);
            // 
            // label1
            // 
            label1.Size = new Size(174, 30);
            label1.Text = "Reservation Liste";
            // 
            // btnAdd
            // 
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            // 
            // label2
            // 
            label2.Location = new Point(715, 94);
            // 
            // txtSearch
            // 
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(715, 118);
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // guna2DataGridView1
            // 
            guna2DataGridView1.AllowUserToAddRows = false;
            guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Turquoise;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvSr, dgvID, dgvcusID, dgvCustomer, dgvRoomID, dgvRoom, dgvIn, dgvOut, dgvDay, dgvPrix, dgvAmount, dgvStatus, dgvRece, dgvedite, dgvDel, dgvPrint });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.Black;
            guna2DataGridView1.Location = new Point(12, 207);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Teal;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 47;
            guna2DataGridView1.RowTemplate.Height = 30;
            guna2DataGridView1.Size = new Size(1119, 483);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.Black;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = true;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            // 
            // dgvSr
            // 
            dgvSr.FillWeight = 80.67376F;
            dgvSr.HeaderText = "Sr#";
            dgvSr.MinimumWidth = 6;
            dgvSr.Name = "dgvSr";
            dgvSr.ReadOnly = true;
            // 
            // dgvID
            // 
            dgvID.HeaderText = "id";
            dgvID.MinimumWidth = 6;
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            dgvID.Visible = false;
            // 
            // dgvcusID
            // 
            dgvcusID.HeaderText = "cusID";
            dgvcusID.MinimumWidth = 6;
            dgvcusID.Name = "dgvcusID";
            dgvcusID.ReadOnly = true;
            dgvcusID.Visible = false;
            // 
            // dgvCustomer
            // 
            dgvCustomer.HeaderText = "Customer";
            dgvCustomer.MinimumWidth = 6;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            // 
            // dgvRoomID
            // 
            dgvRoomID.HeaderText = "roomID";
            dgvRoomID.MinimumWidth = 6;
            dgvRoomID.Name = "dgvRoomID";
            dgvRoomID.ReadOnly = true;
            dgvRoomID.Visible = false;
            // 
            // dgvRoom
            // 
            dgvRoom.HeaderText = "Room";
            dgvRoom.MinimumWidth = 6;
            dgvRoom.Name = "dgvRoom";
            dgvRoom.ReadOnly = true;
            // 
            // dgvIn
            // 
            dgvIn.HeaderText = "Chech in";
            dgvIn.MinimumWidth = 6;
            dgvIn.Name = "dgvIn";
            dgvIn.ReadOnly = true;
            // 
            // dgvOut
            // 
            dgvOut.HeaderText = "Check Out";
            dgvOut.MinimumWidth = 6;
            dgvOut.Name = "dgvOut";
            dgvOut.ReadOnly = true;
            // 
            // dgvDay
            // 
            dgvDay.HeaderText = "Days";
            dgvDay.MinimumWidth = 6;
            dgvDay.Name = "dgvDay";
            dgvDay.ReadOnly = true;
            // 
            // dgvPrix
            // 
            dgvPrix.HeaderText = "Prix";
            dgvPrix.MinimumWidth = 6;
            dgvPrix.Name = "dgvPrix";
            dgvPrix.ReadOnly = true;
            // 
            // dgvAmount
            // 
            dgvAmount.HeaderText = "Amount";
            dgvAmount.MinimumWidth = 6;
            dgvAmount.Name = "dgvAmount";
            dgvAmount.ReadOnly = true;
            // 
            // dgvStatus
            // 
            dgvStatus.HeaderText = "Status";
            dgvStatus.MinimumWidth = 6;
            dgvStatus.Name = "dgvStatus";
            dgvStatus.ReadOnly = true;
            // 
            // dgvRece
            // 
            dgvRece.HeaderText = "Received";
            dgvRece.MinimumWidth = 6;
            dgvRece.Name = "dgvRece";
            dgvRece.ReadOnly = true;
            // 
            // dgvedite
            // 
            dgvedite.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvedite.FillWeight = 50F;
            dgvedite.HeaderText = "";
            dgvedite.Image = Properties.Resources.edite;
            dgvedite.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvedite.MinimumWidth = 50;
            dgvedite.Name = "dgvedite";
            dgvedite.ReadOnly = true;
            dgvedite.Width = 50;
            // 
            // dgvDel
            // 
            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDel.FillWeight = 50F;
            dgvDel.HeaderText = "";
            dgvDel.Image = Properties.Resources.delete;
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 50;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Width = 50;
            // 
            // dgvPrint
            // 
            dgvPrint.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvPrint.FillWeight = 50F;
            dgvPrint.HeaderText = "";
            dgvPrint.Image = Properties.Resources.printer;
            dgvPrint.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvPrint.MinimumWidth = 50;
            dgvPrint.Name = "dgvPrint";
            dgvPrint.ReadOnly = true;
            dgvPrint.Width = 50;
            // 
            // btnExcel
            // 
            btnExcel.CustomizableEdges = customizableEdges1;
            btnExcel.DisabledState.BorderColor = Color.DarkGray;
            btnExcel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExcel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExcel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExcel.FillColor = Color.White;
            btnExcel.Font = new Font("Segoe UI", 9F);
            btnExcel.ForeColor = Color.Black;
            btnExcel.Image = Properties.Resources.excel;
            btnExcel.Location = new Point(983, 118);
            btnExcel.Name = "btnExcel";
            btnExcel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExcel.Size = new Size(116, 50);
            btnExcel.TabIndex = 7;
            btnExcel.Text = "Excel Export";
            btnExcel.Click += btnExcel_Click;
            // 
            // frmBookingView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 702);
            Controls.Add(guna2DataGridView1);
            Name = "frmBookingView";
            Text = "frmBookingView";
            Load += frmBookingView_Load;
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2DataGridView1, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn dgvSr;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvcusID;
        private DataGridViewTextBoxColumn dgvCustomer;
        private DataGridViewTextBoxColumn dgvRoomID;
        private DataGridViewTextBoxColumn dgvRoom;
        private DataGridViewTextBoxColumn dgvIn;
        private DataGridViewTextBoxColumn dgvOut;
        private DataGridViewTextBoxColumn dgvDay;
        private DataGridViewTextBoxColumn dgvPrix;
        private DataGridViewTextBoxColumn dgvAmount;
        private DataGridViewTextBoxColumn dgvStatus;
        private DataGridViewTextBoxColumn dgvRece;
        private DataGridViewImageColumn dgvedite;
        private DataGridViewImageColumn dgvDel;
        private DataGridViewImageColumn dgvPrint;
        private Guna.UI2.WinForms.Guna2Button btnExcel;
    }
}