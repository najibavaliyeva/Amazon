using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Services.Interfaces
{
    public interface IDepartmentService
    {
        void CreateDepartment(int id, string name);
       void DeleteDepartment(int id);
        void GetAll();
        void GetById(int id);
    }
}
