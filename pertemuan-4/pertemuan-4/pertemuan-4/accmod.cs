class RekeningBank
{
    public string nama;
    private int saldo;
    // autoimplemented property/attribute
    public string Rekening { get; set; }

    public int getSaldo()
    {
        return saldo;
    }

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
        bri.setSaldo(-10000000);
        bri.Rekening = "abc123";

        string rekening = bri.Rekening;

        int saldo = bri.getSaldo();

        Console.WriteLine($"rekening {bri.nama} memiliki saldo Rp{saldo}");
    }
}
