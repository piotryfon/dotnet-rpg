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
        public async Task<ActionResult<List<Character>>> Get() => 
            Ok(await _characterService.GetAllCharacters());

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetSingle(int id) => 
            Ok(await _characterService.GetCharacterById(id));

        [HttpPut]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
            return Ok( await _characterService.AddCharacter(newCharacter));
        }
    }
}