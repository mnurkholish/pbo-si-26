class Kucing {
    public string Nama;
    public string WarnaBulu;
    public string Ras;
    public int Umur;
    //public int PanjangEkor;

    public Kucing(string nama, string warnaBulu, string ras, int umur) {
        Nama = nama;
        WarnaBulu = warnaBulu;
        Ras = ras;
        Umur = umur;
    }
    public void Mengeong() {
        Console.WriteLine($"kucing bernama {Nama} bersuara 'Meong!'");
    }

    public string Berjalan() {
        return $"kucing berwarna {WarnaBulu} sedang berjalan...";
    }

    //public int BerapaUmur5bulanlagi() {
    //    return Umur + 5;
    //}
}

class Program {
    static void Main(string[] args) {
        Kucing cing1 = new Kucing("Mochi", "Coklat", "Anggora", 12);

        //cing1.Nama = "Kucing biasa";
        //cing1.Ras = "Anggora";
        //cing1.WarnaBulu = "Coklat";
        //cing1.Umur = 12;
        //cing1.PanjangEkor = 1;

        cing1.Mengeong();
        string cing1jalan = cing1.Berjalan();
        Console.WriteLine(cing1jalan);

        //int ayam = cing1.BerapaUmur5bulanlagi();
    }
}