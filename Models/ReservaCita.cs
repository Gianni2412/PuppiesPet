using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PuppiesPet.Models
{

    [Table("t_reservar")]
    public class ReservaCita
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }


        [Display(Name = "Hora")]
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        public int celular { get; set; }


        public Doctor Doctor { get; set; }

        public int DoctorId { get; set; }

        public Servicio servicio { get; set; }

        public int ServicioId { get; set; }


        public string NombreMascota { get; set; }

        public string RazaMascota { get; set; }

        public string NombreReservar { get; set; }

        public string ApellidoReservar { get; set; }

        public string CorreoReservar { get; set; }










    }
}