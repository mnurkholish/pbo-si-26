namespace pertemuan_9 {
    public partial class Form1 : Form {
        private string username;
        private string password;

        public Form1() {
            InitializeComponent();
            username = "";
            password = "";
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            string usernameInput = TbUsername.Text;
            string passwordInput = TbPassword.Text;

            if (usernameInput == username && passwordInput == password)
            {
                FormDashboard dashboard = new FormDashboard(username);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login gagal", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
