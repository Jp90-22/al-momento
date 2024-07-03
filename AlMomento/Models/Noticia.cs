﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AlMomento.Models
{
    public class Noticia
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(150)]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(500)]
        [Display(Name = "Sumario")]
        public string Sumario { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(400)]
        [Display(Name = "Lead")]
        public string Lead { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Column(TypeName = "ntext")]
        [Display(Name = "Cuerpo")]
        public string Cuerpo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(100)]
        [Display(Name = "Categoría")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Fecha de Publicación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Fecha de Redacción")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime FechaRedaccion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(250)]
        [Display(Name = "Autor")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(300)]
        [Display(Name = "E-mail del Autor")]
        [EmailAddress(ErrorMessage = "El email no es válido.")]
        public string AutorContacto { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(1000)]
        [Display(Name = "Url de la Portada")]
        [Url(ErrorMessage = "La URL no es válida.")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(200)]
        [Display(Name = "Pie de la Portada")]
        public string FotoPie { get; set; }

        [StringLength(1000)]
        [Display(Name = "Url del Video")]
        [Url(ErrorMessage = "La URL no es válida.")]
        public string Video { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(100)]
        [Display(Name = "Localidad")]
        public string Localidad { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Cantidad de Visitas")]
        public uint CantidadVisitas { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        [Display(Name = "Cantidad de Likes")]
        public uint CantidadLikes { get; set; }
    }
}
