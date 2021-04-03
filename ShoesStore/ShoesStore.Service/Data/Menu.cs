using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ShoesStore.Service.Data
{
    [Table("Menu")]
    public partial class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
