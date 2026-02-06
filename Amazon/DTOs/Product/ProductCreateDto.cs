using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.DTOs.Product
{
    public class ProductCreateDto
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int DiscountedPersontage {  get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }

    }
}
