using System;

namespace PatioComidas.PatronesEstructurales
{
    // --- Clase Incompatible (Antigua) ---
    public class DispensadorAntiguo
    {
        public void AccionarValvulaMecanica() => Console.WriteLine("CLACK! Válvula mecánica accionada. Bebida sirviéndose (Sistema Antiguo).");
    }

    // --- Interfaz Esperada (Moderna) ---
    public interface IDispensadorModerno
    {
        void ServirBebida();
    }

    // --- Adaptador ---
    public class AdaptadorDispensador : IDispensadorModerno
    {
        private readonly DispensadorAntiguo _dispensadorAntiguo;

        public AdaptadorDispensador()
        {
            _dispensadorAntiguo = new DispensadorAntiguo();
        }

        public void ServirBebida()
        {
            // Traduce la llamada moderna a la antigua
            _dispensadorAntiguo.AccionarValvulaMecanica();
        }
    }
}