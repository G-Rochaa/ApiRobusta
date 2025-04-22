namespace ApiRobusta.Domain.Entities
{
    public class Usuario
    {
        #region Protected Constructor

        protected Usuario()
        {   
        }

        #endregion Protected Constructor

        #region Public Constructor
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            DataCadastro = DateTime.UtcNow;
        }

        #endregion Public Constructor

        #region Public properties

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataAtualizacao { get; private set; }

        #endregion Public properties

        # region Public methods

        public virtual void Atualizar(string nome, string email)
        {
            Nome = nome;
            Email = email;
            DataAtualizacao = DateTime.UtcNow;
        }

        #endregion Public methods
    }
}
