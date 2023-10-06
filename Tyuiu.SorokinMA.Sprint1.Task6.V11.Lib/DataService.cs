using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SorokinMA.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            for(var i = 1;i<value.Length;i++)
            {
                if (value[0]==value[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
