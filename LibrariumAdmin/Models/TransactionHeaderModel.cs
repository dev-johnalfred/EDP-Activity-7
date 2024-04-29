namespace LibrariumAdmin.Models
{
    public class TransactionHeaderModel
    {
        public int TransactionHeaderID { get; set; }
        public int PatronID { get; set; }
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
    }

}
