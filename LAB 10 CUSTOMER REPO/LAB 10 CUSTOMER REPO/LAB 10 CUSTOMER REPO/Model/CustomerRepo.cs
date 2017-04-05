using System;
using System.Collections.Generic;
using System.Linq;

namespace LAB_10_CUSTOMER_REPO.Model
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly CustomerContext _context;

        public CustomerRepo(CustomerContext context)
        {
            _context = context;

            if (_context.CustomerItems.Count() == 0)
                Add(new CustomerItem { FirstName = "Steve", LastName = "Bills", Email = "SB@GMAIL.COM", Phone = "0114569887", Address = "123 Some Street", City = "ThisOne", State = "InSomeCountry", PostalAddress ="NobodyUsesThis" });
        }

        public IEnumerable<CustomerItem> GetAll()
        {
            return _context.CustomerItems.ToList();
        }

        public void Add(CustomerItem item)
        {
            _context.CustomerItems.Add(item);
            _context.SaveChanges();
        }

        public CustomerItem Find(long key)
        {
            return _context.CustomerItems.FirstOrDefault(t => t.CustomerId == key);
        }

        public void Remove(long key)
        {
            var entity = _context.CustomerItems.First(t => t.CustomerId == key);
            _context.CustomerItems.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(CustomerItem item)
        {
            _context.CustomerItems.Update(item);
            _context.SaveChanges();
        }
    }
}