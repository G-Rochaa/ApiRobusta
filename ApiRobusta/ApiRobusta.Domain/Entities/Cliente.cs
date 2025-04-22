namespace ApiRobusta.Domain.Entities
{
    public class Cliente
    {
        #region Public Constructor

        public Cliente(string nome, string email, string celular, Guid usuarioCadastroId)
        {
            Nome = nome;
            Email = email;
            Celular = celular;
            UsuarioCadastroId = usuarioCadastroId;
            DataCadastro = DateTime.UtcNow;
            Ativo = true;
        }
        #endregion Public Constructor

        #region Public Properties
        public Guid Id { get; private set; }
        public string Nome { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Celular { get; private set; } = string.Empty;
        public Guid UsuarioCadastroId { get;}
        public DateTime DataCadastro { get;}
        public DateTime DataAtualizacao { get; private set;}
        public Guid UsuarioAtualizacaoId { get; private set; }
        public bool Ativo { get; set; }

        #endregion Public Properties

    }
}
