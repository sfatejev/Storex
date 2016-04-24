using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataAnnotations;
using Domain.Storage;

namespace Domain.Orders
{
    public class OrderedProduct : BaseEntity
    {
        public int OrderedProductId { get; set; }

        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public int OrderedProductQuantity { get; set; }

        [Precision(8, 2)]
        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public double OrderedProductValue { get; set; } //Ordered product value(toote hind arvel / pakkumisel)

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}