using ApiRobusta.Domain.Entities;
using FluentValidation;
using FluentValidation.Results;

namespace ApiRobusta.Domain.Validators.Entities
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public string MensagemIdInvalido = "Id de Usuário Inválido!";
        public string MensagemNomeInvalido = "Nome de cliente Inválido!";
        public string MensagemNomeMaximoCaracteres = "Informe no máximo 100 caracteres para o nome do cliente!";
        public string MensagemEmailInvalido = "Informe no máximo 100 caracteres para o Email do cliente!";
        public string MensagemEmailMaximoCaracteres = "Email inválido!";
        public string MensagemDataCadastroInvalido = "Data de cadastro inválida!";
        public string MensagemDataAtualizacaoInvalido = "Data de Atualização inválida!";
        public string MensagemUsuarioAtualizacaoInvalido = "Id de Usuário Inválido!";
        private string MensagemCelularMaximoCaracteres = "Informe no máximo 11 cáracteres";

        public ClienteValidator(Cliente cliente) 
        {
            RuleFor(x => x.Id)
               .NotEmpty().WithMessage(MensagemIdInvalido);

            RuleFor(x => x.Nome)
               .MaximumLength(11).WithMessage(MensagemCelularMaximoCaracteres);
            
            RuleFor(x => x.Celular)
               .NotEmpty().WithMessage(MensagemNomeInvalido)
               .MaximumLength(100).WithMessage(MensagemNomeMaximoCaracteres);

            RuleFor(x => x.Email)
               .NotEmpty().WithMessage(MensagemEmailInvalido)
               .MaximumLength(100).WithMessage(MensagemEmailMaximoCaracteres);

            RuleFor(x => x.DataCadastro)
                .NotEmpty().WithMessage(MensagemDataCadastroInvalido);

            RuleFor(x => x.DataAtualizacao)
                .NotEmpty().WithMessage(MensagemDataAtualizacaoInvalido);

            if (!cliente.Id.Equals(Guid.Empty))
            {
                RuleFor(x => x.DataAtualizacao)
                    .NotNull().WithMessage(MensagemDataAtualizacaoInvalido);

                RuleFor(x => x.UsuarioAtualizacaoId)
                   .NotNull().WithMessage(MensagemUsuarioAtualizacaoInvalido);
            }

            ValidationResult = Validate(cliente);

        }

        public ValidationResult ValidationResult { get; set; }
    }
}
