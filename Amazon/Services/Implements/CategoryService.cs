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
    public class CategoryService:ICategoryService
    {
       private List<Category> _categories = new List<Category>();

        public void CreateCategory(int id, string name, int departmentid)
        {
            Category category = new Category()
            {
                Id = id,
                Name = name,
                DepartmentId = departmentid
            };
            _categories.Add(category);
        }

        

        public void DeleteCategory(int id)
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