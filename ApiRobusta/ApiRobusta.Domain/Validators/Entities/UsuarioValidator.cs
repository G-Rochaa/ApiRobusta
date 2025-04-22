using ApiRobusta.Domain.Entities;
using FluentValidation;
using FluentValidation.Results;

namespace ApiRobusta.Domain.Validators.Entities
{
    public class UsuarioValidator: AbstractValidator<Usuario>
    {

        public string MensagemIdInvalido = "Id de Usuário Inválido!";
        public string MensagemNomeInvalido = "Nome de Usuário Inválido!";
        public string MensagemNomeMaximoCaracteres = "Informe no máximo 100 caracteres para o nome do usuário!";
        public string MensagemEmailInvalido = "Informe no máximo 100 caracteres para o Email do usuário!";
        public string MensagemEmailMaximoCaracteres = "Email inválido!";
        public string MensagemDataCadastroInvalido = "Data de cadastro inválida!";
        public string MensagemDataAtualizacaoInvalido = "Data de Atualização inválida!";


        public UsuarioValidator(Usuario usuario)
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage(MensagemIdInvalido);

            RuleFor(x => x.Nome)
               .NotEmpty().WithMessage(MensagemNomeInvalido)
               .MaximumLength(100).WithMessage(MensagemNomeMaximoCaracteres);

            RuleFor(x => x.Email)
               .NotEmpty().WithMessage(MensagemEmailInvalido)
               .MaximumLength(100).WithMessage(MensagemEmailMaximoCaracteres);

            RuleFor(x => x.DataCadastro)
                .NotEmpty().WithMessage(MensagemDataCadastroInvalido);

            RuleFor(x => x.DataAtualizacao)
                .NotEmpty().WithMessage(MensagemDataAtualizacaoInvalido);

            if (!usuario.Id.Equals(Guid.Empty))
            {
                RuleFor(x => x.DataAtualizacao)
                    .NotNull().WithMessage(MensagemDataAtualizacaoInvalido);
            }

            ValidationResult = Validate(usuario);
        }

        public ValidationResult ValidationResult { get; set; }
    }
}
