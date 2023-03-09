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
            RuleFor(user => user.Email).NotNull();
            RuleFor(user => user.UserName).NotNull();
            //RuleFor(user => user.PWD).NotNull();
        }
        
    }
}
