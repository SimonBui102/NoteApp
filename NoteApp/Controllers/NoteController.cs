using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Dtos.Note;
using NoteApp.Models;
using NoteApp.Services.NoteService;
using System.Reflection;

namespace NoteApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
      

        public NoteController(INoteService noteService ) {
            _noteService = noteService;
        
        }
         
        [HttpGet("/GetAll")]
        public async Task<ActionResult<List<Note>>> GetAll()
        {

            return Ok( await _noteService.GetAllNote());

        }

        [HttpPost]
        
        public async Task<ActionResult<Guid>> AddNote(AddNoteDto newNote) {


          

            return Ok( await _noteService.AddNote(newNote));

        }
        



    }
}
