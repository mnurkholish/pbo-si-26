class RekeningBank
{
    public string nama; // bisa langsung diakses
    private int saldo; // tidak bisa langsung diakses, harus pakai method (getter/setter)
     
    // autoimplemented property/attribute
    // encap yang lebih satset tanpa harus ngeprivate
    public string Rekening { get; set; }

     //getter (mengambil nilai)
    public int getSaldo()
    {
        return saldo;
    }

    // setter (memasukkan/mengubah nilai)
    public void setSaldo(int value)
    {
        if (value < 0)
        {
            Console.WriteLine("saldo harus lebih dari 0");
        }
        else
        {
            saldo = value;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        RekeningBank bri = new RekeningBank();
        bri.nama = "Kamelia";
        //bri.saldo = 10000;
        bri.setSaldo(-10000000); //nilai tidak bisa dimasukkan karena di setter ada validasi harus bilangan bulat positif
        bri.Rekening = "abc123";

        string rekening = bri.Rekening;

        int saldo = bri.getSaldo();

        Console.WriteLine($"rekening {bri.nama} memiliki saldo Rp{saldo}");
    }
}
