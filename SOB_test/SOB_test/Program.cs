using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SOB_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConnecitonString = "Server=192.168.2.105;Database=SOB_test;Uid=sob;Pwd=sob12;";
            MySqlConnection conn = new MySqlConnection(ConnecitonString);
            bool consucces = false;

            try 
            {
                conn.Open();
                Console.WriteLine("udalo sie nawiazac polaczenie");
                consucces = true;
                
            }
            catch (MySqlException e) 
            {
                Console.WriteLine("nie udalo sie nawiazac polaczenia");

                Console.WriteLine(e);
     
            }

            if (consucces)
            {
                try
                {
                    string ask = "SELECT * FROM test";
                    MySqlCommand cmd = new MySqlCommand(ask, conn);
                    MySqlDataReader dr;
              
                    dr = cmd.ExecuteReader();
                    Console.WriteLine("............................");
                    Console.WriteLine("id name age");
                    while (dr.Read())
                    {
                    
                        Console.WriteLine("............................");
                        Console.WriteLine("{0} {1} {2}",dr.GetInt16(0),dr.GetValue(1),dr.GetValue(2));
                        
                    }

                }
                catch (MySqlException e)
                {
                    Console.WriteLine("nie udalo sie wyswietlic bazy, blad {0}", e);
                }
            }
            conn.Close();
            Console.ReadKey();
        }
    }
}
