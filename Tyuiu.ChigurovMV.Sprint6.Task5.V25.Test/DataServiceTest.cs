using Tyuiu.ChigurovMV.Sprint6.Task5.V25.Lib;

namespace Tyuiu.ChigurovMV.Sprint6.Task5.V25.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void LoadFromDataFileTest()
		{
			DataService ds = new DataService();
			string path = @"C:\DataSprint6\InPutDataFileTask5V25.txt";
			double[] waitArray = new double[] { -17, 12, -14.32, 5, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, 35, -9, 13.83, 12.76, 8.86, -1.49, -7 };
			double[] resArray = ds.LoadFromDataFile(path);
			CollectionAssert.AreEqual(waitArray, resArray);
		}

		
	}
}