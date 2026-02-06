using Amazon.Exceptions.NotFoundException;
using Amazon.Models;
using Amazon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Implements
{
    public class DepartmentService:IDepartmentService
    {
       private List<Department> departments = new List<Department>();
        public void CreateDepartment(int id, string name)
        {
            var department = new Department()
            {
                Id = id,
                Name = name
            };
            departments.Add(department);
        }
        public void DeleteDepartment(int id)
        {
            var department = departments.FirstOrDefault(d => d.Id == id);
            if (department == null) throw new DepartmentNotFoundException();
          
                departments.Remove(department);

                Console.WriteLine("Department was removed");

            
        }
        public void GetAll()
        {
            foreach (var department in departments)
            {
                Console.WriteLine($"Id: {department.Id} - Department: {department.Name}");
            }
        }
        public void GetById(int id)
        {
            var department = departments.FirstOrDefault(d => d.Id == id);
            if (department == null) throw new DepartmentNotFoundException();
            else Console.WriteLine($"Id: {department.Id} - Department: {department.Name}");
        }
    }

}


