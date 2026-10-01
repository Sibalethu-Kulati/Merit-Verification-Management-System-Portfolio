namespace Updated_Information_System_3
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            verifierRepresentative_Dashboard vDash = new verifierRepresentative_Dashboard();
            this.Hide();
            vDash.Show();
        }
    }
}
