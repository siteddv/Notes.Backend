using MediatR;
using Notes.Application.Notes.Queries.GetNoteList;
using System;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class GetNoteListQuery : IRequest<NoteListVm>
    {
        public Guid UserId { get; set; }
    }
}
