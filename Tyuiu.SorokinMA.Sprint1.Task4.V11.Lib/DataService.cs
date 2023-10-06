using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SorokinMA.Sprint1.Task4.V11.Lib
{
    public class DataService : ISprint1Task4V11
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((Math.Atan(x)/Math.Pow(Math.E,y)),3);
        }
    }
}
