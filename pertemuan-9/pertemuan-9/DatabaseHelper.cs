using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace pertemuan_9
{
    public class DatabaseHelper
    {
        private string connString = "Host=localhost;Port=5432;Database=praktikum-pbo;Username=postgres;Password=Password123";

        //READ
        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id, nama, umur, asal FROM users", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3)
                    ));
            }
            return list;
        }

        public User GetUser(int id)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "SELECT id, nama, umur, asal FROM users WHERE id = @id",
                conn);

            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetString(3)
                );
            }

            return null;
        }

        // CREATE
        public bool AddUser(User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "INSERT INTO users (nama, umur, asal) VALUES (@nama, @umur, @asal)", conn);

            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);

            int hasil = cmd.ExecuteNonQuery();

            return hasil > 0;
        }

        // UPDATE
        public bool UpdateUser(User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "UPDATE users SET nama=@nama, umur=@umur, asal=@asal WHERE id=@id", conn);

            cmd.Parameters.AddWithValue("id", user.id);
            cmd.Parameters.AddWithValue("nama", user.nama);
            cmd.Parameters.AddWithValue("umur", user.umur);
            cmd.Parameters.AddWithValue("asal", user.asal);

            int hasil = cmd.ExecuteNonQuery();

            return hasil > 0;
        }

        // DELETE
        public bool DeleteUser(User user)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "DELETE FROM users WHERE id=@id", conn);

            cmd.Parameters.AddWithValue("id", user.id);

            int hasil = cmd.ExecuteNonQuery();

            return hasil > 0;
        }
    }
}