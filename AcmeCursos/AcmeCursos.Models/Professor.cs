using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AcmeCursos.Models
{
    [Table("Professor")]
    public class Professor
    {
        public int Id { get; set; }

        [Display(Name = "Primeiro Nome")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Último Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Sobrenome { get; set; }

        [Display(Name = "Titulação")]
        [StringLength(50, MinimumLength = 0)]
        public string Titulacao { get; set; }

        [Display(Name = "Cursos")]
        [UIHint("_Cursos")]
        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
