using Tyuiu.ChigurovMV.Sprint6.Task6.V20.Lib;
namespace Tyuiu.ChigurovMV.Sprint6.Task6.V20.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void CollectTextFromFileTest()
		{
			DataService ds = new DataService();
			string path = @"C:\DataSprint6\InPutDataFileTask6V20.txt";
			string waitStr = "dKOPBC IqjpIlKAaSCBuaQUU GPeEqZo FPsrQHsImzbTBckw NgAfitECn";
			string resStr = ds.CollectTextFromFile(path);
			Assert.AreEqual(waitStr, resStr);
		}
	}
}