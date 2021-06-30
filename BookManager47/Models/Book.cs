namespace BookManager47.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="khong duoc de trong")]
        public int ID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "khong duoc de trong")]
        public string Title { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "khong duoc de trong")]
        public string Description { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "khong duoc de trong")]
        public string Author { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "khong duoc de trong")]
        public string Images { get; set; }

        [Required(ErrorMessage = "khong duoc de trong")]
        public int? Price { get; set; }
    }
}
