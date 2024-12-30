using System.ComponentModel.DataAnnotations.Schema;

namespace mola.Models
{
    public class RestoranResim
    {
        public int Id { get; set; }
        public string? ResimUrl { get; set; }
        public int RestoranId { get; set; }

       
    }
}
