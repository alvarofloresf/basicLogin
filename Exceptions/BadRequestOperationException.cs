using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleLogin.Exceptions
{
    public class BadRequestOperationException: Exception
    {
        public BadRequestOperationException(string message)
            : base(message)
        {
        }
    }
}
