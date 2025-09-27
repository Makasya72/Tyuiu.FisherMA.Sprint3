using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FisherMA.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double a, int startValue, int stopValue)
        {
            int k = startValue;
            double sum = 0;

            while (k <= stopValue)
            {
                
                double term = (Math.Pow(a, k) + 0.5) * Math.Cos(k);
                sum += term;
                k++;
            }

            return Math.Round(sum, 3);
        }
    }
}