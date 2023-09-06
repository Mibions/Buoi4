using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Product
    {
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _producID;
        public string ProducID
        {
            get { return _producID; }
            set { _producID = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Product()
        {
            Description = "";
            ProducID = "";
            Price = 0;
        }

        public Product(string description, string productid, double price)
        {
            this.Description = description;
            this.ProducID = productid;
            this.Price = price;
        }

        public void Input()
        {
            Console.WriteLine("Nhap vao mo ta san pham : ");
            Description = Console.ReadLine();
            Console.WriteLine("Nhap vao ma san pham : ");
            ProducID = Console.ReadLine();
            Console.WriteLine("Nhap vao gia san pham : ");
            Price = Double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("Mo ta san pham : " + Description);
            Console.WriteLine("Ma san pham : " + ProducID);
            Console.WriteLine("Gia san pham : " + Price);
        }









    }
}
