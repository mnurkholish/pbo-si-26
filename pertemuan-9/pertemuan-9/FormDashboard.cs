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
        private string username;
        private List<User> listUser;
        public FormDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            this.listUser = generateData();
            LbJudul.Text += $"\nHello, {username}";

            dgv1.DataSource = listUser;
        }

        public List<User> generateData()    // bikin data palsu/statis
        {
            List<User> listUser = new List<User>();
            for (int i = 0; i < 5; i++)
            {
                User user = new User($"dany {i}", 30, "Jember");
                listUser.Add(user);
            }
            return listUser;
        }
    }
}
