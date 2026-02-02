using Amazon.Models;
using Amazon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Implements
{
    public class DepartmentService:IDepartmentService
    {
        List<Department> departments = new List<Department>();
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
            if (department == null) Console.WriteLine("Departmentt was not found");
            else
            {
                departments.Remove(department);
                Console.WriteLine("Department was removed");

            }
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
            if (department == null) Console.WriteLine("Department was not found");
            else Console.WriteLine($"Id: {department.Id} - Department: {department.Name}");
        }
    }

}


