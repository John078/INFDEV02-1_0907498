using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Tryoutdatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=localhost;Port = 3306;Database = project;Uid = root;password = Sita4ever;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select Perioden from project3 where ID=2";
            try
            {
                conn.Open();
            }
               catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Perioden"].ToString());
            }
            Console.ReadLine();
        }
    }
}
