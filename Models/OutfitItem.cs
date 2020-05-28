using DesignManagement.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DesignManagement.Models
{
    public class OutfitItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Outfit Outfit { get; set; }

        [Required(ErrorMessage = "Укажите тип комплектации")]
        public OutfitType OutfitType { get; set; }

        [Required(ErrorMessage = "Укажите название")]
        [StringLength(128, ErrorMessage = "Слишком длинное название")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Укажите количество")]
        public int Quantity { get; set; }

#nullable enable
        public CoatingType? CoatingType { get; set; }

        public byte[]? Image { get; set; }

        public string? Room { get; set; }

        [StringLength(128, ErrorMessage = "Слишком длинный комментарий")]
        public string? DesignerComment { get; set; }

        public Supplier[]? Suppliers { get; set; }
#nullable disable
    }
}
