using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    internal class ProductDetails
    {
        private int _productId;
        private string _productName;
        private double _unitPrice;
        private int _qty;

        public ProductDetails(int id)
        {
            _productId = id;
        }

        public int ProductId
        {
            get { return _productId; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public int Quantity
        {
            get { return _qty; }
            set { _qty = value; }
        }

        public void ShowDetails()
        {
            double total = _unitPrice * _qty;

            Console.WriteLine("Product Id: " + _productId);
            Console.WriteLine("Product Name: " + _productName);
            Console.WriteLine("Unit Price: " + _unitPrice);
            Console.WriteLine("Quantity: " + _qty);
            Console.WriteLine("Total Amount: " + total);
        }
    }
}