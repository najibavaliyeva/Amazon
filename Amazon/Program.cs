//CRUD: create,delete,getall,getbyid
using Amazon.Models;
using Amazon.Services.Implements;
CategoryService service = new CategoryService();


service.CreateCategory(2, "icecream", 3);
service.CreateCategory(3, "glass", 7);
service.CreateCategory(4, "iron", 9);


service.DeleteCategory(2);

service.GetAll();
  
service.GetById(2);