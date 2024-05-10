using Domain.Enums;

namespace Domain.Entities
{
    public class Braco
    {
        public EnumEstadoCotovelo EstadoCotovelo { get; set; } = EnumEstadoCotovelo.EmRepouso;
        public EnumEstadoPulso EstadoPulso { get; set; } = EnumEstadoPulso.EmRepouso;
    }
}
