using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projekt_Skoki
{
    class Baza
    {
        public static MySqlConnection Polaczenie()
        {
            return new MySqlConnection("server=localhost;user id=programowanie;password=programowanie;database=skokinarciarskie");
        }
    }
}
