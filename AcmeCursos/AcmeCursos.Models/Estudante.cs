using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcmeCursos.Models
{
    [Table("Estudante")]
    public class Estudante
    {
        public int Id { get; set; }

        [Display(Name = "Primeiro Nome")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Último Nome")]
        [StringLength(50, MinimumLength = 3)]
        public string Sobrenome { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Matrícula")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataMatricula { get; set; }

        [Display(Name = "Inscrições")]
        [UIHint("_Inscricoes")]
        public virtual ICollection<Inscricao> Inscricoes { get; set; }
    }
}