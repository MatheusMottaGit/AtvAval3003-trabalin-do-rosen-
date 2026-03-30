using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtvAval3003.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }

        public int ProjetoId { get; set; }
        public Projeto Projeto { get; set; }

        public Aluno() { }

        public ICollection<AvaliacaoIndividual> AvaliacoesIndividuais { get; set; }

        public Aluno(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}