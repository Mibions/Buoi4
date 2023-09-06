using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class OrderDetail
    {
        protected int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        protected Product _product;

        public Product Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public double calcTotalPrice()
        {
            return 
        }

    }
}
