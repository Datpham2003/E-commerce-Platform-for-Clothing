using System.ComponentModel.DataAnnotations;

namespace PRN211_HE170436_Project.Models
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        [StringLength(30)]

        public string? ColorName { get; set; }
    }
}
