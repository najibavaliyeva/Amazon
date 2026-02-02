////CRUD: create,delete,getall,getbyid
using Amazon.Models;
using Amazon.Services.Implements;
using Amazon.Services.Interfaces;


#region Category
ICategoryService service = new CategoryService();

service.CreateCategory(2, "icecream", 3);
service.CreateCategory(3, "glass", 7);
service.CreateCategory(4, "iron", 9);
service.DeleteCategory(2);
service.GetAll();
service.GetById(2);
#endregion

#region Department
IDepartmentService service1 = new DepartmentService;
List<Department> departments = new List<Department>();
service.CreateDepartment(2, "icecream");
service.CreateDepartment(3, "glass");
service.DeleteDepartment(2);
service.GetAll();
service.GetById(3);

#endregion


#region Product
#endregion