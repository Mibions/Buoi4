using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class HinhTron
    {
        protected ToaDo tam;
        protected double bankinh;
        public ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }
        public double Bankinh
        {
            get { return bankinh; }
            set { bankinh = value; }
        }

        public void Input()
        {
            Console.Write("Nhap vao ban kinh : ");
            Bankinh = Double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("Ban kinh la : " + BanKinh);
        }
         
        public double _tinhChuVi()
        {
            return Math.PI * 2 * Bankinh;
        }

        public double _tinhDienTich()
        {

            return Math.PI * Bankinh * Bankinh;
        }







        public string BanKinh { get; set; }
    }
}
