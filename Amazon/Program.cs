////CRUD: create,delete,getall,getbyid
using Amazon.DTOs.Product;
using Amazon.Models;
using Amazon.Services.Implements;
using Amazon.Services.Interfaces;


//#region Category
//ICategoryService service = new CategoryService();

//service.CreateCategory(2, "icecream", 3);
//service.CreateCategory(3, "glass", 7);
//service.CreateCategory(4, "iron", 9);
//service.DeleteCategory(2);
//service.GetAll();
//service.GetById(2);
//#endregion

//#region Department
//IDepartmentService service1 = new DepartmentService();
//service1.CreateDepartment(2, "icecream");
//service1.CreateDepartment(3, "glass");
//service1.DeleteDepartment(2);
//service.GetAll();
//service.GetById(3);

//#endregion


#region Product
IProductService dto = new ProductService();
var dto1 = new ProductCreateDto()
{
    Id = 33,
    Name = "Glass",
    Description = "Cystal",
    CategoryId = 2,
    Price = 40,
    ImageUrl = "https://www.com/ewhd.png",
    DiscountedPersontage = 70
};

var dto2 = new ProductCreateDto()
{
    Id = 12,
    Name = "Glass",
    Description = "Cystal",
    CategoryId = 2,
    Price = 36,
    ImageUrl = "https://www.com/ewhd.png",
    DiscountedPersontage = 0
};



var dto3 = new ProductCreateDto()
{
    Id = 22,
    Name = "Glass",
    Description = "Cystal",
    CategoryId = 2,
    Price = 55,
    ImageUrl = "https://www.com/ewhd.png",
    DiscountedPersontage = 5
};
dto.Create(dto1);
dto.Create(dto2);
dto.Create(dto3);
// dto.GetAll();
dto.GetById(22);


#endregion
