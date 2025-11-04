using NoteApp.Dtos.Note;
using NoteApp.Models;

namespace NoteApp.Services.NoteService
{
    public interface INoteService
    {

        Task<List<Note>> GetAllNote();
       // Task<Note> GetNoteById(Guid id);
        Task<Guid> AddNote(AddNoteDto newNote);

       // Task<Note> DeleteNote(Guid id);
    }
}
