using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public class BracoService : IBracoService
    {
        private readonly Dictionary<EnumLadoBraco, Braco> _bracos = new Dictionary<EnumLadoBraco, Braco>
        {
            { EnumLadoBraco.Esquerdo, new Braco() },
            { EnumLadoBraco.Direito, new Braco() }
        };

        public Braco GetBraco(EnumLadoBraco lado)
        {
            if (_bracos.ContainsKey(lado))
            {
                return _bracos[lado];
            }
            else
            {
                return null;
            }
        }

        public bool UpdateCotovelo(EnumLadoBraco lado, EnumEstadoCotovelo estado)
        {
            if (_bracos.ContainsKey(lado))
            {
                _bracos[lado].EstadoCotovelo = estado;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdatePulso(EnumLadoBraco lado, EnumEstadoPulso estado)
        {
            if (_bracos.ContainsKey(lado))
            {
                _bracos[lado].EstadoPulso = estado;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
