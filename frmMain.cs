using HotelManagment.View;

namespace HotelManagment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        static frmMain _obj;
        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnMax.PerformClick();
            _obj = this;

            btnHome.PerformClick();
        }

        private void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new frmDashboard());
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AddControls(new frmBookingView());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AddControls(new frmUserView());
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            AddControls(new frmRoomTypeView());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            AddControls(new frmCustomerView());
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            AddControls(new frmRoomView());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            AddControls(new frmWebBookingView());
        }
    }
}
