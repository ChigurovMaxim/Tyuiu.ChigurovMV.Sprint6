using Tyuiu.ChigurovMV.Sprint6.Task1.V14.Lib;
namespace Tyuiu.ChigurovMV.Sprint6.Task1.V14.Test
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
			waitArray[0] = -2.15;
			waitArray[1] = -2.57;
			waitArray[2] = -3;
			waitArray[3] = -3.83;
			waitArray[4] = -11.7;
			waitArray[5] = 3;
			waitArray[6] = 2.19;
			waitArray[7] = 3.31;
			waitArray[8] = 2.97;
			waitArray[9] = 1.18;
			waitArray[10] = 0.03;

			double[] resArray = ds.GetMassFunction(startValue, stopValue);
			CollectionAssert.AreEqual(waitArray, resArray);
		}
	}
}