using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Interfaces
{
    public interface ICategoryService
    {
        void CreateCategory(int id, string name, int departmentid);
        void CreateDepartment(int v1, string v2);
        void DeleteCategory(int id);
        void DeleteDepartment(int v);
        void GetAll();
        void GetById(int id);
    }
}
