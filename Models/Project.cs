using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DesignManagement.Common.Enums;

namespace DesignManagement.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Заполните поле Название")]
        [StringLength(256, ErrorMessage = "Слишком длинное название")]
        public string Name { get; set; }

        [DataType(DataType.Date), Range(typeof(DateTime), "1/1/1991", "1/1/2100")]
        public DateTime DesignStartDate { get; set; } = DateTime.Today;

        [DataType(DataType.Date), Range(typeof(DateTime), "1/1/1991", "1/1/2100")]
        public DateTime DesignEndDate { get; set; } = DateTime.Today.AddMonths(2);

        [DataType(DataType.Date), Range(typeof(DateTime), "1/1/1991", "1/1/2100")]
        public DateTime ConstructionStartDate { get; set; } = DateTime.Today.AddMonths(3);

        [DataType(DataType.Date), Range(typeof(DateTime), "1/1/1991", "1/1/2100")]
        public DateTime ConstructionEndDate { get; set; } = DateTime.Today.AddMonths(9);
        [Required(ErrorMessage = "Выберите тип недвижимости")]
        public RealEstateType RealEstateType { get; set; } = RealEstateType.Condo;
        
        [Range(1, 9999.99)]
        [Column(TypeName = "decimal(6,2)")]
        public decimal? Area { get; set; }

        [Range(1, 99999999), DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Price { get; set; }
        public int? Client { get; set; }
        public bool HasDesignSupervision { get; set; } = false;
    }
}