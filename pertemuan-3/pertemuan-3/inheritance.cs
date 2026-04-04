using System;
using pertemuan_3;

namespace pertemuan3 {
    //Parent class
    public class Manusia {
        public string nama;

        public Manusia() { }
        public Manusia(string nama) {
            this.nama = nama;
        }

        public void Perkenalan() {
            Console.WriteLine($"Perkenalkan nama saya {nama}");
        }
    }
    //Child class 1 (tanpa constructor)
    public class Karyawan : Manusia {
        public string pekerjaan;

        public void Infokaryawan() {
            Console.WriteLine($"Saya bekerja sebagai {pekerjaan}");
        }
    }

    //Child class 2 (pakai constructor)
    public class Siswa : Manusia {
        public string namaSekolah;

        public Siswa(string nama, string namaSekolah) : base(nama) { //kalo pake konstruktor wajib ada base, agar variabel dari
                                                                     //parentnya dapat menyimpan nilai dari konstruktor milik child
            this.namaSekolah = namaSekolah;
        }

        public void InfoSiswa() {
            Console.WriteLine($"Saya bersekolah di {namaSekolah}");
        }
    }

    class Program {
        static void Main(string[] args) {
            //Objek dari child pertama
            Karyawan k = new Karyawan();
            k.nama = "Andika";
            k.pekerjaan = "Programmer";

            k.Perkenalan();
            k.Infokaryawan();

            //Space
            Console.WriteLine();

            //Objek dari child kedua
            Siswa siswa1 = new Siswa("Budi", "SMA 1 Jember");
            siswa1.Perkenalan();
            siswa1.InfoSiswa();
        }
    }
}