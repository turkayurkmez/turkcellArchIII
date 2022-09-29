using DDDElements.ValueObject;

namespace DDDElements.Entites
{
    public class Customer
    {
        //Customer'in özellik ve davranışları...
        public string Name { get; set; }

        public void ChangeName(string name)
        {
            Name = name;
        }

        internal void CreateOrder()
        {
            throw new NotImplementedException();
        }

        internal void CreateOrder(Product product, Address address)
        {
            //Sipariş oluşturuldukda; OrderCreated olayı fırlar ve bir başka nesne tarafından handle edilir...

            throw new NotImplementedException();
        }

        public ContactInfo ContactInfo { get; set; }

    }
}
