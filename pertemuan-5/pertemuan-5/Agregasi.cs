using System;
using System.Collections.Generic;

public class Pemain
{
    public string nama { get; set; }    //autoimplemented property
    public string nomorpunggung { get; set; }

    public Pemain(string nama, string nomorpunggung)
    {
        this.nama = nama;
        this.nomorpunggung = nomorpunggung;
    }
}

public class Tim
{
    public string namatim { get; set; }
    public List<Pemain> pemainn { get; set; }

    public Tim(string namatim, List<Pemain> pemainn)
    {
        this.namatim = namatim;
        this.pemainn = pemainn;
    }

    public void Tampilkaninfo()
    {
        int no = 1;
        Console.WriteLine(namatim);
        foreach (var pemain in pemainn)
        {
            Console.WriteLine($"{no}. {pemain.nama} dengan nomor punggung {pemain.nomorpunggung}");
            no++;
        }
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Pemain p1 = new Pemain("kolis", "12");
//        Pemain p2 = new Pemain("aura", "45");
//        Pemain p3 = new Pemain("mahfud", "31");

//        List<Pemain> listpemain = new List<Pemain> { p1, p2, p3 };

//        Tim timm = new Tim("PBO", listpemain);
//        timm.Tampilkaninfo();
//    }
//}