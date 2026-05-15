using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pertemuan_9 {
    public partial class FormDashboard : Form
    {
        private DatabaseHelper dbHelper;
        private string username;
        //private List<User> listUser;
        public FormDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            this.dbHelper = new DatabaseHelper();
            //this.listUser = generateData();
            LbJudul.Text += $"\nHello, {username}";
            LoadData();

            //dgv1.DataSource = listUser;
            this.FormClosed += (s, e) => Application.Exit();
        }

        public List<User> generateData()    // bikin data palsu/statis
        {
            List<User> listUser = new List<User>();
            for (int i = 0; i < 5; i++)
            {
                User user = new User(0, $"dany {i}", 30, "Jember");
                listUser.Add(user);
            }
            return listUser;
        }

        public void LoadData() // Ambil data dari databse dan ditampilkan pada aplikasi
        {
            List<User> listUser;
            try
            {
                listUser = dbHelper.GetAllUsers();
            }
            catch
            {
                listUser = new List<User>();
            }

            dgv1.DataSource = listUser;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormUser tambah= new FormUser();
            tambah.ShowDialog();

            LoadData();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            User user = (User)dgv1.Rows[e.RowIndex].DataBoundItem;

            string columnName = dgv1.Columns[e.ColumnIndex].Name;

            if (columnName == "edit")
            {
                FormUser edit = new FormUser(user);
                edit.ShowDialog();
            }
            else if (columnName == "hapus")
            {
                DialogResult result = MessageBox.Show("Hapus user " + user.nama + "?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbHelper.DeleteUser(user);
                        MessageBox.Show($"{user.nama} berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Gagal konek ke database", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            LoadData();
        }
    }
}
