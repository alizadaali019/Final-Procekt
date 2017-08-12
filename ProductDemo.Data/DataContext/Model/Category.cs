using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductDemo.Data.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="{0} bos buraxma")]
        [DisplayName("Kategori Adi")]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
