using System.Collections.Generic;

namespace CMS.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Sovetskaya St";
                address.City = "Grodno";
                address.PostalCode = "230000";
                address.Country = "Belarus";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Sovetskaya St",
                City = "Grodno",
                PostalCode = "230000",
                Country = "Belarus"
            };
            addressList.Add(address);
            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}