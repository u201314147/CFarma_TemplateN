using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//#nullable disable

namespace CFarma_TemplateN.Models
{
    [Table("Carrito")]
    public partial class Carrito
    {
        public Carrito()
        {
            
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int id { get; set; }

        [Column("id_cliente")]
        [Display (Name= "id_cliente")]
        public string id_cliente { get; set; }
        

        [Column("id_producto")]
        [Display(Name = "id_producto")]
        public string id_producto { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Column("cantidad")]
        [Display(Name = "cantidad")]
        public int cantidad { get; set; }

        [Column("identificador")]
        [Display(Name = "identificador")]
        public string identificador { get; set; }


       
    }
}
