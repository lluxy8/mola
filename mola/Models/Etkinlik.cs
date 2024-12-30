namespace mola.Models
{
    public class Etkinlik
    {
        public int Id { get; set; }
        public required string Kategori { get; set; }
        public string? Baslik { get; set; }
        public string? Text1 { get; set; }
        public string? Text2 { get; set; }
        public string? AnaResimUrl { get; set; }
    }
}
