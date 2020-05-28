using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DesignManagement.Models
{
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Contact Contact { get; set; }

        [Required]
        public OutfitItem OutfitItem { get; set; }

        [Required(ErrorMessage = "Укажите стоимость за единицу")]
        [Range(1, 99999999), DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal PricePerUnit { get; set; }

#nullable enable
        [StringLength(128, ErrorMessage = "Слишком длинный адрес")]
        public string? Address { get; set; }

        public Contact? ContactPerson { get; set; }

        public string? Link { get; set; }

        public string? Materials { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(4,2)")]
        public decimal? Discount { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? DeliveryPrice { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? InstallationPrice { get; set; }

        [StringLength(128, ErrorMessage = "Слишком длинное название")]
        public string? DeliveryTerm { get; set; }
#nullable disable
    }
}
