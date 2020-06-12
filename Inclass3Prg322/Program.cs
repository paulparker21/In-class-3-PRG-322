using System;
using MySql.Data.MySqlClient;
namespace Inclass3Prg322
{
    class Program
    {
        static void Main(string[] args)
        {

            string cs = @"server=54.187.154.185;userid=paulp;password=paulp;database=PAULDB";

            using var con = new MySqlConnection(cs);
            
                con.Open();
                Console.WriteLine($"MySQL version: {con.ServerVersion}");

            var stm = "SELECT VERSION()";
            var cmd = new MySqlCommand(stm, con);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"MySQL version: {version}");

            insertData(con);
            





        }
        private static void insertData(MySqlConnection con)
        {
            var stm = "Insert into cars (name, price) valuse ('Porche', '19999999')";
            var cmd = new MySqlCommand(stm, con);
            cmd.ExecuteNonQuery();
        }



    }
}
