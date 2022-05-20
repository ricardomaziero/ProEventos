using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Persistence.Contratos
{
    public interface ILotePersist
    {
        /// <summary>
        /// método get que retornará uma lista de lotes por eventoId.
        /// </summary>
        /// <param name="eventoId">Código chave da tabela evento</param>
        /// <returns>Array de Lotes</returns>
         Task<Lote[]> GetLotesByEventoIdAsync(int eventoId);

         /// <summary>
         /// Método get que retornará apenas 1 lote
         /// </summary>
         /// <param name="eventoId">código chave da tabela Evento</param>
         /// <param name="id">código chave da tabela lote</param>
         /// <returns>Apenas 1 lote</returns>
         Task<Lote> GetLoteByIdsAsync(int eventoId, int id);
    }
}