using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Windows.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bombones.Windows.Formularios
{
    public partial class frmDetalleCliente : Form
    {
        private ClienteDetalleDto? clienteDto;
        public frmDetalleCliente()
        {
            InitializeComponent();
        }

        internal void SetCliente(ClienteDetalleDto? clienteDetalleDto)
        {
            clienteDto = clienteDetalleDto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetalleCliente_Load(object sender, EventArgs e)
        {
            MostrarCliente(clienteDto);
            MostrarTelefonos(clienteDto!.Telefonos);
            MostrarDirecciones(clienteDto!.Direcciones);
        }

        private void MostrarDirecciones(List<DireccionListDto> direcciones)
        {
            GridHelper.LimpiarGrilla(dgvDirecciones);
            if (direcciones is not null)
            {
                foreach (var d in direcciones)
                {
                    var r = GridHelper.ConstruirFila(dgvDirecciones);
                    GridHelper.SetearFila(r, d);
                    GridHelper.AgregarFila(r, dgvDirecciones);
                }

            }

        }

        private void MostrarTelefonos(List<TelefonoListDto> telefonos)
        {
            GridHelper.LimpiarGrilla(dgvTelefonos);
            if (telefonos is not null)
            {
                foreach (var t in telefonos)
                {
                    var r = GridHelper.ConstruirFila(dgvTelefonos);
                    GridHelper.SetearFila(r, t);
                    GridHelper.AgregarFila(r, dgvTelefonos);
                }

            }

        }

        private void MostrarCliente(ClienteDetalleDto? clienteDto)
        {
            txtApellido.Text = clienteDto.Apellido;
            txtNombre.Text=clienteDto.Nombres;
            txtDocumento.Text=clienteDto.Documento.ToString();
        }
    }
}
