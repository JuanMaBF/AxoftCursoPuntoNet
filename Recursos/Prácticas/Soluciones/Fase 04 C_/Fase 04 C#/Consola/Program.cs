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
             
            Categoria objCategoria = new Categoria("Categoria A");
            Categoria objSubCategoria = new Categoria("Subcategoria A");

            DatosContacto objDatosContactoProveedor = new DatosContacto("acme@acme.com", "1234567", "Pasaje Acme 1.");
            DatosContacto objDatosContactoProveedorPersonaContacto = new DatosContacto("marta@acme.com", "Int. 10", "Pasaje Acme 1.");

            Persona objPersonaContactoProveedor = new Persona("Marta", "González", objDatosContactoProveedorPersonaContacto);
            Empresa objProveedor = new Empresa("Acme", "30.87654321-0", objPersonaContactoProveedor, objDatosContactoProveedor);

            //asignamos(set)
            Producto.IVA = .21;

            Producto objProducto = new Producto("Producto A", "Descripcion del producto A.", 10, .25,objProveedor, objCategoria, objSubCategoria);
            Producto objProducto2 = new Producto("Producto b", "Descripcion del producto A.", 10, .25, objProveedor, objCategoria, objSubCategoria);
            Producto objProducto3 = new Producto("Producto c", "Descripcion del producto A.", 10, .25, objProveedor, objCategoria, objSubCategoria);
            Producto objProducto4 = new Producto("Producto d", "Descripcion del producto A.", 10, .25, objProveedor, objCategoria, objSubCategoria);

            Console.WriteLine("Producto" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objProducto.Nombre);
            Console.WriteLine("Descripción: {0}", objProducto.Descripcion);
            Console.WriteLine("Precio de costo: {0}", objProducto.PrecioCosto.ToString("c"));
            Console.WriteLine("Margen: {0}", objProducto.Margen.ToString("p"));
            Console.WriteLine("I.V.A.: {0}", Producto.IVA.ToString("p"));//mostramos (get)
            Console.WriteLine("Precio bruto: {0}", objProducto.PrecioBruto.ToString("c"));
            Console.WriteLine("Precio venta: {0}", objProducto.PrecioVenta.ToString("c"));
            Console.WriteLine("Proveedor: {0}", objProducto.Proveedor.Nombre);
            Console.WriteLine("Categoria: {0}", objProducto.Categoria.Nombre);
            Console.WriteLine("Categoria: {0}", objProducto.SubCategoria.Nombre);

            Pausa();

            Console.WriteLine("Proveedor" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objProveedor.Nombre);
            Console.WriteLine("CUIT: {0}", objProveedor.CUIT);
            Console.WriteLine("Contacto: {0} {1}", objProveedor.Contacto.Nombre, objProveedor.Contacto.Apellido);
            Console.WriteLine("Email: {0}", objProveedor.DatosContacto.Email);
            Console.WriteLine("Teléfono: {0}", objProveedor.DatosContacto.Telefono);
            Console.WriteLine("Dirección: {0}", objProveedor.DatosContacto.Direccion); 

            Pausa();

            DatosContacto objDatosContactoClienteIndividuo = new DatosContacto( "juan@perez.com", "87654321", "Av. de los Pérez 1.");
            
            ClienteIndividuo objClienteIndividuo = new ClienteIndividuo("Juan", "Pérez", "10-12345678-0", objDatosContactoClienteIndividuo);
            
            Console.WriteLine("Cliente individuo" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objClienteIndividuo.Nombre);
            Console.WriteLine("Apellido: {0}", objClienteIndividuo.Apellido);
            Console.WriteLine("CUIT: {0}", objClienteIndividuo.CUIT);
            Console.WriteLine("Email: {0}", objClienteIndividuo.DatosContacto.Email);
            Console.WriteLine("Teléfono: {0}", objClienteIndividuo.DatosContacto.Telefono);
            Console.WriteLine("Dirección: {0}", objClienteIndividuo.DatosContacto.Direccion);

            Pausa();

            DatosContacto objDatosContactoClienteEmpresa = new DatosContacto("emca@emca.com", "13335373", "Los Hernández 10.");
            DatosContacto objDatosContactoClienteEmpresaPersonaContacto = new DatosContacto("pedro.hernadez@emca.com", "Int. 5.", "Los Hernández 10.");
            
            Persona objPersonaContactoClienteEmpresa = new Persona("Pedro", "Hernández", objDatosContactoClienteEmpresaPersonaContacto);
            
            Empresa objClienteEmpresa = new Empresa("Emca", "30.07050301-0", objPersonaContactoClienteEmpresa, objDatosContactoClienteEmpresa);

            Console.WriteLine("Cliente empresa" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objClienteEmpresa.Nombre);
            Console.WriteLine("CUIT: {0}", objClienteEmpresa.CUIT);
            Console.WriteLine("Contacto: {0} {1}", objClienteEmpresa.Contacto.Nombre, objClienteEmpresa.Contacto.Apellido);
            Console.WriteLine("Email: {0}", objClienteEmpresa.DatosContacto.Email);
            Console.WriteLine("Teléfono: {0}", objClienteEmpresa.DatosContacto.Telefono);
            Console.WriteLine("Dirección: {0}", objClienteEmpresa.DatosContacto.Direccion);

            Pausa();

            DatosContacto objDatosContactoVendedor = new DatosContacto("jose@acme.com", "17375778", "Av. de las Capitales 1979. Piso 1");
            
             Vendedor objVendedor = new Vendedor("José","Mercado", "77.666.333", objDatosContactoVendedor);

            Console.WriteLine("Cliente vendedor" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objVendedor.Nombre);
            Console.WriteLine("Contacto: {0}", objVendedor.Apellido);
            Console.WriteLine("DNI: {0}", objVendedor.DNI);
            Console.WriteLine("Email: {0}", objVendedor.DatosContacto.Email);
            Console.WriteLine("Teléfono: {0}", objVendedor.DatosContacto.Telefono);
            Console.WriteLine("Dirección: {0}", objVendedor.DatosContacto.Direccion);

            Pausa();

            Item objItem = new Item(1,"Producto 1",Convert.ToDecimal(15.15));
            List<Item> lstDetalle = new List<Item>();
            lstDetalle.Add(objItem);
            Factura objFactura = new Factura("C", "0001-00000001", DateTime.Now, "Juan Pérez", "Av. de los Pérez 1", "Resp. Insc.", "Contado",lstDetalle);

            Console.WriteLine("Factura" + Environment.NewLine);

            Console.WriteLine("Tipo: {0}", objFactura.Tipo);
            Console.WriteLine("Número: {0}", objFactura.Numero);
            Console.WriteLine("Cliente: {0}", objFactura.Cliente);
            Console.WriteLine("Dirección: {0}", objFactura.Direccion);
            Console.WriteLine("Condición frente al I.V.A.: {0}", objFactura.CondicionIVA);
            Console.WriteLine("Condiciones de venta: {0}", objFactura.CondicionVenta);
            foreach (Item objDetalleItem in objFactura.Detalle)
            { 
                Console.WriteLine("Detalle: {0} {1}. Precio unitario: {2}. Importe {3}.", objItem.Cantidad, objItem.Descripcion, objItem.PrecioUnitario, objItem.Importe); 
            }
            Console.WriteLine("Total: {0}", objFactura.Total);

            Pausa();

            Remito objRemito = new Remito("0001-00000001", DateTime.Now, "Juan Pérez", "Av. de los Pérez 1", "Resp. Insc.", "Contado", lstDetalle, DateTime.Now.AddDays(1));

            Console.WriteLine("Remito" + Environment.NewLine);

            Console.WriteLine("Número: {0}", objRemito.Numero);
            Console.WriteLine("Fecha: {0}", objRemito.Fecha.ToShortDateString());
            Console.WriteLine("Cliente: {0}", objRemito.Cliente);
            Console.WriteLine("Dirección: {0}", objRemito.Direccion);
            Console.WriteLine("Condición frente al I.V.A.: {0}", objRemito.CondicionIVA);
            Console.WriteLine("Condiciones de venta: {0}", objRemito.CondicionVenta);
            foreach (Item objDetalleItem in objRemito.Detalle)
            {
                Console.WriteLine("Detalle: {0} {1}. Precio unitario: {2}. Importe {3}.", objItem.Cantidad, objItem.Descripcion, objItem.PrecioUnitario, objItem.Importe);
            }
            Console.WriteLine("Total: {0}", objRemito.Total);
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
