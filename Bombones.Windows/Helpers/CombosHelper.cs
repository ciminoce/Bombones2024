using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Bombones.Windows.Helpers
{
    public static class CombosHelper
    {
        private static IServiceProvider? _serviceProvider;

        public static void CargarComboPaises(ref ComboBox cbo,
            IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosPaises? servicio = _serviceProvider?.GetService<IServiciosPaises>();
            var listaPaises = servicio?.GetLista(null,null);
            var defaultPais = new Pais()
            {
                PaisId = 0,
                NombrePais = "Seleccione"
            };
            listaPaises?.Insert(0, defaultPais);
            cbo.DataSource = listaPaises;
            cbo.DisplayMember = "NombrePais";
            cbo.ValueMember = "PaisId";
            cbo.SelectedIndex = 0;

        }

        public static void CargarComboProvinciaEstado(ref ComboBox cbo, 
            Pais paisSeleccionado, IServiceProvider? _servicios)
        {
            _serviceProvider = _servicios;
            IServiciosProvinciasEstados? servicio = _serviceProvider?.GetService<IServiciosProvinciasEstados>();
            var listaEstados = servicio?.GetListaComboEstados(paisSeleccionado);
            var defaultEstado = new ProvinciaEstado()
            {
                PaisId = 0,
                NombreProvinciaEstado = "Seleccione"
            };
            listaEstados?.Insert(0, defaultEstado);
            cbo.DataSource = listaEstados;
            cbo.DisplayMember = "NombreProvinciaEstado";
            cbo.ValueMember = "ProvinciaEstadoId";
            cbo.SelectedIndex = 0;

        }

        public static void CargarComboCiudades(ref ComboBox cbo, Pais? paisSeleccionado, ProvinciaEstado provinciaEstado, IServiceProvider? servicios)
        {
            _serviceProvider = servicios;
            IServiciosCiudades? servicio = _serviceProvider?.GetService<IServiciosCiudades>();
            var lista = servicio?.GetListaCombo(paisSeleccionado, provinciaEstado);
            var defaultCiudad = new Ciudad()
            {
                CiudadId = 0,
                NombreCiudad = "Seleccione"
            };
            lista?.Insert(0, defaultCiudad);
            cbo.DataSource = lista;
            cbo.DisplayMember = "NombreCiudad";
            cbo.ValueMember = "CiudadId";
            cbo.SelectedIndex = 0;


        }

        public static void CargarComboPaginas(ref ComboBox cbo, int totalPages)
        {
            cbo.Items.Clear();
            for (int i = 1; i <= totalPages; i++)
            {
                cbo.Items.Add(i.ToString());
            }
            
        }

        public static void CargarComboTipoTelefono(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTiposDeTelefonos? servicio = _serviceProvider?.GetService<IServiciosTiposDeTelefonos>();
            var lista = servicio?.GetLista();
            var defaultTipo = new TipoTelefono()
            {
                TipoTelefonoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoTelefonoId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTipoDireccion(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTiposDeDirecciones? servicio = _serviceProvider?.GetService<IServiciosTiposDeDirecciones>();
            var lista = servicio?.GetLista();
            var defaultTipo = new TipoDireccion()
            {
                TipoDireccionId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoDireccionId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboTiposDeChocolate(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTiposDeChocolates? servicio = _serviceProvider?.GetService<IServiciosTiposDeChocolates>();
            var lista = servicio?.GetLista();
            var defaultTipo = new TipoDeChocolate()
            {
                TipoDeChocolateId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoDeChocolateId";
            cbo.SelectedIndex = 0;

        }

        public static void CargarComboTiposDeRelleno(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTiposDeRellenos? servicio = _serviceProvider?.GetService<IServiciosTiposDeRellenos>();
            var lista = servicio?.GetLista();
            var defaultTipo = new TipoDeRelleno()
            {
                TipoDeRellenoId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoDeRellenoId";
            cbo.SelectedIndex = 0;
        }

        internal static void CargarComboTiposDeNueces(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosTiposDeNueces? servicio = _serviceProvider?.GetService<IServiciosTiposDeNueces>();
            var lista = servicio?.GetLista();
            var defaultTipo = new TipoDeNuez()
            {
                TipoDeNuezId = 0,
                Descripcion = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Descripcion";
            cbo.ValueMember = "TipoDeNuezId";
            cbo.SelectedIndex = 0;
        }

        internal static void CargarComboFabricas(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosFabricas? servicio = _serviceProvider?.GetService<IServiciosFabricas>();
            var lista = servicio?.GetLista();
            var defaultTipo = new Fabrica()
            {
                FabricaId = 0,
                NombreFabrica = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "NombreFabrica";
            cbo.ValueMember = "FabricaId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboBombones(ref ComboBox cbo, IServiceProvider? serviceProvider)
        {
            _serviceProvider = serviceProvider;
            IServiciosProductos? servicio = _serviceProvider?.GetService<IServiciosProductos>();
            var lista = servicio?.GetListaProductos();
            var defaultTipo = new Producto()
            {
                ProductoId = 0,
                Nombre = "Seleccione"
            };
            lista?.Insert(0, defaultTipo);
            cbo.DataSource = lista;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "ProductoId";
            cbo.SelectedIndex = 0;
        }
    }
}
