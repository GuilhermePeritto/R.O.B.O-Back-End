using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public interface IBracoService
    {
        Braco GetBraco(EnumLadoBraco lado);
        bool UpdateCotovelo(EnumLadoBraco lado, EnumEstadoCotovelo estado);
        bool UpdatePulso(EnumLadoBraco lado, EnumEstadoPulso estado);
    }
}
