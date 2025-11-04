using Microsoft.EntityFrameworkCore;
using NoteApp.Data;
using NoteApp.Dtos.Note;
using NoteApp.Models;

namespace NoteApp.Services.NoteService
{
    public class NoteService : INoteService
    {

        private readonly DataContext _context;

        public NoteService(DataContext context) { 
            _context = context;
        }

        public async Task<List<Note>> GetAllNote() {


            var allNotes = await _context.Notes.ToListAsync();

            return allNotes;

        
        }

        public async Task<Guid> AddNote(AddNoteDto newNote) {

            var note = new Note() { Title = newNote.Title, Content = newNote.Content };

             _context.Add(new Note() { Title = newNote.Title, Content = newNote.Content });

            await _context.SaveChangesAsync();

            return note.Id;
        
        
        }


    }
}
