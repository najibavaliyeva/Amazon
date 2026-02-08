

using Amazon.DTOs.Customer;

namespace Amazon.Services.Interfaces
{
     public interface IGenericService<T> where T : class
    {
        void Create(T dto);
        void Delete(int id);
        void GetAll();
        void GetById(int id);
    }
}
