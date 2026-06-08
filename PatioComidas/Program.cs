using System;
using PatioComidas.PatronesCreacionales;
using PatioComidas.PatronesEstructurales;

// Paso 6: Orquestar el Sistema

// 1. Abrir Caja (Singleton)
var caja = CajaCentral.ObtenerInstancia();
caja.IngresosTotales += 50000m;
Console.WriteLine($"Caja abierta. Fondo inicial: ${caja.IngresosTotales}");

// 2. Pedido (Abstract Factory)
Console.WriteLine("\n--- Procesando Pedido Americano ---");
IFranquiciaComida franquicia = new FranquiciaAmericana();
IPlatoPrincipal plato = franquicia.PrepararPlato();
IBebestible bebida = franquicia.PrepararBebida();
plato.Servir();
bebida.Servir();

// 3. Pago y Boleta (Bridge)
caja.IngresosTotales += 15000m;
Console.WriteLine($"\nCobro realizado. Ingresos totales de la caja: ${caja.IngresosTotales}");
ICanalSalida canalImpresion = new ImpresoraTermica();
DocumentoPatio boleta = new BoletaCliente(canalImpresion);
boleta.Procesar();

// 4. Bebida (Adapter)
Console.WriteLine("\n--- Sirviendo Bebida en Máquina ---");
IDispensadorModerno dispensador = new AdaptadorDispensador();
dispensador.ServirBebida();

// 5. Aviso (Factory Method)
Console.WriteLine("\n--- Finalizando Pedido ---");
DespachadorPedidos despachador = new DespachadorLocal();
despachador.FinalizarPedido(42);

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();