using pertemuan_8.Controllers;
using pertemuan_8.Database;

class Program
{
    public static void Main(string[] args)
    {
        // Inisialisasi Database
        Database db = new Database(Config.connString);

        try
        {
            //using (var conn = db.GetConnection())
            //{
            //    conn.Open();
            //    Console.WriteLine("Koneksi Berhasil");
            //}

            C_Mahasiswa mhs = new C_Mahasiswa(db);

            //Create
            mhs.TambahMahasiswa("Kholis", "242410101060", "Sistem Informasi", 3.8m);

            //Read
            List<string> result = mhs.GetAllMahasiswa();
            foreach (var item in result) {
                Console.WriteLine(item);
            }

            //Update
            mhs.UpdateMahasiswa(1, "Teknologi Informasi", 3.8m);

            //Delete
            mhs.HapusMahasiswa(2);
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error, " + ex.Message);
        }
    }
}