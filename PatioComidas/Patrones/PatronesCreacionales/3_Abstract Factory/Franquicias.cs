using System;

namespace PatioComidas.PatronesCreacionales
{
    // --- Interfaces de Productos ---
    public interface IPlatoPrincipal { void Servir(); }
    public interface IBebestible { void Servir(); }

    // --- Productos Concretos ---
    public class Pizza : IPlatoPrincipal { public void Servir() => Console.WriteLine("Sirviendo Pizza italiana."); }
    public class Expresso : IBebestible { public void Servir() => Console.WriteLine("Sirviendo café Expresso."); }

    public class Hamburguesa : IPlatoPrincipal { public void Servir() => Console.WriteLine("Sirviendo Hamburguesa americana."); }
    public class Malteada : IBebestible { public void Servir() => Console.WriteLine("Sirviendo Malteada."); }

    // --- Fábrica Abstracta y Fábricas Concretas ---
    public interface IFranquiciaComida
    {
        IPlatoPrincipal PrepararPlato();
        IBebestible PrepararBebida();
    }

    public class FranquiciaItaliana : IFranquiciaComida
    {
        public IPlatoPrincipal PrepararPlato() => new Pizza();
        public IBebestible PrepararBebida() => new Expresso();
    }

    public class FranquiciaAmericana : IFranquiciaComida
    {
        public IPlatoPrincipal PrepararPlato() => new Hamburguesa();
        public IBebestible PrepararBebida() => new Malteada();
    }
}