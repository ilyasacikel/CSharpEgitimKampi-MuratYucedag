﻿using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory: Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Kategori başarıyla eklendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Kategori başarıyla silindi.");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var value = _categoryService.TGetById(id);
            dataGridView1.DataSource = new List<Category> { value};

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(id);
            updatedValue.CategoryName = txtCategoryName.Text;
            if (rdbActive.Checked) updatedValue.CategoryStatus = true;
            else if (rdbPassive.Checked) updatedValue.CategoryStatus = false;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Kategori başarıyla güncellendi.");

        }
    }
}
