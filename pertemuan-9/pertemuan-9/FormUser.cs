using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pertemuan_9
{
    public partial class FormUser : Form
    {
        private DatabaseHelper dbHelper;
        public FormUser()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            int umur = int.Parse(tbUmur.Text);
            string asal = tbAsal.Text;

            User user = new User(0, nama, umur, asal);
            bool berhasil = dbHelper.AddUser(user);

            if (berhasil)
            {
                MessageBox.Show($"{nama} berhasil ditambahkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gagal menambahkan user", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
