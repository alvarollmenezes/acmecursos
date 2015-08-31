using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcmeCursos.Models
{
    [Table("Curso")]
    public class Curso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Nome { get; set; }

        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Data Limite para Inscrição")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataLimiteInscricao { get; set; }

        public virtual ICollection<Inscricao> Inscricoes { get; set; }

        [Display(Name = "Professores")]
        [UIHint("_Professores")]
        public virtual ICollection<Professor> Professores { get; set; }
    }
}