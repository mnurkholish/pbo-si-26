abstract class Kendaraan {
    public abstract void Jalan();

    public void TampilkanInfo()
    {
        Console.WriteLine("Kendaraan ini berjalan");
    }
}

class Mobil : Kendaraan
{
    public override void Jalan()
    {
        Console.WriteLine("Mobil ini berjalan dengan kecepatan 40km/jam");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Mobil m = new Mobil();
//        m.Jalan();
//        m.TampilkanInfo();

//        //Kendaraan k = new Kendaraan(); 
//        // Abstract class tidak bisa membuat objek, harus dari child nya
//    }
//}