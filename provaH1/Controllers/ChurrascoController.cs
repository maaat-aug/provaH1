using Microsoft.AspNetCore.Mvc;
using provaH1.Models;
using provaH1.Services;

namespace provaH1.Controllers
{
    [Route("\"api/[controller]\"")]
    [ApiController]
    public class ChurrascoController : ControllerBase
    {
        private readonly IChurrasRepository _churrasRepository;

      
        public ChurrascoController(IChurrasRepository churrasRespository)
        {
            _churrasRepository = churrasRespository;
        }

        [HttpPost]
        public IActionResult CadastrarMembros(Participante participante)
        {
            _churrasRepository.CriarParticipante(participante);
            return Ok("Participante criado com sucesso");
        }

        [HttpGet]
        public IActionResult ListarParticipantes()
        {
            var participantes = _churrasRepository.ListarParticipante();
            return Ok(participantes);
        }

    
    }
}
