namespace Tech_Potential_Challenge_Payment_API.Models
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        public Product(string name, decimal value)
        {
            Id = Guid.NewGuid();
            Name = name;
            Value = value;
        } 

        public void Update(Product product)
        {
            Name = product.Name;
            Value = product.Value;
        }       
    }
}