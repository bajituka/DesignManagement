using System.ComponentModel.DataAnnotations;

namespace DesignManagement.Common.Enums
{
    public enum RealEstateType
    {
        [Display(Name = "Квартира")]
        Condo = 1,
        [Display(Name = "Дом")]
        House = 2,
        [Display(Name = "Комната")]
        Room = 3,
        [Display(Name = "Коммерческое помещение")]
        Commercial = 4
    }
}
