using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KhasanovRV.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n == 1)
            {
                if (m == 1)
                {
                    g -= 1;
                    m = 12;
                    n = 31;
                }
                
                else 
                { 
                    m -= 1;
                    switch (m)
                    {
                        case 1: n = 31; break;
                        case 2: n = 29; break;
                        case 3: n = 31; break;
                        case 4: n = 30; break;
                        case 5: n = 31; break;
                        case 6: n = 30; break;
                        case 7: n = 31; break;
                        case 8: n = 31; break;
                        case 9: n = 30; break;
                        case 10: n = 31; break;
                        case 11: n = 30; break;
                        default: n = 31; break;
                    }
                }
            }
            else
            { 
                n -= 1;
            }

            return (n.ToString() + '.' + m.ToString() + '.' + g.ToString());

        }
    }
}
