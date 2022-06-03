using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDformExample.Cars
{
    public class Hyundai : BaseArac, IEmailSender, IMultipleEmail
    {

        public override double GetCostPerDay()
        {
            return 6;
        }



        public void SendEmail(string email, string note)
        {

        }

        public void SendMultipleEmail(List<string> email, string note)
        {
          
        }
    }
}
