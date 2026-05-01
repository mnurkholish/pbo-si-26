using System;
using System.Collections.Generic;

namespace pertemun_6
{
    abstract class Pembayaran
    {
        public string NamaMetode { get; set; }

        public Pembayaran(string nama){
            NamaMetode = nama;
        }

        //abstract
        public abstract void ProsesPembayaran(decimal jumlah);

        //method umum
        public void TampilkanInfo()
        {
            Console.WriteLine("Metode :"+ NamaMetode);
        }
    }

    class Transferbank : Pembayaran
    {
        public Transferbank() : base("Transfer Bank") { }
        public override void ProsesPembayaran(decimal jumlah)
        {
            Console.WriteLine("Pembayaran dengan metode transfer bank berhasil!");
            Console.WriteLine($"Sejumlah Rp{jumlah} berhasil ditransfer...");
        }
    }

    class Qris : Pembayaran
    {
        public Qris() : base("Qris") { }
        public override void ProsesPembayaran(decimal jumlah)
        {
            Console.WriteLine("Pembayaran dengan metode qris berhasil!");
            Console.WriteLine($"Sejumlah Rp{jumlah} berhasil dipotong dari saldo...");
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        List<Pembayaran> daftarpembayaran = new List<Pembayaran>()
    //        {
    //            new Transferbank(),
    //            new Qris()
    //        };

    //        foreach (var abc  in daftarpembayaran)
    //        {
    //            abc.TampilkanInfo();
    //            abc.ProsesPembayaran(200000);
    //            Console.WriteLine();
    //        }

    //    }
    //}
}