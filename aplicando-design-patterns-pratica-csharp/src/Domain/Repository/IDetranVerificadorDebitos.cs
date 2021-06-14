using System.Threading.Tasks;
using DesignPatternSamples.Application.DTO;


namespace DesignPatternSamples.Domain.Repository.Detran
{
    public interface IDetranVerificadorDebitos
    {
        Task<DebitoVeiculo> ConsultarDebitos(Veiculo veiculo);
    }
}
