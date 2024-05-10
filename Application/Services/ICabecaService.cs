using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public interface ICabecaService
    {
        Cabeca GetCabeca();
        bool UpdateRotacao(EnumEstadoRotacaoCabeca estado);
        bool UpdateInclinacao(EnumEstadoInclinacaoCabeca estado);
    }
}
