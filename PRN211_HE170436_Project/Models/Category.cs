using System.ComponentModel.DataAnnotations;

namespace PRN211_HE170436_Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(150)]
        public string? CategoryName { get; set; }
        [StringLength(300)]
        public string? CategoryImage { get; set; }

        public int CategoryOrder { get; set; }
    }
}
