using System;
namespace Test_1
{
	public class Square
	{
		public float Edge { get; set; }
		public Square()
		{
		}

		public void EdgeInfo(float _edge)
		{
			Console.Write("Do dai canh: "); Console.Write(_edge);
		}

		public void Perimeter(float _edge)
		{
			Console.Write("\nChu vi: "); Console.Write(_edge * 4);
		}

		public void Area(float _edge)
		{
			Console.Write("\nDien tich: "); Console.Write(Math.Pow(_edge, 2));
		}

		public void Display(float _edge)
		{
			EdgeInfo(_edge);
			Perimeter(_edge);
			Area(_edge);
		}
	}

	public class SquareMain
	{
		public void Main()
		{
			Square square = new();
			Console.Write("Nhap do dai canh: ");
			square.Edge = Convert.ToSingle(Console.ReadLine());
			square.Display(square.Edge);
		}
	}

}

