using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolodykhVY.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value)
        {
            double k = 1;
            double res = 0;
            do
            {
                res += Math.Pow(1 / (Math.Sin(k) + 2 * Math.Pow(value, k)), k);
                k++;

            }
            while (k < 11);

            return Math.Round(res, 3);
        }

        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}

