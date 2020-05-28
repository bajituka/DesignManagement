using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignManagement.Models
{
    public class Outfit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Project Project { get; set; }

        [Required(ErrorMessage = "Укажите название")]
        [StringLength(128, ErrorMessage = "Слишком длинное название")]
        public string Name { get; set; }
    }
}
