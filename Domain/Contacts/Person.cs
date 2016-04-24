using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Identity;

namespace Domain.Contacts
{
    public class Person : BaseEntity
    {
        public int PersonId { get; set; }
        
        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        [MinLength(1, ErrorMessageResourceName = "FieldMinLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [MaxLength(128, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [Display(Name = nameof(Resources.Domain.Firstname), ResourceType = typeof(Resources.Domain))]
        public string Firstname { get; set; }

        [Required(ErrorMessageResourceName = "FieldIsRequired", ErrorMessageResourceType = typeof(Resources.Common))]
        [MinLength(1, ErrorMessageResourceName = "FieldMinLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [MaxLength(128, ErrorMessageResourceName = "FieldMaxLength", ErrorMessageResourceType = typeof(Resources.Common))]
        [Display(Name = nameof(Resources.Domain.Lastname), ResourceType = typeof(Resources.Domain))]
        public string Lastname { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(PersonType))]
        public int PersonTypeId { get; set;}
        public virtual PersonType PersonType { get; set; }

        public virtual List<Contact> Contacts { get; set; }

        [NotMapped]
        public string FirstLastname => (Firstname + " " + Lastname).Trim();
        [NotMapped]
        public string LastFirstname => (Lastname + " " + Firstname).Trim();
    }
}