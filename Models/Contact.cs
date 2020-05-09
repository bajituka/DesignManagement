using DesignManagement.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignManagement.Models
{
    public class Contact
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Заполните имя")]
        [StringLength(32, ErrorMessage = "Слишком длинное имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Заполните фамилию")]
        [StringLength(32, ErrorMessage = "Слишком длинная фамилия")]
        public string LastName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string ContactName { get; private set; }
#nullable enable
        [Phone]
        public string? Phone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
#nullable disable
        [Required]
        public ContactType Type { get; set; } = ContactType.Client;
    }
}
