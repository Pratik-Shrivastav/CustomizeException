using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizeException.ExceptionHandler
{
    public class AgeLess: Exception
    {
        public AgeLess(string message):base(message) 
        { 
        }
    }
}
