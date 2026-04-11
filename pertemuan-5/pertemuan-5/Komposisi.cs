class Mesin
{
    public string Tipe { get; set; }

    public Mesin(string Tipe)
    {
        this.Tipe = Tipe;
    }
}

class Mobil
{
    public string Nama { get; set; }

    public Mesin Mesin { get; set; } // komposisi


    public Mobil(string nama, string tipeMesin)
    {
        Nama = nama;
        Mesin = new Mesin(tipeMesin); // dibuat di dalam class
    }



    public void TampilkanInfo()
    {
        Console.WriteLine("Mobil: " + Nama);
        Console.WriteLine("Mesin: " + Mesin.Tipe);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Mobil sedan = new Mobil("Mahfud", "TDR 3000");

        sedan.TampilkanInfo();

        //sedan = null;

        Console.WriteLine(sedan.Mesin);
    }
}