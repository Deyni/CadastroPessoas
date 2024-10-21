using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroPessoas.Server.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome completo é obrigatório.")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "Data de nascimento é obrigatória.")]
        public DateTime DataNascimento { get; set; } = DateTime.MinValue;

        [Required(ErrorMessage = "CPF é obrigatório.")]
        public string CPF { get; set; } = string.Empty;

        public string Rua { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; } = string.Empty;
    }
}
