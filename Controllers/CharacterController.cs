using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }
     
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get() => Ok(_characterService.GetAllCharacters());

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id) => Ok(_characterService.GetCharacterById(id));

        [HttpPut]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            return Ok( _characterService.AddCharacter(newCharacter));
        }
    }
}