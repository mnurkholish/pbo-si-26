public class Kasir {
    public void Bayar(int nominal) {
        Console.WriteLine("Dibayar tunai sebesar :" + nominal);
    }

    public void Bayar(int nominal1, int nominal2) {
        Console.WriteLine("Dibayar cash dengan pecahan " + nominal1 + "dan" + nominal2 + ", total :" +(nominal1+nominal2));
    }

    public void Bayar(string id) {
        Console.WriteLine("Dibayar cashless dengan id :" + id);
    }
}

public class Program {
    public static void Main(string[] args) {
        Kasir kasir = new Kasir();

        kasir.Bayar(20000);
        kasir.Bayar("23349301091");
        kasir.Bayar(10000, 5000);
    }
}