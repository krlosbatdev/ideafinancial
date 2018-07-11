namespace ideafinancial.Controllers.Resources
{
    public class UserResource
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public decimal CreditLimit { get; set; }
        public decimal Balance { get; set; }
        public decimal AvailableFunds { get; set; }

    }
}
