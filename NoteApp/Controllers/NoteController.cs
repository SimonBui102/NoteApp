using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Models;

namespace NoteApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly List<Note> _notes;

        public NoteController() {
            _notes = new List<Note>()
            {
                new Note() { Title = "firs Note", Content = "first Content" },
                new Note() { Title = "Second Title", Content = " Second Content" }
            };
            _notes.Add(new Note() { Title = "Third Title", Content = "Third Content" });
        
        }
         
        [HttpGet("/GetAll")]
        public ActionResult<List<Note>> GetAll()
        {

            return Ok(this._notes);

        }
    }
}
