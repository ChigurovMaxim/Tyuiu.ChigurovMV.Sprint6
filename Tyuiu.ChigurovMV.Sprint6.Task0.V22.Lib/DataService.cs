using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ChigurovMV.Sprint6.Task0.V22.Lib
{
	public class DataService : ISprint6Task0V22
	{
		public double Calculate(int x)
		{
			double y = 0.7*Math.Pow((double)x, 3) + 1.52*Math.Pow((double)x,2);
			return Math.Round(y, 3);
		}
	}
}
