using System;
using System.Collections.Generic;
using System.Text;

namespace Luas
{
    public class PersegiPanjang
    {
        public int panjang;
        public int lebar;
        public int tinggi;

        public PersegiPanjang(int panjang, int lebar, int tinggi)
        {
            this.panjang = panjang;
            this.lebar = lebar;
            this.tinggi = tinggi;
        }

        public int Hitung()
        {
            return panjang * lebar * tinggi;
        }

        public string TulisLuas()
        {
            int luas = Hitung();

            return $"Jadi, luas persegi panjang adalah {luas} cm";
        }
    }
}

namespace Keliling
{
    public class PersegiPanjang
    {
        public int panjang;
        public int lebar;

        public PersegiPanjang(int Panjang, int Lebar)
        {
            panjang = Panjang;
            lebar = Lebar;
        }

        public int Hitung()
        {
            int keliling = 2 * (panjang * lebar);
            return keliling;
        }

        public string TulisKeliling()
        {
            int keliling = Hitung();

            string tulis = $"Jadi, keliling persegi panjang adalah {keliling} cm";

            return tulis;
        }

        public void PrintKeliling()
        {
            Console.WriteLine($"Kelilingnya = {Hitung()} cm");
        }
    }
}

 public class Kalkulator
{
    public static int angkaTetap = 0;   // contoh static attribute

    public static int Tambah(int angka1, int angka2) // contoh static method
    {
        return angka1 + angka2;
    }
}
