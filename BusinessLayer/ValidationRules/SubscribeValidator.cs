using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SubscribeValidator : AbstractValidator<Subscribe>
    {
        public SubscribeValidator()
        {
            RuleFor(x => x.SubscribeMail).NotEmpty().WithMessage("Email can not be empty!");   
            RuleFor(x => x.SubscribeMail).MinimumLength(5).WithMessage("Email must be at least 5 characters");
            RuleFor(x => x.SubscribeMail).MaximumLength(30).WithMessage("Email can be maximum 30 characters");
        }
    }
}
