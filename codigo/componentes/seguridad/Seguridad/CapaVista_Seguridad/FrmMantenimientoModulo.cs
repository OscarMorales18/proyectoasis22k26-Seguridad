using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaControlador_Seguridad;

namespace CapaVista_Seguridad
{
    /// <summary>
    /// EST-10 — Ventana: 2004 - MantenimientoModulo
    /// Componente: Seguridad (rango de código 2000-2999)
    /// Ventana secundaria modal: MaximizeBox = false, tamaño fijo, no redimensionable.
    /// La construcción visual de los controles vive en FrmMantenimientoModulo.Designer.cs
    /// (requisito del diseñador de Visual Studio: InitializeComponent no admite
    /// expresiones lambda ni llamadas a métodos "fábrica").
    /// </summary>
    public partial class FrmMantenimientoModulo : Form
    {
        // ---------------------------------------------------------------
        // Paleta base del componente Seguridad (EST-10, Sección 12.1)
        // ---------------------------------------------------------------
        private static readonly Color ColorPrimario = ColorTranslator.FromHtml("#006D77");
        private static readonly Color ColorSecundario = ColorTranslator.FromHtml("#83C5BE");
        private static readonly Color ColorAcento = ColorTranslator.FromHtml("#D97757");
        private static readonly Color ColorFondo = ColorTranslator.FromHtml("#EDC9A1");
        private static readonly Color ColorErrorBorde = Color.FromArgb(220, 53, 69);
        private static readonly Color ColorDeshabilitado = Color.Gainsboro;

        // ---------------------------------------------------------------
        // Capa Controlador y estado interno
        // ---------------------------------------------------------------
        private readonly ClsModuloControlador _moduloControlador;
        private DataTable _tablaModulos;
        private int _idModuloSeleccionado;

        // Paginación (EST-10, Sección 8)
        private int _paginaActual = 1;
        private const int RegistrosPorPagina = 8;

        // Orden de columnas (EST-10, Sección 8)
        private string _columnaOrden = "IdModulo";
        private bool _ordenAscendente = true;

        public FrmMantenimientoModulo()
        {
            _moduloControlador = new ClsModuloControlador();
            InitializeComponent();      // generado en FrmMantenimientoModulo.Designer.cs
            // this.Icon = Properties.Resources.IconoSeguridad; // ícono del catálogo de Teams (Seguridad)
            MetConfigurarGrid();
            MetCargarModulos();
            MetLimpiarFormulario();
        }

        // =================================================================
        // Carga y presentación de datos (tabla + paginación + orden)
        // =================================================================
        private void MetConfigurarGrid()
        {
            SeguridadDgvListaModulos.Columns.Add("IdModulo", "Id Módulo");
            SeguridadDgvListaModulos.Columns.Add("NombreModulo", "Nombre Módulo");
            SeguridadDgvListaModulos.Columns.Add("Descripcion", "Descripción");
            SeguridadDgvListaModulos.Columns.Add("Estado", "Estado");
        }

        private void MetCargarModulos()
        {
            try
            {
                _tablaModulos = _moduloControlador.MetListarModulos();
            }
            catch (Exception ex)
            {
                _tablaModulos = new DataTable();
                _tablaModulos.Columns.Add("IdModulo", typeof(int));
                _tablaModulos.Columns.Add("NombreModulo", typeof(string));
                _tablaModulos.Columns.Add("Descripcion", typeof(string));
                _tablaModulos.Columns.Add("Estado", typeof(bool));
                DialogosEstandar.MetMostrarError("No fue posible conectar con la base de datos: " + ex.Message);
            }

            _paginaActual = 1;
            MetMostrarPagina();
        }

        private void MetMostrarPagina()
        {
            if (_tablaModulos == null) return;

            DataView vista = _tablaModulos.DefaultView;
            vista.Sort = _columnaOrden + (_ordenAscendente ? " ASC" : " DESC");

            int totalRegistros = vista.Count;
            int totalPaginas = Math.Max(1, (int)Math.Ceiling(totalRegistros / (double)RegistrosPorPagina));
            _paginaActual = Math.Max(1, Math.Min(_paginaActual, totalPaginas));

            var filasPagina = vista.Cast<DataRowView>()
                                    .Skip((_paginaActual - 1) * RegistrosPorPagina)
                                    .Take(RegistrosPorPagina)
                                    .ToList();

            SeguridadDgvListaModulos.Rows.Clear();
            foreach (DataRowView fila in filasPagina)
            {
                SeguridadDgvListaModulos.Rows.Add(
                    fila["IdModulo"],
                    fila["NombreModulo"],
                    fila["Descripcion"],
                    Convert.ToBoolean(fila["Estado"]) ? "Activo" : "Inactivo");
            }

            int inicio = totalRegistros == 0 ? 0 : ((_paginaActual - 1) * RegistrosPorPagina) + 1;
            int fin = Math.Min(_paginaActual * RegistrosPorPagina, totalRegistros);
            SeguridadLblResumenPaginacion.Text = $"Mostrando {inicio}-{fin} de {totalRegistros} registros";

            SeguridadBtnAnterior.Enabled = _paginaActual > 1;
            SeguridadBtnSiguiente.Enabled = _paginaActual < totalPaginas;

            MetActualizarFlechasOrden();
        }

        private void MetActualizarFlechasOrden()
        {
            foreach (DataGridViewColumn columna in SeguridadDgvListaModulos.Columns)
            {
                string textoBase = columna.HeaderText.TrimEnd(' ', '▲', '▼');
                columna.HeaderText = columna.Name == _columnaOrden
                    ? textoBase + (_ordenAscendente ? " ▲" : " ▼")
                    : textoBase;
            }
        }

        // =================================================================
        // Eventos de la tabla (nombrados — el diseñador no admite lambdas)
        // =================================================================
        private void SeguridadDgvListaModulos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnaClic = SeguridadDgvListaModulos.Columns[e.ColumnIndex].Name;

            if (_columnaOrden == columnaClic)
                _ordenAscendente = !_ordenAscendente;
            else
            {
                _columnaOrden = columnaClic;
                _ordenAscendente = true;
            }

            MetMostrarPagina();
        }

        private void SeguridadDgvListaModulos_SelectionChanged(object sender, EventArgs e)
        {
            if (SeguridadDgvListaModulos.CurrentRow == null) return;

            DataGridViewRow filaSeleccionada = SeguridadDgvListaModulos.CurrentRow;
            _idModuloSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["IdModulo"].Value);

            SeguridadTxtIdModulo.Text = filaSeleccionada.Cells["IdModulo"].Value.ToString();
            SeguridadTxtNombreModulo.Text = filaSeleccionada.Cells["NombreModulo"].Value.ToString();
            SeguridadTxtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            SeguridadChkEstado.Checked = filaSeleccionada.Cells["Estado"].Value.ToString() == "Activo";

            MetHabilitarBoton(SeguridadBtnGuardar, false, ColorPrimario);
            MetHabilitarBoton(SeguridadBtnModificar, true, ColorPrimario);
            MetHabilitarBoton(SeguridadBtnEliminar, true, ColorAcento);
        }

        // =================================================================
        // Estados de controles (EST-10, Sección 7)
        // =================================================================
        private void SeguridadTxtNombreModulo_TextChanged(object sender, EventArgs e)
        {
            MetActualizarBotonesPorCambios();
        }

        private void SeguridadTxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            MetActualizarBotonesPorCambios();
        }

        private void SeguridadChkEstado_CheckedChanged(object sender, EventArgs e)
        {
            MetActualizarBotonesPorCambios();
        }

        private void MetActualizarBotonesPorCambios()
        {
            bool esRegistroNuevo = _idModuloSeleccionado == 0;
            bool hayDatos = MetHayDatosCapturados();

            MetHabilitarBoton(SeguridadBtnGuardar, esRegistroNuevo && hayDatos, ColorPrimario);
            MetHabilitarBoton(SeguridadBtnModificar, !esRegistroNuevo && hayDatos, ColorPrimario);
        }

        private bool MetHayDatosCapturados()
        {
            return !string.IsNullOrWhiteSpace(SeguridadTxtNombreModulo.Text) ||
                   !string.IsNullOrWhiteSpace(SeguridadTxtDescripcion.Text);
        }

        /// <summary>
        /// Aplica Enabled + color de botón (gris cuando está deshabilitado — Sección 7).
        /// Se llama explícitamente en vez de suscribir EnabledChanged con una lambda.
        /// </summary>
        private void MetHabilitarBoton(Button boton, bool habilitar, Color colorActivo)
        {
            boton.Enabled = habilitar;
            boton.BackColor = habilitar ? colorActivo : ColorDeshabilitado;
            boton.ForeColor = habilitar ? Color.White : Color.DimGray;
        }

        private bool MetValidarCamposVisualmente()
        {
            bool esValido = true;
            string mensajeNombre = _moduloControlador.MetValidarDatos(SeguridadTxtNombreModulo.Text, "x");
            bool errorNombre = !string.IsNullOrEmpty(mensajeNombre) && mensajeNombre.Contains("nombre");

            if (errorNombre)
            {
                SeguridadTxtNombreModulo.BackColor = Color.MistyRose;
                SeguridadLblErrorNombre.Text = mensajeNombre;
                SeguridadLblErrorNombre.Visible = true;
                esValido = false;
            }
            else
            {
                SeguridadTxtNombreModulo.BackColor = Color.White;
                SeguridadLblErrorNombre.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(SeguridadTxtDescripcion.Text))
            {
                SeguridadTxtDescripcion.BackColor = Color.MistyRose;
                SeguridadLblErrorDescripcion.Text = "La descripción es obligatoria.";
                SeguridadLblErrorDescripcion.Visible = true;
                esValido = false;
            }
            else
            {
                SeguridadTxtDescripcion.BackColor = Color.White;
                SeguridadLblErrorDescripcion.Visible = false;
            }

            return esValido;
        }

        // =================================================================
        // Acciones CRUD (nombradas — el diseñador no admite lambdas)
        // =================================================================
        private void SeguridadBtnGuardar_Click(object sender, EventArgs e)
        {
            if (!MetValidarCamposVisualmente()) return;

            string mensajeError = _moduloControlador.MetGuardarModulo(
                0, SeguridadTxtNombreModulo.Text, SeguridadTxtDescripcion.Text, SeguridadChkEstado.Checked);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                DialogosEstandar.MetMostrarError(mensajeError);
                return;
            }

            DialogosEstandar.MetMostrarExito("Registro guardado correctamente.");
            MetCargarModulos();
            MetLimpiarFormulario();
        }

        private void SeguridadBtnModificar_Click(object sender, EventArgs e)
        {
            if (!MetValidarCamposVisualmente()) return;

            string mensajeError = _moduloControlador.MetGuardarModulo(
                _idModuloSeleccionado, SeguridadTxtNombreModulo.Text, SeguridadTxtDescripcion.Text, SeguridadChkEstado.Checked);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                DialogosEstandar.MetMostrarError(mensajeError);
                return;
            }

            DialogosEstandar.MetMostrarExito("Registro modificado correctamente.");
            MetCargarModulos();
            MetLimpiarFormulario();
        }

        private void SeguridadBtnEliminar_Click(object sender, EventArgs e)
        {
            bool confirmado = DialogosEstandar.MetMostrarConfirmacion("¿Está seguro que desea eliminar este registro?");
            if (!confirmado) return;

            string mensajeError = _moduloControlador.MetEliminarModulo(_idModuloSeleccionado);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                DialogosEstandar.MetMostrarError(mensajeError);
                return;
            }

            DialogosEstandar.MetMostrarExito("Registro eliminado correctamente.");
            MetCargarModulos();
            MetLimpiarFormulario();
        }

        private void SeguridadBtnLimpiar_Click(object sender, EventArgs e)
        {
            MetLimpiarFormulario();
        }

        private void SeguridadBtnRefrescar_Click(object sender, EventArgs e)
        {
            MetCargarModulos();
            MetLimpiarFormulario();
        }

        private void SeguridadBtnAnterior_Click(object sender, EventArgs e)
        {
            _paginaActual--;
            MetMostrarPagina();
        }

        private void SeguridadBtnSiguiente_Click(object sender, EventArgs e)
        {
            _paginaActual++;
            MetMostrarPagina();
        }

        private void MetLimpiarFormulario()
        {
            _idModuloSeleccionado = 0;
            SeguridadTxtIdModulo.Text = "Nuevo";
            SeguridadTxtNombreModulo.Text = string.Empty;
            SeguridadTxtDescripcion.Text = string.Empty;
            SeguridadChkEstado.Checked = true;

            SeguridadTxtNombreModulo.BackColor = Color.White;
            SeguridadTxtDescripcion.BackColor = Color.White;
            SeguridadLblErrorNombre.Visible = false;
            SeguridadLblErrorDescripcion.Visible = false;

            MetHabilitarBoton(SeguridadBtnGuardar, false, ColorPrimario);
            MetHabilitarBoton(SeguridadBtnModificar, false, ColorPrimario);
            MetHabilitarBoton(SeguridadBtnEliminar, false, ColorAcento);

            SeguridadDgvListaModulos.ClearSelection();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmMantenimientoModulo
            // 
            this.ClientSize = new System.Drawing.Size(1177, 763);
            this.Name = "FrmMantenimientoModulo";
            this.Load += new System.EventHandler(this.FrmMantenimientoModulo_Load);
            this.ResumeLayout(false);

        }

        private void FrmMantenimientoModulo_Load(object sender, EventArgs e)
        {

        }
    }
}
