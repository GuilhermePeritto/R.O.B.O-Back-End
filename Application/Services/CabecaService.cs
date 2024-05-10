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
            _cabeca.EstadoRotacao = estado;
            return true;
        }

        public bool UpdateInclinacao(EnumEstadoInclinacaoCabeca estado)
        {
            _cabeca.EstadoInclinacao = estado;
            return true;
        }
    }
}
