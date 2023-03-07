using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character{Id = 1, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get() => Ok(characters);

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id) => Ok(characters.FirstOrDefault(c => c.Id == id));

        [HttpPut]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}