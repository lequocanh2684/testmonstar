using System;
namespace Test_1.Bai4.Models
{
	public class NewsModel
	{
        private float averageRate;
        public int id { get; set; }
        public string? title { get; set; }
        public string? publishDate { get; set; }
        public string? author { get; set; }
        public string? content { get; set; }
        public float AverageRate { get { return averageRate; } }
        public List<int> rateList = new(3);

        public NewsModel()
        {
		}

        public void calculate()
        {
            try
            {
                averageRate = (float)rateList.Average();
                Console.WriteLine($"Average Rate: {AverageRate}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

