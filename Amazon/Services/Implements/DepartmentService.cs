using Amazon.DTOs.Department;
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
    public class DepartmentService : IGenericService<DepartmentCreateDto>
    {
       private List<Department> departments = new List<Department>();

       

        public void Create(DepartmentCreateDto dto)
        {
            var department = new Department()
            {
                Id = dto.Id,
                Name =  dto.Name
            };
            departments.Add(department);
        }

      

        public void Delete(int id)
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


