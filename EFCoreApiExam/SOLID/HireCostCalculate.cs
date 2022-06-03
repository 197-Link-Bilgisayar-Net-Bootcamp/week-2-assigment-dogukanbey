using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDformExample
{
    public class HireCostCalculate
    {
        public double Calculate(BaseArac barac)
        {

            return barac.GetCostPerDay() * Convert.ToDouble(barac.Day); 
           
        }
    }
}
