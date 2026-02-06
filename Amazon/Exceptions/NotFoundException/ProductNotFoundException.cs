using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Exceptions.NotFoundException
{
    public class ProductNotFoundException : NotFoundException
    {
        public ProductNotFoundException() : base("Product")
        {
        }
    }
}
