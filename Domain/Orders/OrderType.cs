using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Orders
{
    public class OrderType : BaseEntity
    {
        public int OrderTypeId { get; set; }

        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        [MinLength(1, ErrorMessageResourceName = "FieldMinLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [MaxLength(64, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [Display(Name = "OrderTypeName", ResourceType = typeof(Resources.Domain))]
        public string OrderTypeName { get; set; }

        public string OrderTypeDescription { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}