using Billing_Application.Models;

namespace Billing_Application.Services.Interface
{
    public interface IProduct
    {

        void CreateProduct(Customer customer);

        IEnumerable<Product> GetProducts();

        void UpdateProduct(Product Product);

        void DeleteProduct(int ProductId);
    }
}
