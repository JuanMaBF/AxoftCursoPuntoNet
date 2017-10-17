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
    public static class dbRemitos
    {
        public static void Generar(Remito pRemito)
        {
            string SQL = string.Empty;

            SqlConnection objConexion = null;
            SqlCommand objCommandDocumentoComercial = null;
            SqlCommand objCommandRemito = null;
            SqlCommand objCommandItem = null;
            SqlCommand objCommandRemitosItems = null;
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
            SQL = SQL + " " + "VALUES(@Numero, @Fecha, @Cliente, @Direccion, @CondicionIVA, @CondicionVenta)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandDocumentoComercial = new SqlCommand(SQL, objConexion);
            SqlParameter objNumero = new SqlParameter("@Numero", pRemito.Numero);
            SqlParameter objFecha = new SqlParameter("@Fecha", pRemito.Fecha.Date.ToString("yyyyMMdd"));
            SqlParameter objCliente = new SqlParameter("@Cliente", pRemito.Cliente);
            SqlParameter objDireccion = new SqlParameter("@Direccion", pRemito.Direccion);
            SqlParameter objCondicionIVA = new SqlParameter("@CondicionIVA", pRemito.CondicionIVA);
            SqlParameter objCondicionVenta = new SqlParameter("@CondicionVenta", pRemito.CondicionVenta);
            objCommandDocumentoComercial.Parameters.Add(objNumero);
            objCommandDocumentoComercial.Parameters.Add(objFecha);
            objCommandDocumentoComercial.Parameters.Add(objCliente);
            objCommandDocumentoComercial.Parameters.Add(objDireccion);
            objCommandDocumentoComercial.Parameters.Add(objCondicionIVA);
            objCommandDocumentoComercial.Parameters.Add(objCondicionVenta);

            SQL = "INSERT INTO Remitos (Id_DocumentoComercial, FechaEntrega)";
            SQL = SQL + " " + "VALUES(@Id_DocumentoComercial, @FechaEntrega)";
            SQL = SQL + ";" + "SELECT SCOPE_IDENTITY()";
            objCommandRemito = new SqlCommand(SQL, objConexion);
            SqlParameter objId_DocumentoComercial = new SqlParameter("@Id_DocumentoComercial", null);
            SqlParameter objFechaEntrega = new SqlParameter("@FechaEntrega", pRemito.Fecha.Date.ToString("yyyyMMdd"));
            objCommandRemito.Parameters.Add(objId_DocumentoComercial);
            objCommandRemito.Parameters.Add(objFechaEntrega);

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

            SQL = "INSERT INTO RemitosItems (ID_Remito, Id_Item)";
            SQL = SQL + " " + "Values(@Id_Remito, @Id_Item)";
            objCommandRemitosItems = new SqlCommand(SQL, objConexion);
            SqlParameter objId_Remito = new SqlParameter("@Id_Remito", null);
            SqlParameter objId_Item = new SqlParameter("@Id_item", null);
            objCommandRemitosItems.Parameters.Add(objId_Remito);
            objCommandRemitosItems.Parameters.Add(objId_Item);

            try
            {
                objConexion.Open();
                objTransaction = objConexion.BeginTransaction();
                objCommandDocumentoComercial.Transaction = objTransaction;
                objCommandRemito.Transaction = objTransaction;
                objCommandItem.Transaction = objTransaction;
                objCommandRemitosItems.Transaction = objTransaction;
                objId_DocumentoComercial.Value = Convert.ToInt32(objCommandDocumentoComercial.ExecuteScalar());
                objId_Remito.Value = Convert.ToInt32(objCommandRemito.ExecuteScalar());
                foreach (Item Item in pRemito.Detalle)
                {
                    objCantidad.Value = Item.Cantidad;
                    objDescripcion.Value = Item.Descripcion;
                    objPrecioUnitario.Value = Item.PrecioUnitario;
                    objImporte.Value = Item.Importe;
                    objId_Item.Value = Convert.ToInt32(objCommandItem.ExecuteScalar());
                    objCommandRemitosItems.ExecuteNonQuery();
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

        public static List<Remito> Listar(Enumeraciones.Enumeraciones.ColumnasDocumentosComerciales pOrden)
        {
            List<Remito> lstRemitos = new List<Remito>();
            ViewRemitosTableAdapter objTableAdapter = new ViewRemitosTableAdapter();
            objTableAdapter.Connection.ConnectionString = BaseDatos.StringConexion;
            try
            {
                DataSetIntegrador.ViewRemitosDataTable objDataTable = null;
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
                foreach (DataSetIntegrador.ViewRemitosRow objRow in objDataTable)
                {
                    Remito objRemito = new Remito();
                    objRemito.Id = objRow.Id;
                    objRemito.FechaEntrega = objRow.FechaEntrega;
                    objRemito.Numero = objRow.Numero;
                    objRemito.Fecha = objRow.Fecha;
                    objRemito.Cliente = objRow.Cliente;
                    objRemito.Direccion = objRow.Direccion;
                    objRemito.CondicionIVA = objRow.CondicionIVA;
                    objRemito.CondicionVenta = objRow.CondicionVenta;
                    objRemito.Detalle = ListarItems(objRow.Id);
                    lstRemitos.Add(objRemito);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lstRemitos;
        }

        private static List<Item> ListarItems(int pId_Remito)
        {
            List<Item> lstItems = new List<Item>();
            ItemsRemitoTableAdapter objTableAdapter = new ItemsRemitoTableAdapter();
            objTableAdapter.Connection.ConnectionString = BaseDatos.StringConexion;
            try
            {
                foreach (DataSetIntegrador.ItemsRemitoRow objRow in objTableAdapter.GetItemsById(pId_Remito))
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
