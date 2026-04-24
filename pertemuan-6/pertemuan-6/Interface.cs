interface IHewan
{
    void Suara();
}

class Kucing : IHewan
{
    public void Suara()
    {
        Console.WriteLine("Meong!");
    }
}

//class Program
//{
//    static void Main()
//    {
//        Kucing k = new Kucing();
//        k.Suara();

//        //IHewan f = new IHewan();
//        //class parent gabisa dibikin object
//    }
//}