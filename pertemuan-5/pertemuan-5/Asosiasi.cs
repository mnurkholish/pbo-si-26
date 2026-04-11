class Ponsel
{
    public string baterai;
    public string cpu;

    public Ponsel(string baterai, string cpu)
    {
        this.baterai = baterai;
        this.cpu = cpu;
    }

    // ASSOCIATION
    public void IsiDaya(Charger charger)
    {
        Console.WriteLine(
            $"Mengisi daya dengan charger {charger.tipe} dengan kecepatan {charger.watt} watt"
        );
    }
}

class Charger
{
    public int watt;
    public string tipe;

    public Charger(int watt, string tipe)
    {
        this.watt = watt;
        this.tipe = tipe;
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Ponsel samsung = new Ponsel("lithium", "helio g88");
//        Charger ugreen = new Charger(90, "Fast Charging");

//        samsung.IsiDaya(ugreen);
//    }
//}