using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class ToaDo
    {
        protected string ten;
        protected float x;
        protected float y;
        public string Ten
{
  get { return ten; }
  set { ten = value; }
}
        public float X
{
  get { return x; }
  set { x = value; }
}
        public float Y
{
  get { return y; }
  set { y = value; }
}

        public ToaDo()
        {
            Ten = "";
            X = 0;
            Y = 0;
        }
        public ToaDo(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Input()
        {
            Console.Write("Nhap vao toa do x : ");
            X = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao toa do y : ");
            Y = float.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("Toa do x : " + X);
            Console.WriteLine("Toa do y : " + Y);
        }

    }
}
