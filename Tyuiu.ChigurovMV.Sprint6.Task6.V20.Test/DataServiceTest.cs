namespace Tyuiu.ChigurovMV.Sprint6.Task6.V20.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"C:\DataSprint6\InPutDataFileTask6V20.txt";
			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;
			Assert.AreEqual(true, fileExists);
		}
	}
}