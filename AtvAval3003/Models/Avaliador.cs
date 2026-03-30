using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AtvAval3003.Models
{
    public class Avaliador
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

        public ICollection<AvaliacaoIndividual> AvaliacoesIndividuais { get; set; }

        public Avaliador()
        {
            AvaliacoesIndividuais = new List<AvaliacaoIndividual>();
        }

        public Avaliador(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            AvaliacoesIndividuais = new List<AvaliacaoIndividual>();
        }
    }
}