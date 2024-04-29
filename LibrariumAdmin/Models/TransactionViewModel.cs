namespace LibrariumAdmin.Models
{
    public class TransactionViewModel
    {
        public int TransactionHeaderID { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PatronID { get; set; }
        public byte[]? Avatar { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }

}
