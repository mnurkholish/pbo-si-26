using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using pertemuan_8.Database;

namespace pertemuan_8.Controllers {
    public class C_Mahasiswa {
        private Database.Database db;

        public C_Mahasiswa(Database.Database db) {
            this.db = db;
        }

        //CREATE
        public void TambahMahasiswa(string nama, string nim, string jurusan, decimal ipk) {
            string query = @"INSERT INTO mahasiswa (nama, nim, jurusan, ipk) VALUES (@nama, @nim, @jurusan, @ipk)";

            using (var conn = db.GetConnection()) {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@nim", nim);
                    cmd.Parameters.AddWithValue("@jurusan", jurusan);
                    cmd.Parameters.AddWithValue("@ipk", ipk);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} data berhasil ditambahkan");
                }
            }
        }

        //READ
        public List<string> GetAllMahasiswa() {
            var hasil = new List<string>();

            string query = "SELECT id, nama, nim, jurusan, ipk FROM mahasiswa";

            using (var conn = db.GetConnection()) {
                conn.Open();

                using (var cmd = new NpgsqlCommand(query, conn)) {
                    using (var reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            int id = reader.GetInt32(0);
                            string nama = reader.GetString(1);
                            string nim = reader.GetString(2);
                            string jurusan = reader.GetString(3);
                            decimal ipk = reader.GetDecimal(4);

                            hasil.Add($"{id}. {nama} - {nim} - {jurusan} - {ipk}");
                        }
                    }
                }
            }
            return hasil;
        }

        //UPDATE
        public void UpdateMahasiswa(int id, string jurusanBaru, decimal ipkBaru) {
            string sql = @"UPDATE mahasiswa 
            SET jurusan = @jurusan, ipk = @ipk 
            WHERE id = @id";

            using (var conn = db.GetConnection()) {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@jurusan", jurusanBaru);
                    cmd.Parameters.AddWithValue("@ipk", ipkBaru);

                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                        Console.WriteLine("Data berhasil diupdate!");
                    else
                        Console.WriteLine("ID tidak ditemukan.");
                }
            }
        }

        //DELETE
        public void HapusMahasiswa(int id) {
            string sql = "DELETE FROM mahasiswa WHERE id = @id";

            using (var conn = db.GetConnection()) {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                        Console.WriteLine($"Mahasiswa ID {id} dihapus.");
                    else
                        Console.WriteLine("Data tidak ditemukan.");
                }
            }
        }

    }
}
