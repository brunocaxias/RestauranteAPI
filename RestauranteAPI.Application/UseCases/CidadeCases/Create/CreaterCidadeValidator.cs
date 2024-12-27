using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteAPI.Application.UseCases.CidadeCases.Create
{
    public class CreaterCidadeValidator : AbstractValidator<CreateCidadeCommand>
    {
        public CreaterCidadeValidator()
        {
            RuleFor(x => x.Nome)
                .Must(Nome => !string.IsNullOrEmpty(Nome)).WithMessage("O Nome da Cidade não pode ser nulo ou vazio");
        }
    }
}
