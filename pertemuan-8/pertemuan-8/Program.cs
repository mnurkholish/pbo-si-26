using pertemuan_8.Database;

class Program
{
    public static void Main(string[] args)
    {
        // Inisialisasi Database
        Database db = new Database(Config.connString);

        try
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();
                Console.WriteLine("Koneksi Berhasil");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error, " + ex.Message);
        }
    }
}