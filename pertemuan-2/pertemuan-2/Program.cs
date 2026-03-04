using pertemuan_2.Contoh;   // contoh penggunaan using untuk memanggil namespace

class Kucing {      // Ini adalah Class
    public string Nama; // Ini attribute
    public string WarnaBulu;
    public string Ras;
    public int Umur;
    //public int PanjangEkor;

    public Kucing(string nama, string warnaBulu, string ras, int umur) {    // Ini adalah Constructor
        Nama = nama;
        WarnaBulu = warnaBulu;
        Ras = ras;
        Umur = umur;
    }
    public void Mengeong() {    // Ini adalah Method
        Console.WriteLine($"kucing bernama {Nama} bersuara 'Meong!'");
    }

    public string Berjalan() {
        return $"kucing berwarna {WarnaBulu} sedang berjalan...";
    }

    //public int BerapaUmur5bulanlagi() {
    //    return Umur + 5;
    //}
}

class Program
{
    static void Main(string[] args)
    {
        Kucing cing1 = new Kucing("Mochi", "Coklat", "Anggora", 12); // Ini adalah Objek dan cara membuatnya

        //cing1.Nama = "Kucing biasa";
        //cing1.Ras = "Anggora";
        //cing1.WarnaBulu = "Coklat";
        //cing1.Umur = 12;
        //cing1.PanjangEkor = 1;

        cing1.Mengeong();   // Contoh pemanggilan Method
        string cing1jalan = cing1.Berjalan();
        Console.WriteLine(cing1jalan);

        //int ayam = cing1.BerapaUmur5bulanlagi();

        // NAMESPACE

        Luas.PersegiPanjang bentuk1 = new Luas.PersegiPanjang(4, 2, 3); // namespace Luas
        Keliling.PersegiPanjang bentuk2 = new Keliling.PersegiPanjang(5, 3); // namespace Keliling

        int luasBentuk1 = bentuk1.Hitung();
        Console.WriteLine($"Luas bentuk1 = {luasBentuk1} cm");

        string kelilingBentuk2 = bentuk2.TulisKeliling();
        Console.WriteLine(kelilingBentuk2);

        Luas.PersegiPanjang bentuk3 = new Luas.PersegiPanjang(3, 4, 5);

        bentuk2.PrintKeliling();

        int penambahan = Kalkulator.Tambah(3, 4);   // contoh pemanggilan static method

        Console.WriteLine($"3 + 4 = {penambahan}");

        ContohPenggunaan.PrintKan(); // contoh pemanggilan namespace yang menggunakan using
    }
}