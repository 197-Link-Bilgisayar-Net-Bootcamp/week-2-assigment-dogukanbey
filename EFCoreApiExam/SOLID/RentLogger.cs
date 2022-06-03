using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDformExample
{
    public class RentLogger
    {
        private readonly ILogger logger;

        public RentLogger(ILogger logger)
        {
            this.logger = logger;
        }
        

        public void Log(string logInfo)
        {
            logger.Log(logInfo);
        }



        public interface ILogger
        {
            void Log(string logInfo);
        }


        public class InsuranceLogger : ILogger
        {
            public void Log(string logInfo)
            {
               // logging to insurance system
            }
        }
        public class CompanyLogger : ILogger
        {
            public void Log(string logInfo)
            {
               //  logging to company server
            }
        }

    }
}
