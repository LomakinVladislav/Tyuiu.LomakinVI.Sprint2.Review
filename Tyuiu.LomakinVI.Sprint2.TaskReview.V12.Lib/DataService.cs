using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LomakinVI.Sprint2.TaskReview.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool result;
            if (((y <= x*x) && (y <= 2 - x) && (y >= 0) && (x >= 0)) || ((y <= x * x) && (y >= 2 - x) && (x <= 0)))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
