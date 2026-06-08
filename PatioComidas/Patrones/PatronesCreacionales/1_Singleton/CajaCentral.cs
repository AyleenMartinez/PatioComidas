using System;

namespace PatioComidas.PatronesCreacionales
{
    public sealed class CajaCentral
    {
        private static CajaCentral _instancia;
        private static readonly object _lock = new object();

        public decimal IngresosTotales { get; set; }

        private CajaCentral() { }

        public static CajaCentral ObtenerInstancia()
        {
            lock (_lock)
            {
                if (_instancia == null)
                {
                    _instancia = new CajaCentral();
                }
                return _instancia;
            }
        }
    }
}