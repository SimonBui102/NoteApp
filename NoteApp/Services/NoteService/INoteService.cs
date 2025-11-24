using NoteApp.Dtos.Note;
using NoteApp.Models;

namespace NoteApp.Services.NoteService
{
    public interface INoteService
    {

        Task<List<Note>> GetAllNote();
        Task<Note> GetNoteById(Guid noteId);
        Task<Guid> AddNote(AddNoteDto newNote);

        Task<Note> UpdateNote(UpdateNoteDto noteDto);

        Task<Note> DeleteNote(Guid noteId);
    }
}
