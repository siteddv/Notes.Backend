using FluentValidation;
using System;

namespace Notes.Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommandValidator : AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteCommandValidator()
        {
            RuleFor(createNoteCommand => createNoteCommand.Title)
                .NotEmpty()
                .MaximumLength(256);
            RuleFor(createNoteCommand => createNoteCommand.UserId)
                .NotEqual(Guid.Empty);
        }
    }
}
