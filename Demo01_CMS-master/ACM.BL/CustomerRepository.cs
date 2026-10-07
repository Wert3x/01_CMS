using System.Linq;

namespace CMS.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository;

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "vlad@example.com";
                customer.FirstName = "Vladislav";
                customer.LastName = "Kozel";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            if (customer.Validate())
            {
                // Сохранение в БД
                return true;
            }
            return false;
        }
    }
}