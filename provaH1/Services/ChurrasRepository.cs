using provaH1.Models;

namespace provaH1.Services
{
    public class ChurrasRepository : IChurrasRepository
    {

        private static List<Participante> listaParticipanteChurrasco = [];

        public void CriarParticipante(Participante participante)
        {
            listaParticipanteChurrasco.Add(participante);
        }

        public List<Participante> ListarParticipante()
        {
            return listaParticipanteChurrasco;
        }
    }
}
