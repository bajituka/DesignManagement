using System.ComponentModel.DataAnnotations;

namespace DesignManagement.Common.Enums
{
    public enum CoatingType
    {
        [Display(Name = "Настенные покрытия")]
        WallCoatings = 1,
        [Display(Name = "Напольные покрытия")]
        FloorCoatings = 2,
        [Display(Name = "Потолочные покрытия")]
        CeilingCoatings = 3
    }
}
