using Domain.Enums;

namespace Domain.Entities
{
    public class Cabeca
    {
        public EnumEstadoRotacaoCabeca EstadoRotacao { get; set; } = EnumEstadoRotacaoCabeca.EmRepouso;
        public EnumEstadoInclinacaoCabeca EstadoInclinacao { get; set; } = EnumEstadoInclinacaoCabeca.EmRepouso;
    }
}
