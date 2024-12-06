using Tyuiu.ChigurovMV.Sprint6.Task2.V15.Lib;
namespace Tyuiu.ChigurovMV.Sprint6.Task2.V15.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void GetMassFunctionTest()
		{
			DataService ds = new DataService();
			int stopValue = 5;
			int startValue = -5;
			int len = stopValue - startValue + 1;
			double[] waitArray = new double[len];
			waitArray[0] = 70.14;
			waitArray[1] = 55.21;
			waitArray[2] = 41.05;
			waitArray[3] = 27.96;
			waitArray[4] = 15.48;
			waitArray[5] = 1;
			waitArray[6] = -13.06;
			waitArray[7] = -28.16;
			waitArray[8] = -42.96;
			waitArray[9] = -56.77;
			waitArray[10] = -69.83;

			double[] resArray = ds.GetMassFunction(startValue, stopValue);
			CollectionAssert.AreEqual(waitArray, resArray);
		}
	}
}