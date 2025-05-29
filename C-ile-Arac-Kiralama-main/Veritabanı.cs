using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac_kiralama
{
    using MySql.Data.MySqlClient;

    namespace Arac_kiralama
    {
        public class Veritabani
        {
            private static string connectionString = "server=localhost;database=arackiralamadb;uid=root;pwd=12345;";
            // Not: Buradaki kullanıcı adı (uid) ve şifreyi kendi MySQL bilgine göre değiştir

            public static MySqlConnection BaglantiOlustur()
            {
                return new MySqlConnection(connectionString);
            }
        }
    }

}
