namespace pertemuan_9 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
