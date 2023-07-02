using System.ComponentModel.DataAnnotations.Schema;

namespace Billing_Application.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } 
        public int CustomerDeposit { get; set; }  
       
    }
}
