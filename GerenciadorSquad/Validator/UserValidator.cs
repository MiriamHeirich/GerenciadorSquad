using FluentValidation;
using GerenciadorSquad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorSquad.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).NotNull().WithMessage("Email não pode ser nulo");
            //RuleFor(user => user.UserName).NotNull().WithMessage("Nome não pode ser Nulo");
            RuleFor(user => user.PWD).NotNull().WithMessage("Digite a senha");
        }
        
    }
}
