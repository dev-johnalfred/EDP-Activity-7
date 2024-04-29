namespace LibrariumAdmin.Models
{
    public class BookModel
    {
        public int BookID { get; set; }
        public byte[]? Thumbnail { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }
        public string? ISBN { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
    }

}
