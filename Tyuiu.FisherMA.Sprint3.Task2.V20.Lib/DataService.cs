using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FisherMA.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            int k = startValue;
            double product = 1;

            do
            {
                double denominator = Math.Cos(value) + 0.5;
                double term = 2 / denominator;
                product *= Math.Pow(term, k);
                k++;
            } while (k <= stopValue);

            return Math.Round(product, 3);
        }

        double ISprint3Task2V20.GetMultiplySeries(int value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}