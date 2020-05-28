using System.ComponentModel.DataAnnotations;

namespace DesignManagement.Common.Enums
{
    public enum OutfitType
    {
        [Display(Name = "Лицевые отделочные материалы")]
        FinishCoatings = 1,
        [Display(Name = "Электрика")]
        Electrics = 2,
        [Display(Name = "Сантехника")]
        SatinaryFitments = 3,
        [Display(Name = "Столярные изделия")]
        CustomFurniture = 4,
        [Display(Name = "Мебель из салона")]
        ReadyFurniture = 5,
        [Display(Name = "Прочие заказные изделия")]
        CustomOther = 6,
        [Display(Name = "Декор")]
        Decorations = 7,
        [Display(Name = "Техника")]
        TechnicalEquipment = 8,
    }
}
