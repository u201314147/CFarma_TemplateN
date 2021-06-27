using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//#nullable disable

namespace CFarma_TemplateN.Models
{
    [Table("Producto")]
    public partial class Producto
    {
        public Producto()
        {
            
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int idpt { get; set; }
        [ForeignKey("codsubc")]
        public int CodSubc { get; set; } = 3;

        
        [Column("nom")]
        [Display (Name="Nombre")]
        public string Nom { get; set; }
        

        [Column("precio")]
        [Display(Name = "Precio")]
        public Decimal Precio { get; set; }

        
        [Column("stock")]
        [Display(Name = "Stock disponible")]
        public int Stock { get; set; }

     

       
    }
}
