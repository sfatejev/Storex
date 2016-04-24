using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Contacts
{
    public class ContactType : BaseEntity
    {
        public int ContactTypeId { get; set; }
        
        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        [MinLength(1, ErrorMessageResourceName = "FieldMinLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [MaxLength(1, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [Display(Name = nameof(Resources.Domain.ContactTypeName), ResourceType = typeof(Resources.Domain))]
        public string ContactTypeName { get; set; }

        [MaxLength(255, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        public string ContactTypeDescription { get; set; }

        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        public bool ContactTypeActive { get; set; }


        public virtual List<Contact> Contacts { get; set; } = new List<Contact>();
    }
}