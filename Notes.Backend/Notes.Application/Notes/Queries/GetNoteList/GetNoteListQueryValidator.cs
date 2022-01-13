using FluentValidation;
using Notes.Application.Notes.Queries.GetNoteDetails;
using System;

namespace Notes.Application.Notes.Commands.CreateNote
{
    public class GetNoteListQueryValidator : AbstractValidator<GetNoteListQuery>
    {
        public GetNoteListQueryValidator()
        {
            RuleFor(getNoteListQuery => getNoteListQuery.UserId)
                .NotEqual(Guid.Empty);
        }
    }
}
