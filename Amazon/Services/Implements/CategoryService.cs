using Amazon.DTOs.Category;
using Amazon.Exceptions.NotFoundException;
using Amazon.Models;
using Amazon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Implements
{
    public class CategoryService: IGenericService<CategoryCreateDto>
    {
       private List<Category> _categories = new List<Category>();

        public void Create(CategoryCreateDto dto)

        {
            var Category = new Category()
            {
                Id = dto.Id,
                Name = dto.Name,
                DepartmentId = dto.DepartmentId,
            };
            
            _categories.Add(Category);
        }

        

        public void Delete(int id)
            {
                var category = _categories.FirstOrDefault(c => c.Id == id);
                if (category == null) throw  new CategoryNotFoundException();
                    _categories.Remove(category);

                Console.WriteLine("Category was  removed");
            }

       

        public void GetAll()
        {
            foreach (var category in _categories)
            {
                Console.WriteLine($" id; {category.Id} , category; {category.Name}. ");
            }
        }
        public void GetById(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);

            if (category == null) throw new CategoryNotFoundException();
            Console.WriteLine($" id; {category.Id} , category; {category.Name}. ");
        }

    }

}