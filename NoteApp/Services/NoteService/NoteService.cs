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

        public async Task<Note> GetNoteById(Guid noteId) { 

            var note = await _context.Notes.FirstOrDefaultAsync( n => n.Id == noteId);


            return note;
            
        }

        public async Task<Guid> AddNote(AddNoteDto newNote) {

            var note = new Note() { Title = newNote.Title, Content = newNote.Content };

             _context.Add(note);

            await _context.SaveChangesAsync();

            return note.Id;
        
        
        }


        public async Task<Note> UpdateNote(UpdateNoteDto noteDto) { 
            
            var note =await _context.Notes.FirstOrDefaultAsync(n => n.Id == noteDto.Id);

            note.Title = noteDto.Title;
            note.Content = noteDto.Content;


            await _context.SaveChangesAsync();

            return note;
        
        
        }
        

        public async Task<Note> DeleteNote(Guid noteId) {

            var note = await _context.Notes.FirstOrDefaultAsync(n => n.Id == noteId);

            _context.Notes.Remove(note);

            await _context.SaveChangesAsync();




            return note;
        }


    }
}
