public class Kasir {
     // overloading : nama method sama, parameter input berbeda, isi program/rumusnya bisa berbeda
    public void Bayar(int nominal) { 
        Console.WriteLine("Dibayar tunai sebesar :" + nominal);
    }

    public void Bayar(int nominal1, int nominal2) {
        Console.WriteLine("Dibayar cash dengan pecahan " + nominal1 + "dan" + nominal2 + ", total :" +(nominal1+nominal2));
    }

    public void Bayar(string id) {
        Console.WriteLine("Dibayar cashless dengan id :" + id);
    }

    // overriding : nama sama, parameter input sama, isi program/rumusnya bisa berbeda
    // hanya berlaku untuk inheritance (parent-child)
    public virtual void Sapa(string pelanggan = "") // method di parent wajib pakai keyword virtual
    {
        Console.WriteLine("Selamat Datang, selamat berbelanja!");
    }
}

public class Indomaret : Kasir
{
    public override void Sapa(string pelanggan) // method di child wajib pakai keyword override
    {
        Console.WriteLine("Selamat Datang, " + pelanggan + "!");
    }
}

//public class Program {
//    public static void Main(string[] args) {
//        Kasir kasir = new Kasir();

//        //kasir.Bayar(20000);
//        //kasir.Bayar("23349301091");
//        //kasir.Bayar(10000, 5000);
//        kasir.Sapa();
//    }
//}
