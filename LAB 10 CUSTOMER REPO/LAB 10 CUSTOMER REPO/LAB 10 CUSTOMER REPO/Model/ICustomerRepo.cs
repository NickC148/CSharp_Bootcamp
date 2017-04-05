using System.Collections.Generic;

namespace LAB_10_CUSTOMER_REPO.Model
{
    public interface ICustomerRepo
    {
        void Add(CustomerItem item);
        IEnumerable<CustomerItem> GetAll();
        CustomerItem Find(long CustomerId);
        void Remove(long CustomerId);
        void Update(CustomerItem CustomerId);
    }
}