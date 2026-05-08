using System;
using System.Collections.Generic;
using System.Text;

namespace pertemuan_9
{
    public class User
    {
        public int id { get; set; }
        public string nama { get; set; }
        public int umur { get; set; }
        public string asal { get; set; }

        public User(int id, string nama, int umur, string asal)
        {
            this.id = id;
            this.nama = nama;
            this.umur = umur;
            this.asal = asal;
        }
    }
}