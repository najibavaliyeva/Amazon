using Amazon.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Interfaces
{
    public interface IProductService
    {
        void Create(ProductCreateDto dto);
        void Delete(int Id);
        void GetById(int Id);
        void GetAll();
    }
}
