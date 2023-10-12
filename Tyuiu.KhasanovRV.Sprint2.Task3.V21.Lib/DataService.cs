using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhasanovRV.Sprint2.Task3.V21.Lib
{
    public class DataService : ISprint2Task3V21
    {
        public double Calculate(double x)
        {
            double y = 0.0;
            if (x > 1)
                y = Math.Round(Math.Pow((x + 9) / (x - 1), x) * x, 3, MidpointRounding.AwayFromZero);
            else if (x == 0)
                y = Math.Round((x * x + 10) / (x * x - Math.Sin(x * x) + 12), 3, MidpointRounding.AwayFromZero);
            else if (-25 < x && x < 2)
                y = Math.Round(Math.Pow((1 + 1 / (x * x)), x), 3, MidpointRounding.AwayFromZero);
            else if (x < -25)
                y = Math.Round(x + 10 * x - (1 / x), 3, MidpointRounding.AwayFromZero);
            return y;

        }
    }
}
