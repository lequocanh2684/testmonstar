using System;
namespace Test_1
{
	public class Bai2
	{
		public Bai2()
		{
		}

		static long muc1 = 1000;
		static long muc2 = 1250;
		static long muc3 = 1800;
		static long muc4 = 2500;

		private long Elec_price(long elec_num)
		{
			if (elec_num is > 0 and <= 25)
			{
				return elec_num * muc1;
			}
			else if (elec_num is > 25 and <= 75) {
				return (elec_num - 25) * muc2 + 25 * muc1;
			}
			else if(elec_num is > 75 and <= 150)
			{
				return (elec_num - 75) * muc3 + 50 * muc2 + 25 * muc1;
			}
			else return (elec_num - 150) * muc4 + 75 * muc3 + 50 * muc2 + 25 * muc1;
		}

		public void Display()
		{
			Console.Write("Nhap so muc tieu thu dien: ");
			long a = Convert.ToInt64(Console.ReadLine());
			Console.Write("So dien phai tra cua gia dinh trong 1 thang la: ");
			Console.Write(Elec_price(a));
		}
	}
}

