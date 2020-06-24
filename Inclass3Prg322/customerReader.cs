using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Inclass3Prg322
{
    public class customerReader
    {
        private MySqlConnection con;
     
        
        
        public customerReader(MySqlConnection con)
        {
            this.con = con;
        
    
    


    

        }

        public void readAllData()
        {
            string sql = "SELECT * FROM customer";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Customer List");
            while (reader.Read())
            {
                Console.WriteLine($"Number: {reader.GetInt32(0)} Direction: {reader.GetString(2)}");
            }
        
        }
    } 













    

    



}
