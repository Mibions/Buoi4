using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo a = new ToaDo();
            HinhTron b = new HinhTron();
            a.Input();
            b.Input();
            Console.WriteLine("Chu vi hinh tron la : " + Math.Round(b._tinhChuVi(),3));
            Console.WriteLine("Dien tich hinh tron la : " + Math.Round(b._tinhDienTich(),3));
            Console.ReadKey();
        }
    }
}

