using System.Linq.Expressions;
using System.Net.Mail;

namespace Pegaqui.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        
        public string Email { get => email; set => email = value; }

        private string email;

        public string Nome { get => nome; set => email = value; }

        private string nome;

        public string Senha { get => senha; set => senha = value; }

        private string senha;

        //public string Genero { get => genero; set => genero = value; }
        //private string? genero;

        public Usuario(string email, string nome, string senha)
        {
            this.email = email;
            this.nome = nome;
            this.senha = senha;
        }
    }
}
