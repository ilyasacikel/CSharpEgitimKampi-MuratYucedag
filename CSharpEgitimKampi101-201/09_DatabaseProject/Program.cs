using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // ADO.NET
            Console.WriteLine(" ***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ***** ");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Urünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("-------------------------------");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS; Initial Catalog=EgitimKampiDb; Integrated Security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); // SQL ile C# kodları arasında bir köprü görevi görür.
            DataTable dataTable = new DataTable(); //Verileri RAM belleğe almaya yarar.
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString()+" ");
                }
                Console.WriteLine();
            }

            connection.Close();



            Console.Read();
        }
    }
}
