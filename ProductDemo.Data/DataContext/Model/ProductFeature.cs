using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProductDemo.Data.Model
{
    public class ProductFeature
    {
        [Key]
        public int ProductFeatureId { get; set; }
        [Required(ErrorMessage = "{0} bos buraxma")]
        [DisplayName("Ozellik Adi")]
        public string FeatureName { get; set; }
        [DisplayName("Ozellik Deyeri")]
        public string FeatureValue { get; set; }
        [DisplayName("Basliq")]
        public string HeadLine { get; set; }
        [DisplayName("Acixlama")]
        public string Desciription { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
