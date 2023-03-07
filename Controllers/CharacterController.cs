using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>(){
            new Character(),
            new Character{Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get() => Ok(characters);
        [HttpGet]
        public ActionResult<Character> GetSingle() => Ok(characters[0]);
    }
}