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

            Categoria objCategoria = null;
            Categoria objSubCategoria = null;
            DatosContacto objDatosContactoProveedor = null;
            DatosContacto objDatosContactoProveedorPersonaContacto = null;
            Persona objPersonaContactoProveedor = null;
            Empresa objProveedor = null;
            Producto objProducto = null;
            DatosContacto objDatosContactoClienteIndividuo = null;
            ClienteIndividuo objClienteIndividuo = null;
            DatosContacto objDatosContactoClienteEmpresa = null;
            DatosContacto objDatosContactoClienteEmpresaPersonaContacto = null;
            Persona objPersonaContactoClienteEmpresa = null;
            Empresa objClienteEmpresa = null;
            DatosContacto objDatosContactoVendedor = null;
            Vendedor objVendedor = null;
            Item objItem = null;
            Factura objFactura = null;
            Remito objRemito = null;

            try
            {
                objCategoria = new Categoria("Categoria A");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objSubCategoria = new Categoria("Subcategoria A");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objDatosContactoProveedor = new DatosContacto("acme@acme.com", "123456789012345", "Pasaje Acme 1. Ciudad Desierta.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objDatosContactoProveedorPersonaContacto = new DatosContacto("marta@acme.com", "123456789012340", "Pasaje Acme 1. Ciudad Desierta.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objPersonaContactoProveedor = new Persona("Marta", "González", objDatosContactoProveedorPersonaContacto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objProveedor = new Empresa("Acme", "12345678901", objPersonaContactoProveedor, objDatosContactoProveedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                Producto.IVA = .21;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objProducto = new Producto("Producto A", "Descripcion del producto A.", 10, .25, objProveedor, objCategoria, objSubCategoria);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Producto" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objProducto.Nombre);
            Console.WriteLine("Descripción: {0}", objProducto.Descripcion);
            Console.WriteLine("Precio de costo: {0}", objProducto.PrecioCosto.ToString("c"));
            Console.WriteLine("Margen: {0}", objProducto.Margen.ToString("p"));
            Console.WriteLine("I.V.A.: {0}", Producto.IVA.ToString("p"));
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

            try
            {
                objDatosContactoClienteIndividuo = new DatosContacto("juan@perez.com", "987654321098765", "Av. de los Pérez 1.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objClienteIndividuo = new ClienteIndividuo("Juan", "Pérez", "09876543210", objDatosContactoClienteIndividuo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Cliente individuo" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objClienteIndividuo.Nombre);
            Console.WriteLine("Apellido: {0}", objClienteIndividuo.Apellido);
            Console.WriteLine("CUIT: {0}", objClienteIndividuo.CUIT);
            Console.WriteLine("Email: {0}", objClienteIndividuo.DatosContacto.Email);
            Console.WriteLine("Teléfono: {0}", objClienteIndividuo.DatosContacto.Telefono);
            Console.WriteLine("Dirección: {0}", objClienteIndividuo.DatosContacto.Direccion);

            Pausa();

            try
            {
                objDatosContactoClienteEmpresa = new DatosContacto("emca@emca.com", "789012345678901", "Los Hernández 10. Ciudad Poblada.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objDatosContactoClienteEmpresaPersonaContacto = new DatosContacto("pedro.hernadez@emca.com", "890123456789012", "Los Hernández 10.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objPersonaContactoClienteEmpresa = new Persona("Pedro", "Hernández", objDatosContactoClienteEmpresaPersonaContacto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objClienteEmpresa = new Empresa("Emca", "13256834500", objPersonaContactoClienteEmpresa, objDatosContactoClienteEmpresa);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Cliente empresa" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objClienteEmpresa.Nombre);
            Console.WriteLine("CUIT: {0}", objClienteEmpresa.CUIT);
            Console.WriteLine("Contacto: {0} {1}", objClienteEmpresa.Contacto.Nombre, objClienteEmpresa.Contacto.Apellido);
            Console.WriteLine("Email: {0}", objClienteEmpresa.DatosContacto.Email);
            Console.WriteLine("Teléfono: {0}", objClienteEmpresa.DatosContacto.Telefono);
            Console.WriteLine("Dirección: {0}", objClienteEmpresa.DatosContacto.Direccion);

            Pausa();

            try
            {
                objDatosContactoVendedor = new DatosContacto("jose@acme.com", "345685123465543", "Av. de las Capitales 1979. Piso 1.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                objVendedor = new Vendedor("José", "Mercado", "37363448", objDatosContactoVendedor);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Cliente vendedor" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objVendedor.Nombre);
            Console.WriteLine("Contacto: {0}", objVendedor.Apellido);
            Console.WriteLine("DNI: {0}", objVendedor.DNI);
            Console.WriteLine("Email: {0}", objVendedor.DatosContacto.Email);
            Console.WriteLine("Teléfono: {0}", objVendedor.DatosContacto.Telefono);
            Console.WriteLine("Dirección: {0}", objVendedor.DatosContacto.Direccion);

            Pausa();

            try
            {
                objItem = new Item(1, objProducto.Nombre, Convert.ToDecimal(15.15));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            List<Item> lstDetalle = new List<Item>();
            lstDetalle.Add(objItem);

            try
            {
                objFactura = new Factura("C", "0001-00000001", DateTime.Now, "Juan Pérez", "Av. de los Pérez 1", "Resp. Insc.", "Contado", lstDetalle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

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

            try
            {
                objRemito = new Remito("0001-00000001", DateTime.Now, "Juan Pérez", "Av. de los Pérez 1", "Resp. Insc.", "Contado", lstDetalle, DateTime.Now.AddDays(1));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

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
