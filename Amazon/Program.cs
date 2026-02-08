////CRUD: create,delete,getall,getbyid
using Amazon.DTOs.Category;
using Amazon.DTOs.Customer;
using Amazon.DTOs.Department;
using Amazon.DTOs.Product;
using Amazon.Models;
using Amazon.Services.Implements;
using Amazon.Services.Interfaces;
using System.ComponentModel.DataAnnotations;


#region Category
//IGenericService<CategoryCreateDto> service = new CategoryService();
//var icecream = new CategoryCreateDto { Id = 2, Name = "icecream", DepartmentId = 3 };
//var glass = new CategoryCreateDto { Id = 3, Name = "glass", DepartmentId = 7 };
//var iron = new CategoryCreateDto { Id = 4, Name = "iron", DepartmentId = 9 };


//service.Delete(2);
//service.GetById(2);
//service.GetAll();
#endregion

#region Department
//IGenericService<DepartmentCreateDto> service1 = new DepartmentService();
//var icecream = new DepartmentCreateDto { Id = 2, Name = "icecream" };
//var glass = new DepartmentCreateDto { Id = 3, Name = "Glass" };


//service1.Delete(2);
//service1.GetAll();
//service1.GetById(3);

#endregion


#region Product
//IProductService dto = new ProductService();
//var dto1 = new ProductCreateDto()
//{
//    Id = 33,
//    Name = "Glass",
//    Description = "Cystal",
//    CategoryId = 2,
//    Price = 40,
//    ImageUrl = "https://www.com/ewhd.png",
//    DiscountedPersontage = 70
//};

//var dto2 = new ProductCreateDto()
//{
//    Id = 12,
//    Name = "Glass",
//    Description = "Cystal",
//    CategoryId = 2,
//    Price = 36,
//    ImageUrl = "https://www.com/ewhd.png",
//    DiscountedPersontage = 0
//};



//var dto3 = new ProductCreateDto()
//{
//    Id = 22,
//    Name = "Glass",
//    Description = "Cystal",
//    CategoryId = 2,
//    Price = 55,
//    ImageUrl = "https://www.com/ewhd.png",
//    DiscountedPersontage = 5
//};
//dto.Create(dto1);
//dto.Create(dto2);
//dto.Create(dto3);
//// dto.GetAll();
//dto.GetById(22);


#endregion
#region Customer
using Amazon.DTOs.Customer; 
using Amazon.Services.Implements;
using Amazon.Services.Interfaces;
using Amazon.DTOs.Department;

  IGenericService<CustomerCreateDto> customerservice = new  CustomerService();
  
var dtoc = new CustomerCreateDto()
{
   Id = 5,
    FirstName = "Najiba",
    LastName = "Valiyeva",
    Email = "www.vn2003@gmail.com",
    Password = "hsadh",
    PhoneNumber = "1234567890",
};
#endregion