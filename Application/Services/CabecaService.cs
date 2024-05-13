using Domain.Entities;
using Domain.Enums;

namespace Application.Services
{
    public class CabecaService : ICabecaService
    {
        private readonly Cabeca _cabeca = new Cabeca();

        public Cabeca GetCabeca()
        {
            return _cabeca;
        }

        public bool UpdateRotacao(EnumEstadoRotacaoCabeca estado)
        {
            if (_cabeca.EstadoInclinacao != EnumEstadoInclinacaoCabeca.ParaBaixo)
            {
                if (estado >= _cabeca.EstadoRotacao - 1 && estado <= _cabeca.EstadoRotacao + 1)
                {

                    _cabeca.EstadoRotacao = estado;
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

        public bool UpdateInclinacao(EnumEstadoInclinacaoCabeca estado)
        {
            if (estado >= _cabeca.EstadoInclinacao - 1 && estado <= _cabeca.EstadoInclinacao + 1)
            {
                _cabeca.EstadoInclinacao = estado;
                return true;
            }
            else
            {
                return false; // Estado não permitido
            }
        }
    }
}
