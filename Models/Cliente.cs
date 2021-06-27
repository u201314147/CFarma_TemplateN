﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CFarma_TemplateN.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int codc { get; set; }
        [ForeignKey("idtip")]
        public int Idtip { get; set; } = 3;

        [Required(ErrorMessage ="Debe escribir el nombre")]
        [Column("nom")]
        [Display (Name="Nombre")]
        public string Nom { get; set; }
        

        [Required(ErrorMessage = "Debe escribir los apellidos")]
        [Column("apellido")]
        [Display(Name = "Apellidos")]
        public string Apellido { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Column("nrodoc")]
        [Display(Name = "Número de identidad")]
        public int Nrodoc { get; set; }

        [Column("sexo")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Column("correo")]
        [Display(Name = "Correo electrónico")]
        public string Correo { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Column("movil")]
        [Display(Name = "Teléfono móvil")]
        public int Movil { get; set; }

        [Display(Name = "Contraseña")]
        [Column("pswd")]
        public string Pswd { get; set; }

       
    }
}
