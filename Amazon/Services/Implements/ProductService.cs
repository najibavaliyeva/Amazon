using Amazon.DTOs.Product;
using Amazon.Exceptions.InvalidException;
using Amazon.Exceptions.NotFoundException;
using Amazon.Extensions;
using Amazon.Models;
using Amazon.Services.Interfaces;

namespace Amazon.Services.Implements
{
    public class ProductService : IGenericService<ProductCreateDto>
    {

         private List<Product> _products = new List<Product>();


        public void Create(ProductCreateDto dto)
        {
            var result = dto.Price.IsGreaterThanZero();
            if (!result) throw new PriceInvalidException();
            var product = new Product()
            {
                Id = dto.Id,
                Name = dto.Name,
                CategoryId = dto.CategoryId,
                Description = dto.Description,
                Price = dto.Price,
                ImageUrl = dto.ImageUrl,
                DiscountedPrice = (dto.Price * (100 - dto.DiscountedPersontage)) / 100
            }; _products.Add(product);
            Console.WriteLine("Product was added successfully!");
        }

        public void Delete(int Id)
        {
            var product = _products.FirstOrDefault( p => p.Id == Id);   
            if (product != null) throw new Exceptions.NotFoundException.ProductNotFoundException();
            _products .Remove(product);
            Console.WriteLine("Product was removed successfully!");
        }

        public void GetAll()
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"{product.Id}-{product.Name}/n-${product.DiscountedPrice}/n{product.Description}- Original:${product.Price}");
            }
        }
            

        public void GetById(int Id)
        {
            var product = _products.FirstOrDefault(p=>p .Id == Id);
            if (product == null) throw new ProductNotFoundException();
            Console.WriteLine($"{product.Id}-{product.Name}\n-{product.DiscountedPrice}\n{product.Description}- Original:{product.Price}");
        }
    }

   
}
