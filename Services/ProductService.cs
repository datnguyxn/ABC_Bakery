﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Bakery.Helpers;
using ABC_Bakery.Repositories;
using ABC_Bakery.Models;
using IronBarCode;
using Image = System.Drawing.Image;
namespace ABC_Bakery.Services
{
    internal class ProductService
    {
        private static ProductService _instance = null;
        private readonly DatabaseContext _db;
        private readonly ProductRepository _productRepository;

        private ProductService()
        {
            _db = new DatabaseContext();
            _productRepository = new ProductRepository(_db);
        }

        public static ProductService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProductService();
            }
            return _instance;
        }

        public List<Product> GetAll()
        {
            return _productRepository.FindAll();
        }

        public Product FindById(int id)
        {
            return _productRepository.Find(id);
        }

        public Product FindByBarcode(string barcode)
        {
            if (barcode == null) return null;
            if (string.IsNullOrEmpty(barcode)) return null;
            string id = barcode.Substring(Product.Prefix.Length + 1);

            // check id is number
            if (!int.TryParse(id, out int result)) return null;

            return _productRepository.Find(result);
        }

        public Image GetBarcode(int id)
        {
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(string.Format("{0}_{1}", Product.Prefix, id), BarcodeWriterEncoding.Code128, 200, 60);

            // convert barcode to image
            Image barcodeImage = barcode.Image;
            
            return barcodeImage;
        }

        public List<Product> FindByIdIn(List<int> ids)
        {
            return _productRepository.FindByIdIn(ids);
        }

        public bool Create(Product obj)
        {
            return _productRepository.Create(obj);
        }

        public Product Find(int id)
        {
            return _productRepository.Find(id);
        }
    }
}