using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDformExample.Cars
{
    public class Kia : BaseArac, IEmailSender
    {

        public override double GetCostPerDay()
        {
            return 7;
        }
        public void SendEmail(string email, string note)
        {

        }

 
    }
}
