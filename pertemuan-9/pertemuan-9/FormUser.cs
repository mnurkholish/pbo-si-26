using Microsoft.VisualBasic.ApplicationServices;
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
        User user;
        public FormUser(User user = null) // default null
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            this.user = user;

            if (this.user != null) // mode EDIT, isi field dengan data lama
            {
                tbNama.Text = user.nama;
                tbUmur.Text = user.umur.ToString();
                tbAsal.Text = user.asal;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (user == null) // TAMBAH
                {
                    string nama = tbNama.Text;
                    int umur = int.Parse(tbUmur.Text);
                    string asal = tbAsal.Text;

                    User user_baru = new User(0, nama, umur, asal);

                    bool berhasil = dbHelper.AddUser(user_baru);

                    if (berhasil)
                    {
                        MessageBox.Show($"{nama} berhasil ditambahkan", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan user", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // EDIT
                {
                    user.nama = tbNama.Text;
                    user.umur = int.Parse(tbUmur.Text);
                    user.asal = tbAsal.Text;
                    bool berhasil = dbHelper.UpdateUser(user);
                    if (berhasil)
                    {
                        MessageBox.Show($"{user.nama} berhasil diupdate", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan user", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Gagal konek ke database", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
