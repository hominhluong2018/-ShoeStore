using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ShoesStore.Service.Data
{
    [Table("Silder")]
    public partial class Silder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
