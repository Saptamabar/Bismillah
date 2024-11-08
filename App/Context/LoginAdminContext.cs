using Bismillah.App.Core;
using Bismillah.App.Model;
using Bismillah.View;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.App.Context
{
    internal class LoginAdminContext : ContextWrapper
    {
        private static string table = "pengguna";

        public static DataTable All()
        {
            string query = @"
                SELECT * FROM pengguna";
            DataTable datapengguna = queryExecutor(query);
            return datapengguna;
        }
        public Akun Validate(string username, string password)
        {
            Akun loginAkun = null;
            string query = "SELECT * FROM pengguna WHERE username = @username AND password = @password";

            // Parameter untuk query
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@username", username),
            new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    loginAkun = new Akun(username, password);
                    loginAkun.username = (string)reader["username"];
                    loginAkun.password = (string)reader["password"];

                };
            return loginAkun;


        }
    }
}













