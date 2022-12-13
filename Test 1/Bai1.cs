using System;
namespace Test_1
{
	public class Bai1
	{
		public Bai1()
        {   
        }

        private double Delta(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }

        public void Display()
        {
            Console.WriteLine("Nhap lan luot cac he so cua phuong trinh bac 2:");
            Console.Write("Nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (Delta(a, b, c) >= 0)
            {
                Console.Write("can cua delta: ");
                Console.Write(Math.Sqrt(Delta(a, b, c)));
            }
            else Console.WriteLine("delta am");
        }

    }
}

