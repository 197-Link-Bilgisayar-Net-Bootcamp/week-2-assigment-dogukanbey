﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDformExample.Cars
{
    public class BMW :BaseArac, IEmailSender, IPostSender
    {

        public override double GetCostPerDay()
        {
            return 10;
        }

        public void SendEmail(string email , string note)
        {

        }


        public void SendPost(string address, string note)
        {

        }


    }
}
