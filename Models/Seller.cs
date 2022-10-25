namespace Tech_Potential_Challenge_Payment_API.Models
{
    public class Seller
    {
        public Guid Id { get; private set; }
        public string Document { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public Seller(string document, string name, string email, string phone)
        {
            Id = Guid.NewGuid();
            Document = document;
            Name = name;
            Email = email;
            Phone = phone;
        }

        public void Update(Seller seller)
        {
            Document = seller.Document;
            Name = seller.Name;
            Email = seller.Email;
            Phone = seller.Phone;
        }
    }
}