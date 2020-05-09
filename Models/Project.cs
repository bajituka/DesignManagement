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
        public DateTime DesignStartDate { get; set; } = DateTime.Today;
        public DateTime DesignEndDate { get; set; } = DateTime.Today.AddMonths(2);
        public DateTime ConstructionStartDate { get; set; } = DateTime.Today.AddMonths(3);
        public DateTime ConstructionEndDate { get; set; } = DateTime.Today.AddMonths(9);
        [Required(ErrorMessage = "Выберите тип недвижимости")]
        public RealEstateType RealEstateType { get; set; } = RealEstateType.Condo;
        [Column(TypeName = "decimal(4,2)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal? Price { get; set; }
        public int? Client { get; set; }
        public bool HasDesignSupervision { get; set; } = false;
    }
}