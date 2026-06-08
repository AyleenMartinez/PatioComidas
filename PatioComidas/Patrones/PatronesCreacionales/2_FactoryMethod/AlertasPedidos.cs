using System;

namespace PatioComidas.PatronesCreacionales
{
    // --- Interfaz y Productos Concretos ---
    public interface INotificadorPedido
    {
        void NotificarListo(int numeroPedido);
    }

    public class NotificadorBuzzer : INotificadorPedido
    {
        public void NotificarListo(int numeroPedido) => Console.WriteLine($"[BUZZER] BZZZ! Pedido {numeroPedido} listo en mostrador.");
    }

    public class NotificadorSMS : INotificadorPedido
    {
        public void NotificarListo(int numeroPedido) => Console.WriteLine($"[SMS] Tu pedido {numeroPedido} está listo para llevar.");
    }

    // --- Creador Abstracto y Creadores Concretos ---
    public abstract class DespachadorPedidos
    {
        protected abstract INotificadorPedido CrearNotificador();

        public void FinalizarPedido(int numeroPedido)
        {
            var notificador = CrearNotificador();
            notificador.NotificarListo(numeroPedido);
        }
    }

    public class DespachadorLocal : DespachadorPedidos
    {
        protected override INotificadorPedido CrearNotificador() => new NotificadorBuzzer();
    }

    public class DespachadorParaLlevar : DespachadorPedidos
    {
        protected override INotificadorPedido CrearNotificador() => new NotificadorSMS();
    }
}