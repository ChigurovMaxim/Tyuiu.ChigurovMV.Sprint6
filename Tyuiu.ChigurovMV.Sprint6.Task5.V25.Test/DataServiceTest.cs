namespace Tyuiu.ChigurovMV.Sprint6.Task5.V25.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			string path = @"C:\DataSprint6\InPutDataFileTask5V25.txt";
			FileInfo fileInfo = new FileInfo(path);
			bool fileExists = fileInfo.Exists;
			Assert.AreEqual(true, fileExists);
		}

		
	}
}