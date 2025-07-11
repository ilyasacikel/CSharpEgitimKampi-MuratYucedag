﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crud --> Create-Read-Update-Delete
            Console.WriteLine(" ***** Menü Sipariş İşlem Paneli ***** ");
            Console.WriteLine();

            Console.WriteLine("-------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Ürun Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürun Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Eklemesi Başarılı!");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = Convert.ToInt32(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı.");
            #endregion

            #region Ürünn Güncelleme İşlemi

            Console.Write("Guncellenecek Üruün Id: ");
            int productId = int.Parse(Console.ReadLine());
            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();
            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme Başarılı.");
            #endregion
            Console.Read();

        }
    }
}
