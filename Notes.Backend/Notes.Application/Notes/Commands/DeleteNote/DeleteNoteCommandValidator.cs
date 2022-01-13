﻿using FluentValidation;
using System;

namespace Notes.Application.Notes.Commands.CreateNote
{
    public class DeleteNoteCommandValidator : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidator()
        {
            RuleFor(deleteNoteCommand => deleteNoteCommand.UserId)
                .NotEqual(Guid.Empty);
            RuleFor(deleteNoteCommand => deleteNoteCommand.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
