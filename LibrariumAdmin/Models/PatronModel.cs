namespace LibrariumAdmin.Models
{
    public class PatronModel
    {
        public int PatronID { get; set; }
        public byte[]? Avatar { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
