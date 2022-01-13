using FluentValidation;
using Notes.Application.Notes.Queries.GetNoteDetails;
using System;

namespace Notes.Application.Notes.Commands.CreateNote
{
    public class GetNoteDetailsQueryValidator : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidator()
        {
            RuleFor(getNoteDetailsQuery => getNoteDetailsQuery.UserId)
                .NotEqual(Guid.Empty);
            RuleFor(getNoteDetailsQuery => getNoteDetailsQuery.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
