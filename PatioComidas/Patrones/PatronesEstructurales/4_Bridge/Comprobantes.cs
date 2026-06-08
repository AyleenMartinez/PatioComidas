using System;

namespace PatioComidas.PatronesEstructurales
{
    // Implementación (Canal de Salida)
    public interface ICanalSalida
    {
        void EnviarContenido(string texto);
    }

    public class ImpresoraTermica : ICanalSalida
    {
        public void EnviarContenido(string texto) => Console.WriteLine($"[IMPRESIÓN TÉRMICA] {texto}");
    }

    public class CorreoDigital : ICanalSalida
    {
        public void EnviarContenido(string texto) => Console.WriteLine($"[CORREO ELECTRÓNICO] {texto}");
    }

    // Abstracción (Documentos)
    public abstract class DocumentoPatio
    {
        protected ICanalSalida _canal;

        protected DocumentoPatio(ICanalSalida canal)
        {
            _canal = canal;
        }

        public abstract void Procesar();
    }

    public class BoletaCliente : DocumentoPatio
    {
        public BoletaCliente(ICanalSalida canal) : base(canal) { }

        public override void Procesar()
        {
            _canal.EnviarContenido("Boleta de Venta - ¡Gracias por su compra en el Patio de Comidas!");
        }
    }

    public class OrdenCocina : DocumentoPatio
    {
        public OrdenCocina(ICanalSalida canal) : base(canal) { }

        public override void Procesar()
        {
            _canal.EnviarContenido("Orden #42 - Preparar menú de inmediato.");
        }
    }
}