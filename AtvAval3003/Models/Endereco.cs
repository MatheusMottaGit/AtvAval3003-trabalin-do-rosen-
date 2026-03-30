using System;
using System.ComponentModel.DataAnnotations;

namespace AtvAval3003.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Logradouro { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Número deve ser maior que zero")]
        public int Numero { get; set; }

        [MaxLength(100)]
        public string Complemento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "UF deve ter 2 caracteres")]
        public string Uf { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}-?\d{3}$", ErrorMessage = "CEP inválido")]
        public string Cep { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        public Endereco() { }

        public Endereco(string logradouro, int numero, string bairro, string cidade, string uf, string cep, string complemento = "")
        {
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
            Complemento = complemento;
        }
    }
}