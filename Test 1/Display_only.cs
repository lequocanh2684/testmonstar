using System;
namespace Test_1
{
	public class Display_only
	{
		public Display_only()
		{
		}

		public void Display1()
		{
            Bai1 bai1 = new();
            Bai2 bai2 = new();
            Console.WriteLine("1. Bai 1");
            Console.WriteLine("2. Bai 2");
            Console.Write("Nhap lua chon bai tap: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    bai1.Display();
                    Display2();
                    break;
                case 2:
                    bai2.Display();
                    Display2();
                    break;
                default: break;
            }
        }

        private void Display2()
        {
            Console.WriteLine("\nban co muon chon bai khac khong? 1. Co, 2. Khong");
            Console.Write("Nhap lua chon: ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Display1();
                    break;
                case 2:
                    break;
            }
        }
	}
}

