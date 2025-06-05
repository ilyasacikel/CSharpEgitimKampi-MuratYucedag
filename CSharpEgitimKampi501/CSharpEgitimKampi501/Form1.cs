using CSharpEgitimKampi501.Dtos;
using CSharpEgitimKampi501.Repositories;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi501
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-GAARB72\\SQLEXPRESS; initial catalog=EgitimKampi501Db; integrated security = true");
        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * from TblProduct";
            var values = await connection.QueryAsync<ResultProductDto>(query); // Anlamı ResultProductDto sınıfı query'den gelen sorguyla eşlenecek.
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into TblProduct (ProductName,ProductStock,ProductPrice,ProductCategory) values (@productName,@productStock,@productPrice,@productCategory)";
            var parameters = new DynamicParameters(); // Sorgu içinde hazırlamış olduğum property'lere birer atama yapacağımı bildirmiş oldum.
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCategory", txtProductCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Ekleme işlemi başarılı.");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "delete from TblProduct where ProductId=@productId ";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Silme işlemi başarılı.");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update TblProduct Set ProductName=@productName,ProductStock=@productStock, ProductPrice=@productPrice, ProductCategory=@productCategory where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCategory", txtProductCategory.Text);
            parameters.Add("@productId", txtId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Güncelleme işlemi başarılı.");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "Select Count(*) From TblProduct";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
            lblTotalProductCount.Text = productTotalCount.ToString();

            string query2 = "Select ProductName from TblProduct Where ProductPrice=(Select Max(ProductPrice) from TblProduct)";
            var maxPriceProductName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceProductName.Text = maxPriceProductName.ToString();

            string query3 = "Select Count(Distinct(ProductCategory)) from TblProduct";
            var distinctProductCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblDistinctProductCount.Text = distinctProductCount.ToString();
        }

    }
}
