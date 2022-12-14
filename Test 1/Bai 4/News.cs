using System;
using Test_1.Bai4.Models;
namespace Test_1.Bai4
{
	public class News : INews
	{

		private readonly List<NewsModel> _newsList;

		public News()
		{
			_newsList = new();
		}

		public void Display()
		{
			foreach (var item in _newsList)
			{

				Console.WriteLine($"Title: {item.title}");
				Console.WriteLine($"Publish Date: {item.publishDate}");
				Console.WriteLine($"Author: {item.author}");
				Console.WriteLine($"Content: {item.content}");
				item.calculate();
			}
		}


		private void InsertNews()
		{
			NewsModel temp = new();
			Console.Write("Nhap title: ");
			temp.title = Console.ReadLine();
			Console.Write("Nhap publish date: ");
			temp.publishDate = Console.ReadLine();
			Console.Write("Nhap author: ");
			temp.author = Console.ReadLine();
			Console.Write("Nhap content: ");
			temp.content = Console.ReadLine();
			Console.Write("Nhap 3 danh gia: ");
			for(int i = 0; i < temp.rateList.Capacity; i++)
			{
				temp.rateList.Insert(i, Convert.ToInt32(Console.ReadLine())); 
			}
			_newsList.Add(temp);
		}

		public void Menu()
		{
			Console.WriteLine("1-Insert news");
			Console.WriteLine("2-View list news");
			Console.WriteLine("3-Average rate");
			Console.WriteLine("4-Exit");
			Console.Write("\nNhap lua chon: "); int x = Convert.ToInt32(Console.ReadLine());
			switch (x)
			{
				case 1:
					InsertNews();
					Menu2();
					break;
				case 2:
					Display();
					Menu3();
					break;
				case 3:
					break;
				case 4:
					break;
			}
		}

		private void Menu2()
		{
			Console.WriteLine("ban co muon nhap them news khong: 1. Co, 2. Khong");
			Console.Write("Nhap lua chon: ");
			int x = Convert.ToInt32(Console.ReadLine());
			switch (x)
			{
				case 1:
					this.InsertNews();
					Menu2();
					break;
				case 2:
					Menu();
					break;
			}
		}

		private void Menu3()
		{
			Console.WriteLine("\nban co muon quay lai menu: 1. Co, 2. Khong");
			Console.Write("Nhap lua chon: ");
			int y = Convert.ToInt32(Console.ReadLine());
			switch (y)
			{
				case 1:
					Menu();
					break;
				case 2:
					break;
			}
		}
	}
}

