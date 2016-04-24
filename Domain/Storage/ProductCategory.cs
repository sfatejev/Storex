using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Storage
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        [MinLength(1, ErrorMessageResourceName = "FieldMinLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [MaxLength(64, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [Display(Name = "ProductCategoryName", ResourceType = typeof(Resources.Domain))]
        public string ProductCategoryName { get; set; }

        [MaxLength(255, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        public string ProductCategoryDescription { get; set; }

        public virtual List<Product> Products { get; set; } 
    }
}