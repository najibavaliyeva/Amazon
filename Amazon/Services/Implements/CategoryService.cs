using Amazon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Implements
{
    public class CategoryService
    {
        List<Category> categories = new List<Category>();

        public void CreateCategory(int id, string name, int departmentid)
        {
            Category category = new Category()
            {
                Id = id,
                Name = name,
                DepartmentId = departmentid
            };
            categories.Add(category);
        }
        public void DeleteCategory(int id)
            {
                var category = categories.FirstOrDefault(c => c.Id == id);
                if (category == null) Console.WriteLine("Category was not found");
                else
                    categories.Remove(category);
                Console.WriteLine("Category was  removed");
            }
        public void GetAll()
        {
            foreach (var category in categories)
            {
                Console.WriteLine($" id; {category.Id} , category; {category.Name}. ");
            }
        }
        public void GetById(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null) Console.WriteLine("Category was not found");
            else Console.WriteLine($" id; {category.Id} , category; {category.Name}. ");
        }

    }

}