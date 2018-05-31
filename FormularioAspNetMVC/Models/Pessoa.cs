using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormularioAspNetMVC.Models
{
    public class Pessoa
    {
        [Key]
        [Required(ErrorMessage = "Preencha o CPF.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo")]
        [MaxLength(100,ErrorMessage = "O nome deve ter até {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha a data de nascimento.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o sexo.")]
        public Sexo Sexo { get; set; }

        [Required(ErrorMessage = "Selecione um estado civil")]
        [Display(Name = "Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "Preencha o estado de residência.")]
        [RegularExpression("(AC|AL|AP|AM|BA|CE|DF|ES|GO|MA|MT|MS|MG|PA|PB|PR|PE|PI|RJ|RN|RS|RO|RR|SC|SP|SE|TO)",ErrorMessage =)]
        public string Estado { get; set; }

        [MaxLength(50, ErrorMessage = "O nome da cidade deve ter ate {1} caracteres")]
    }
}