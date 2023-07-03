using Billing_Application.Models;

namespace Billing_Application.Services.Interface
{
    public interface ICustomer
    {

        void CreateCustomer(Customer customer);

        IEnumerable<Customer> GetCustomers();

        void UpdateCustomer(Customer customer);

        void DeleteCustomer(int customerId);
    }
}
