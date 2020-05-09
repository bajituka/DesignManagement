using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignManagement.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignManagement.Models
{
    public class Dictionary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DictionaryType DictionaryType { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
    }
}
