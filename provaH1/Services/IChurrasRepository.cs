using provaH1.Models;

namespace provaH1.Services
{
    public interface IChurrasRepository
    {
        void CriarParticipante(Participante participante);
        List<Participante> ListarParticipante();
    }
}
