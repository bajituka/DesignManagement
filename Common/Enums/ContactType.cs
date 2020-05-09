using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignManagement.Common.Enums
{
    public enum ContactType
    {
        [Display(Name = "Заказчик")]
        Client = 1,
        [Display(Name = "Строитель")]
        Builder = 2,
        [Display(Name = "Дизайнер")]
        Designer = 3,
        [Display(Name = "Мебельщик")]
        FurnitureMaker = 4
    }
}
