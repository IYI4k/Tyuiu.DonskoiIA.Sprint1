using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DonskoiIA.Sprint1.Task4.V23.Lib
{
    public class DataService : ISprint1Task4V23
    {
        public double Calculate(double x, double y)
        {
            return Convert.ToInt32((Math.Pow(Math.Abs(x+y), 0.5) / Math.Abs(3-x)) * 1000) / 1000.0;
        }
    }
}