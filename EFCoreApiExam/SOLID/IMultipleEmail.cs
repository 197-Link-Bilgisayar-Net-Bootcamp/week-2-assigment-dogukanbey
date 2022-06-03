using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDformExample
{
 
 
    public interface IMultipleEmail
    {
        void SendMultipleEmail(List<string> email, string note);

    }
}
