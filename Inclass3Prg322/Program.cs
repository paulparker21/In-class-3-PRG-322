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

            customerReader customerReader = new customerReader(con);

            customerReader.readAllData();

       

            
            





        }
      


    }
}
