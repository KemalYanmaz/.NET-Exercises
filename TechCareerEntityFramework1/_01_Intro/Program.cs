using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=NORTHWIND;Trusted_Security=True");
            SqlCommand command = new SqlCommand("Select * From Categories",connection);
            connection.Open();
            SqlDataReader  reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
            }

            connection.Close();
            
        }
    }
}
