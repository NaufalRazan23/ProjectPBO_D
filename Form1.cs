namespace ProjectPBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home_Page_User _HopePageUser = new Home_Page_User();
            _HopePageUser.FormClosed += (s, args) => this.Show();
            _HopePageUser.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Home_Page_Admin _HopePageAdmin = new Home_Page_Admin();
            _HopePageAdmin.FormClosed += (s, args) => this.Show();
            _HopePageAdmin.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}