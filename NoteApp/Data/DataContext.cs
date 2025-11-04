using Microsoft.EntityFrameworkCore;
using NoteApp.Models;

namespace NoteApp.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { 
        
        }


        public DbSet<Note> Notes { get; set; }
    }
}
