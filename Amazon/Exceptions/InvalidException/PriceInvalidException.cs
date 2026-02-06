using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Exceptions.InvalidException
{
    public class PriceInvalidException:Exception
    {
        public PriceInvalidException(): base("Price must be greater or equal to zero")
        {
            
        }
    }
}
