using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fase 01" + Environment.NewLine);

            Producto objProducto = new Producto("Producto A", "Descripcion del producto A.", 10, .25, .21, "Acme", "Categoria A", "Subcategoria A");

            Console.WriteLine("Producto" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objProducto.Nombre);
            Console.WriteLine("Descripción: {0}", objProducto.Descripcion);
            Console.WriteLine("Precio de costo: {0}", objProducto.PrecioCosto.ToString("c"));
            Console.WriteLine("Margen: {0}", objProducto.Margen.ToString("p"));
            Console.WriteLine("I.V.A.: {0}", objProducto.IVA.ToString("p"));
            Console.WriteLine("Precio bruto: {0}", objProducto.PrecioBruto.ToString("c"));
            Console.WriteLine("Precio venta: {0}", objProducto.PrecioVenta.ToString("c"));
            Console.WriteLine("Proveedor: {0}", objProducto.Proveedor);
            Console.WriteLine("Categoria: {0}", objProducto.Categoria);
            Console.WriteLine("Categoria: {0}", objProducto.SubCategoria);

            Pausa();

            Proveedor objProveedor = new Proveedor("Acme", "30.87654321-0", "Marta González. Int. 10", "marta@acme.com", "12345678", "Pasaje Acme 1.");

            Console.WriteLine("Proveedor" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objProveedor.Nombre);
            Console.WriteLine("CUIT: {0}", objProveedor.CUIT);
            Console.WriteLine("Contacto: {0}", objProveedor.Contacto);
            Console.WriteLine("Email: {0}", objProveedor.Email);
            Console.WriteLine("Teléfono: {0}", objProveedor.Telefono);
            Console.WriteLine("Dirección: {0}", objProveedor.Direccion); 

            Pausa();

            ClienteIndividuo objClienteIndividuo = new ClienteIndividuo("Juan", "Pérez", "10-12345678-0", "juan@perez.com", "87654321", "Av. de los Pérez 1.");
            
            Console.WriteLine("Cliente individuo" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objClienteIndividuo.Nombre);
            Console.WriteLine("Apellido: {0}", objClienteIndividuo.Apellido);
            Console.WriteLine("CUIT: {0}", objClienteIndividuo.CUIT);
            Console.WriteLine("Email: {0}", objClienteIndividuo.Email);
            Console.WriteLine("Teléfono: {0}", objClienteIndividuo.Telefono);
            Console.WriteLine("Dirección: {0}", objClienteIndividuo.Direccion);

            Pausa();

            Proveedor objClienteEmpresa = new Proveedor("Emca", "30.07050301-0", "Pedro Hernández.", "pedro@emca.com", "13335373", "Los Hernández 10.");

            Console.WriteLine("Cliente empresa" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objClienteEmpresa.Nombre);
            Console.WriteLine("CUIT: {0}", objClienteEmpresa.CUIT);
            Console.WriteLine("Contacto: {0}", objClienteEmpresa.Contacto);
            Console.WriteLine("Email: {0}", objClienteEmpresa.Email);
            Console.WriteLine("Teléfono: {0}", objClienteEmpresa.Telefono);
            Console.WriteLine("Dirección: {0}", objClienteEmpresa.Direccion);

            Pausa();

            Vendedor objVendedor = new Vendedor("José","Mercado", "77.666.333", "jose@acme.com", "17375778", "Av. de las Capitales 1979. Piso 1");

            Console.WriteLine("Cliente vendedor" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objVendedor.Nombre);
            Console.WriteLine("Contacto: {0}", objVendedor.Apellido);
            Console.WriteLine("DNI: {0}", objVendedor.DNI);
            Console.WriteLine("Email: {0}", objVendedor.Email);
            Console.WriteLine("Teléfono: {0}", objVendedor.Telefono);
            Console.WriteLine("Dirección: {0}", objVendedor.Direccion);

            Pausa();

            Factura objFactura = new Factura("C", "0001-00000001", DateTime.Now, "Juan Pérez", "Av. de los Pérez 1", "Resp. Insc.", "Contado", "Cant.: 1. Descrip.: Producto A. P. unitario: $15.13. Importe: $15.15", Convert.ToDecimal(15.13));

            Console.WriteLine("Factura" + Environment.NewLine);

            Console.WriteLine("Tipo: {0}", objFactura.Tipo);
            Console.WriteLine("Número: {0}", objFactura.Numero);
            Console.WriteLine("Fecha: {0}", objFactura.Fecha.ToShortDateString());
            Console.WriteLine("Cliente: {0}", objFactura.Cliente);
            Console.WriteLine("Dirección: {0}", objFactura.Direccion);
            Console.WriteLine("Condición frente al I.V.A.: {0}", objFactura.CondicionIVA);
            Console.WriteLine("Condiciones de venta: {0}", objFactura.CondicionVenta);
            Console.WriteLine("Detalle: {0}", objFactura.Detalle);
            Console.WriteLine("Total: {0}", objFactura.Total);

            Pausa();

            Remito objRemito = new Remito("0001-00000001", DateTime.Now, "Juan Pérez", "Av. de los Pérez 1", "Resp. Insc.", "Contado", "Cant.: 1. Descrip.: Producto A.", Convert.ToDecimal(15.13), DateTime.Now.AddDays(1)) ;

            Console.WriteLine("Remito" + Environment.NewLine);

            Console.WriteLine("Número: {0}", objRemito.Numero);
            Console.WriteLine("Fecha: {0}", objRemito.Fecha.ToShortDateString());
            Console.WriteLine("Cliente: {0}", objRemito.Cliente);
            Console.WriteLine("Dirección: {0}", objRemito.Direccion);
            Console.WriteLine("Condición frente al I.V.A.: {0}", objRemito.CondicionIVA);
            Console.WriteLine("Condiciones de venta: {0}", objRemito.CondicionVenta);
            Console.WriteLine("Detalle: {0}", objRemito.Detalle);
            Console.WriteLine("Fecha de entrega: {0}", objRemito.FechaEntrega.ToShortDateString());

            Console.Write(Environment.NewLine + "Pulsar una tecla para terminar...");
            Console.ReadKey();
        }

        private static void Pausa()
        {
            Console.Write(Environment.NewLine + "Pulsar una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
