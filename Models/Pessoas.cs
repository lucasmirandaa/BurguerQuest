using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BurguerQuest.Models
{
    [Table("Pessoas")]
    public class Pessoas
    {
        [Key]
        public int Cpf { get; set; }
        [Required(ErrorMessage ="Obrigatório informar o nome!")]
        [Display(Name = "CPF")]
        public int Nome { get; set; }
        [Required(ErrorMessage ="Obrigatório informar um e-mail para contato!")]
        [Display(Name ="NOME")]
        public int Email { get; set; }
        [Required(ErrorMessage ="Obrigatório informar um telefone para contato!")]
        [Display(Name ="E-MAIL")]
        public int Telefone { get; set; }
    
    }
}
