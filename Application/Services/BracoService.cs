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
                var braço = _bracos[lado];
                if (estado >= braço.EstadoCotovelo - 1 && estado <= braço.EstadoCotovelo + 1)
                {
                    if (estado == EnumEstadoCotovelo.FortementeContraido && braço.EstadoPulso != EnumEstadoPulso.EmRepouso)
                    {
                        return false;
                    }
                    braço.EstadoCotovelo = estado;
                    return true;
                }
                else
                {
                    return false;
                }
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
                var braço = _bracos[lado];
                if (estado >= braço.EstadoPulso - 1 && estado <= braço.EstadoPulso + 1)
                {
                    if (estado == EnumEstadoPulso.EmRepouso || braço.EstadoCotovelo == EnumEstadoCotovelo.FortementeContraido)
                    {
                        braço.EstadoPulso = estado;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
