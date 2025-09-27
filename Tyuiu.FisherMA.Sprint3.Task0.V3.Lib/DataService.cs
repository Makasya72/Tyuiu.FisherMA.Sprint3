
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.FisherMA.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sum += Math.Cos(i) * Math.Pow(0.5, i); 
            }
            return Math.Round(sum, 3);
        }
    }
}