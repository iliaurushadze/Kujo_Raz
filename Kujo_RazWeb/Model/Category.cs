using System.ComponentModel.DataAnnotations;

namespace Kujo_RazWeb.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage ="Display Order Must Be In Range Of 1-100!!!")]
        public int DisplayOrder { get; set; }
    }
}
