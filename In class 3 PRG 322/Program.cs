using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace In_class_3_PRG_322
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"server=54.187.154.185;userid=paulp;password=paulp;database=PAULDB";

            using
               (var con = new MySqlConnection(cs))
            {
                con.Open();
                Console.WriteLine($"MySQL version: {con.ServerVersion}");
            }
                

            


        }


    }
}
