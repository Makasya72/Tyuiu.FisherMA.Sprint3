
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FisherMA.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetTabFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) + 3;

                
                if (Math.Abs(denominator) < 0.0001) 
                {
                    y = 0;
                }
                else
                {
                    y = (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }

        double[] ISprint3Task7V10.GetMassFunction(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}