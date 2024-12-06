using Tyuiu.ChigurovMV.Sprint6.Task0.V22.Lib;
namespace Tyuiu.ChigurovMV.Sprint6.Task0.V22.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestCalculate()
		{
			DataService ds = new DataService();
			double wait = 11.68;
			int x = 2;
			double res = ds.Calculate(x);
			Assert.AreEqual(wait, res);
		}
	}
}