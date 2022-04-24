using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator:AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Name and Surname can not be empty!");
            RuleFor(x => x.CommentContent).NotEmpty().WithMessage("Comment content can not be empty!");
            RuleFor(x => x.CommentContent).MinimumLength(5).WithMessage("Comment content must be at least 5 characters");
            RuleFor(x => x.NameSurname).MaximumLength(30).WithMessage("Name and surname can be maximum 30 characters");
            RuleFor(x => x.CommentContent).MaximumLength(250).WithMessage("Comment content can be maximum 250 character");
        }
    }
}
