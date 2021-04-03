using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ShoesStore.Service.Data
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        [Required]
        [StringLength(1000)]
        public string Detail { get; set; }
        public int? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int Status { get; set; }
        public float Price { get; set; }
    }
}
