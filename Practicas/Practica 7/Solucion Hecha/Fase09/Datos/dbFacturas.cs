using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Servidor;
using Entidades;
using Datos.DataSetIntegradorTableAdapters;


namespace Datos
{
    public static class dbFacturas
    {
        public static void Generar(Factura pFactura)
        {
            string SQL = string.Empty;
          
            SqlConnection objConexion = null;
            SqlCommand objCommandDocumentoComercial = null;
            SqlCommand objCommandFactura = null;
            SqlCommand objCommandItem = null;
            SqlCommand objCommandFacturasItems = null;
            SqlTransaction objTransaction = null;
           
            try
            {
                objConexion = new SqlConnection(BaseDatos.StringConexion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            SQL = "INSERT INTO DocumentosComerciales (Numero, Fecha, Cliente, Direccion, CondicionIVA, CondicionVenta)";
            SQL = SQL + " " +  "VALUES(@Numero, @Fecha, @Cliente, @Direccion, @CondicionIVA, @CondicionVenta)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandDocumentoComercial = new SqlCommand(SQL, objConexion);
            SqlParameter objNumero = new SqlParameter("@Numero", pFactura.Numero);
            SqlParameter objFecha = new SqlParameter("@Fecha", pFactura.Fecha.Date.ToString("yyyyMMdd"));
            SqlParameter objCliente = new SqlParameter("@Cliente", pFactura.Cliente);
            SqlParameter objDireccion = new SqlParameter("@Direccion", pFactura.Direccion);
            SqlParameter objCondicionIVA = new SqlParameter("@CondicionIVA", pFactura.CondicionIVA);
            SqlParameter objCondicionVenta = new SqlParameter("@CondicionVenta", pFactura.CondicionVenta);
            objCommandDocumentoComercial.Parameters.Add(objNumero);
            objCommandDocumentoComercial.Parameters.Add(objFecha);
            objCommandDocumentoComercial.Parameters.Add(objCliente);
            objCommandDocumentoComercial.Parameters.Add(objDireccion);
            objCommandDocumentoComercial.Parameters.Add(objCondicionIVA);
            objCommandDocumentoComercial.Parameters.Add(objCondicionVenta);
           
            SQL = "INSERT INTO Facturas (Id_DocumentoComercial, Tipo)";
            SQL = SQL + " " + "VALUES(@Id_DocumentoComercial, @Tipo)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandFactura = new SqlCommand(SQL, objConexion);
            SqlParameter objId_DocumentoComercial = new SqlParameter("@Id_DocumentoComercial", null);
            SqlParameter objTipo = new SqlParameter("@Tipo", pFactura.Tipo);
            objCommandFactura.Parameters.Add(objId_DocumentoComercial);
            objCommandFactura.Parameters.Add(objTipo);

            SQL = "INSERT INTO Items (Cantidad, Descripcion, PrecioUnitario, Importe)";
            SQL = SQL + " " + "VALUES(@Cantidad, @Descripcion, @PrecioUnitario, @Importe)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandItem = new SqlCommand(SQL, objConexion);
            SqlParameter objCantidad = new SqlParameter("@Cantidad", null);
            SqlParameter objDescripcion = new SqlParameter("@Descripcion", null);
            SqlParameter objPrecioUnitario = new SqlParameter("@PrecioUnitario", null);
            SqlParameter objImporte = new SqlParameter("@Importe", null);
            objCommandItem.Parameters.Add(objCantidad);
            objCommandItem.Parameters.Add(objDescripcion);
            objCommandItem.Parameters.Add(objPrecioUnitario);
            objCommandItem.Parameters.Add(objImporte);
            
            SQL = "INSERT INTO FacturasItems (ID_Factura, Id_Item)";
            SQL = SQL + " " + "Values(@Id_Factura, @Id_Item)";
            objCommandFacturasItems = new SqlCommand(SQL, objConexion);
            SqlParameter objId_Factura = new SqlParameter("@Id_Factura", null);
            SqlParameter objId_Item = new SqlParameter("@Id_item", null);
            objCommandFacturasItems.Parameters.Add(objId_Factura);
            objCommandFacturasItems.Parameters.Add(objId_Item);
            
            try
            {
                objConexion.Open();
                objTransaction = objConexion.BeginTransaction();
                objCommandDocumentoComercial.Transaction =  objTransaction;
                objCommandFactura.Transaction = objTransaction;
                objCommandItem.Transaction = objTransaction;
                objCommandFacturasItems.Transaction = objTransaction;

                objId_DocumentoComercial.Value = Convert.ToInt32(objCommandDocumentoComercial.ExecuteScalar());
                objId_Factura.Value = Convert.ToInt32(objCommandFactura.ExecuteScalar());

                foreach (Item Item in pFactura.Detalle)
                {
                    objCantidad.Value = Item.Cantidad;
                    objDescripcion.Value = Item.Descripcion;
                    objPrecioUnitario.Value = Item.PrecioUnitario;
                    objImporte.Value = Item.Importe;
                    objId_Item.Value  = Convert.ToInt32(objCommandItem.ExecuteScalar());
                    objCommandFacturasItems.ExecuteNonQuery();
                }
                objTransaction.Commit();
            }
            catch (Exception ex)
            {
                objTransaction.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                objConexion.Close();
            }
        }

        public static List<Factura> Listar(Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales pOrden)
        {
            List<Factura> lstFacturas = new List<Factura>();
            ViewFacturasTableAdapter objTableAdapter = new ViewFacturasTableAdapter();
            objTableAdapter.Connection.ConnectionString = BaseDatos.StringConexion;
            try
            {
                DataSetIntegrador.ViewFacturasDataTable objDataTable = null;
                switch (pOrden)
                {
                    case Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales.Cliente:
                        objDataTable = objTableAdapter.GetData();
                        break;
                    case Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales.FechaAscendente:
                        objDataTable = objTableAdapter.GetDataOrderByFechaAsc();
                        break;
                    case Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales.FechaDescendente:
                        objDataTable = objTableAdapter.GetDataOrderByFechaDesc();
                        break;
                    default:
                        throw new Exception("Parámetro inválido.");
                }
                foreach (DataSetIntegrador.ViewFacturasRow objRow in objDataTable)
                {  
                    Factura objFactura = new Factura();
                    objFactura.Id = objRow.Id;
                    objFactura.Tipo = objRow.Tipo;
                    objFactura.Numero = objRow.Numero;
                    objFactura.Fecha = objRow.Fecha;
                    objFactura.Cliente = objRow.Cliente;
                    objFactura.Direccion = objRow.Direccion;
                    objFactura.CondicionIVA = objRow.CondicionIVA;
                    objFactura.CondicionVenta = objRow.CondicionVenta;
                    objFactura.Detalle = ListarItems(objRow.Id);
                    lstFacturas.Add(objFactura);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lstFacturas;
        }

        private static List<Item> ListarItems(int pId_Factura)
        {
            List<Item> lstItems = new List<Item>();
            ItemsFacturasTableAdapter objTableAdapter = new ItemsFacturasTableAdapter();
            objTableAdapter.Connection.ConnectionString = BaseDatos.StringConexion;
            try
            {
                foreach (DataSetIntegrador.ItemsFacturasRow objRow in objTableAdapter.GetItemsById(pId_Factura))
                {
                    Item Item = new Item(objRow.Cantidad, objRow.Descripcion, objRow.PrecioUnitario);
                    lstItems.Add(Item);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lstItems;
        }
    }
}
