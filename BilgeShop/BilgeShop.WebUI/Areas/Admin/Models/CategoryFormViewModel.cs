using System.ComponentModel.DataAnnotations;

namespace BilgeShop.WebUI.Areas.Admin.Models
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; } 

        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Kategori Adı alanını doldurmak zorunludur.")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [MaxLength(1000)]
        public string? Description { get; set; }
        
    }
}
