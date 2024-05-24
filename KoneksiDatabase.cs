using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration; // Buat membaca App.config

namespace ProjectPBO
{
    public class KoneksiDatabase
    {
        static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;
        }

        public static NpgsqlConnection BuatKoneksi()
        {
            string connectionString = GetConnectionString();
            return new NpgsqlConnection(connectionString);
        }
    }
}
