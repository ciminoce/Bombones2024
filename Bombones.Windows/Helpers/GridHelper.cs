﻿using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;

namespace Bombones.Windows.Helpers
{
    public static class GridHelper
    {
        public static void MostrarDatosEnGrilla<T>(List<T> lista, DataGridView dgv) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r,item);
                AgregarFila(r, dgv);
            }
        }
        public static void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case TipoDeChocolate tc:
                    r.Cells[0].Value = tc.Descripcion;
                    break;
                case TipoDeRelleno tr:
                    r.Cells[0].Value = tr.Descripcion;
                    break;
                case TipoDeNuez tn:
                    r.Cells[0].Value = tn.Descripcion;
                    break;
                case Pais p:
                    r.Cells[0].Value = p.PaisId;
                    r.Cells[1].Value = p.NombrePais;
                    break;
                case ProvinciaEstadoListDto pe:
                    r.Cells[0].Value=pe.ProvinciaEstadoId;
                    r.Cells[1].Value = pe.NombreProvinciaEstado;
                    r.Cells[2].Value = pe.NombrePais;
                    break;
                case CiudadListDto ciudad:
                    r.Cells[0].Value=ciudad.CiudadId;
                    r.Cells[1].Value = ciudad.NombreCiudad;
                    r.Cells[2].Value = ciudad.NombreProvinciaEstado;
                    r.Cells[3].Value = ciudad.NombrePais;
                    break;
                case FabricaListDto fabrica:
                    r.Cells[0].Value=fabrica.FabricaId;
                    r.Cells[1].Value=fabrica.NombreFabrica;
                    r.Cells[2].Value=fabrica.Direccion;
                    r.Cells[3].Value = fabrica.NombreCiudad;
                    r.Cells[4].Value = fabrica.NombreProvinciaEstado;
                    r.Cells[5].Value = fabrica.NombrePais;
                   
                    break;
                case ClienteListDto cliente:
                    r.Cells[0].Value = cliente.ClienteId;
                    r.Cells[1].Value = cliente.Documento;
                    r.Cells[2].Value = cliente.NombreCompleto;
                    r.Cells[3].Value = cliente.DireccionPrincipal;
                    r.Cells[4].Value = cliente.TelefonoPrincipal;
                    break;
                case Direccion direccion:
                    r.Cells[0].Value = direccion.DireccionId;
                    r.Cells[1].Value = direccion.ToString();
                    break;
                case Telefono telefono:
                    r.Cells[0].Value = telefono.TelefonoId;
                    r.Cells[1].Value = telefono.ToString();
                    break;
                case BombonListDto bombon:
                    r.Cells[0].Value = bombon.ProductoId;
                    r.Cells[1].Value = bombon.Nombre;
                    r.Cells[2].Value = bombon.TipoDeChocolate;
                    r.Cells[3].Value = bombon.TipoDeRelleno;
                    r.Cells[4].Value = bombon.TipoDeNuez;
                    r.Cells[5].Value = bombon.Fabrica;
                    r.Cells[6].Value= bombon.StockDisponible;
                    r.Cells[7].Value = bombon.Precio;
                    break;
                case DireccionListDto direccion:
                    r.Cells[0].Value = direccion.DireccionId;
                    r.Cells[1].Value = direccion.TipoDireccion;
                    r.Cells[2].Value = direccion.Calle;
                    r.Cells[3].Value = direccion.Altura;
                    r.Cells[4].Value = direccion.Entre1;
                    r.Cells[5].Value = direccion.Entre2;
                    r.Cells[6].Value = direccion.Ciudad;
                    r.Cells[7].Value = direccion.ProvinciaEstado;
                    r.Cells[8].Value = direccion.Pais;
                    r.Cells[9].Value = direccion.CodPostal;
                    break;
                case TelefonoListDto telefono:
                    r.Cells[0].Value = telefono.TelefonoId;
                    r.Cells[1].Value = telefono.TipoTelefono;
                    r.Cells[2].Value = telefono.Numero;
                    break;
                case CajaListDto caja:
                    r.Cells[0].Value = caja.ProductoId;
                    r.Cells[1].Value = caja.Nombre;
                    r.Cells[2].Value = caja.CantidadBombones;
                    r.Cells[3].Value = caja.Variedades;
                    r.Cells[4].Value = caja.StockDisponible;
                    r.Cells[5].Value = caja.Precio;
                    r.Cells[6].Value = caja.Suspendido;
                    break;
                case DetalleCaja detalle:
                    r.Cells[0].Value = detalle.CajaId;
                    r.Cells[1].Value = detalle.Bombon!.Nombre;
                    r.Cells[2].Value = detalle.Cantidad;
                    break;
                case VentaListDto venta:
                    r.Cells[0].Value = venta.VentaId;
                    r.Cells[1].Value = venta.Cliente;
                    r.Cells[2].Value = venta.FechaVenta.ToShortDateString();
                    r.Cells[3].Value = venta.Regalo;
                    r.Cells[4].Value = venta.Total;
                    break;
                case DetalleVenta detalleVta:
                    r.Cells[0].Value = detalleVta.VentaId;
                    r.Cells[1].Value = detalleVta.BombonId is null?detalleVta.Caja!.Nombre:detalleVta.Bombon!.Nombre;
                    r.Cells[2].Value = detalleVta.Precio;
                    r.Cells[3].Value = detalleVta.Cantidad;
                    r.Cells[4].Value = detalleVta.Cantidad * detalleVta.Precio;
                    break;

                default:
                    break;
            }

            r.Tag= obj;
        }

        public static void AgregarFila(DataGridViewRow r, 
            DataGridView grid)
        {
            grid.Rows.Add(r);
        }
        public static void QuitarFila(DataGridViewRow r, 
            DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        public static int ObtenerRowIndex(DataGridView dgv, int id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var row = dgv.Rows[i];
                if ((int)row.Cells[0].Value == id)
                {
                    return i;
                }
            }
            return -1;

        }

        public static void MarcarRow(DataGridView dgvDatos, int rowIndex)
        {
            if (rowIndex >= 0)
            {
                dgvDatos.Rows[rowIndex].Selected = true;
                dgvDatos.FirstDisplayedScrollingRowIndex = rowIndex;
            }

        }

        
    }
}
