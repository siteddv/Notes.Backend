﻿using MediatR;
using System;

namespace Notes.Application.Notes.Commands
{
    public class DeleteNoteCommand : IRequest
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
