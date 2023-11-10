using System.ComponentModel.DataAnnotations;

namespace PRN211_HE170436_Project.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(30)]

        public string? SizeName { get; set; }
    }
}
