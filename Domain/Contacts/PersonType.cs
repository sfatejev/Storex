using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Contacts
{
    public class PersonType : BaseEntity
    {
        public int PersonTypeId { get; set; }

        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        [MinLength(1, ErrorMessageResourceName = "FieldMinLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [MaxLength(64, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [Display(Name = nameof(Resources.Domain.PersonTypeName), ResourceType = typeof(Resources.Domain))]
        public string PersonTypeName { get; set; }
        
        [MaxLength(255, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        public string PersonTypeDescription { get; set; }

        public virtual List<Person> Persons { get; set; }
    }
}