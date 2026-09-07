namespace CapaVista_Seguridad
{
    partial class FrmMantenimientoModulo
    {
        /// <summary>Variable de diseñador necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Limpia los recursos que se estén usando.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private System.Windows.Forms.Panel SeguridadPnlEncabezado;
        private System.Windows.Forms.Label SeguridadLblTitulo;

        private System.Windows.Forms.Panel SeguridadPnlFormulario;
        private System.Windows.Forms.Label SeguridadLblIdModulo;
        private System.Windows.Forms.TextBox SeguridadTxtIdModulo;
        private System.Windows.Forms.Label SeguridadLblNombreModulo;
        private System.Windows.Forms.TextBox SeguridadTxtNombreModulo;
        private System.Windows.Forms.Label SeguridadLblErrorNombre;
        private System.Windows.Forms.Label SeguridadLblDescripcion;
        private System.Windows.Forms.TextBox SeguridadTxtDescripcion;
        private System.Windows.Forms.Label SeguridadLblErrorDescripcion;
        private System.Windows.Forms.Label SeguridadLblEstado;
        private System.Windows.Forms.CheckBox SeguridadChkEstado;

        private System.Windows.Forms.Button SeguridadBtnGuardar;
        private System.Windows.Forms.Button SeguridadBtnModificar;
        private System.Windows.Forms.Button SeguridadBtnEliminar;
        private System.Windows.Forms.Button SeguridadBtnLimpiar;
        private System.Windows.Forms.Button SeguridadBtnRefrescar;

        private System.Windows.Forms.DataGridView SeguridadDgvListaModulos;

        private System.Windows.Forms.Panel SeguridadPnlPaginacion;
        private System.Windows.Forms.Label SeguridadLblResumenPaginacion;
        private System.Windows.Forms.Button SeguridadBtnAnterior;
        private System.Windows.Forms.Button SeguridadBtnSiguiente;

        /// <summary>
        /// Método requerido para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleEncabezado = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleAlternado = new System.Windows.Forms.DataGridViewCellStyle();

            this.SeguridadPnlEncabezado = new System.Windows.Forms.Panel();
            this.SeguridadLblTitulo = new System.Windows.Forms.Label();

            this.SeguridadPnlFormulario = new System.Windows.Forms.Panel();
            this.SeguridadLblIdModulo = new System.Windows.Forms.Label();
            this.SeguridadTxtIdModulo = new System.Windows.Forms.TextBox();
            this.SeguridadLblNombreModulo = new System.Windows.Forms.Label();
            this.SeguridadTxtNombreModulo = new System.Windows.Forms.TextBox();
            this.SeguridadLblErrorNombre = new System.Windows.Forms.Label();
            this.SeguridadLblDescripcion = new System.Windows.Forms.Label();
            this.SeguridadTxtDescripcion = new System.Windows.Forms.TextBox();
            this.SeguridadLblErrorDescripcion = new System.Windows.Forms.Label();
            this.SeguridadLblEstado = new System.Windows.Forms.Label();
            this.SeguridadChkEstado = new System.Windows.Forms.CheckBox();

            this.SeguridadBtnGuardar = new System.Windows.Forms.Button();
            this.SeguridadBtnModificar = new System.Windows.Forms.Button();
            this.SeguridadBtnEliminar = new System.Windows.Forms.Button();
            this.SeguridadBtnLimpiar = new System.Windows.Forms.Button();
            this.SeguridadBtnRefrescar = new System.Windows.Forms.Button();

            this.SeguridadDgvListaModulos = new System.Windows.Forms.DataGridView();

            this.SeguridadPnlPaginacion = new System.Windows.Forms.Panel();
            this.SeguridadLblResumenPaginacion = new System.Windows.Forms.Label();
            this.SeguridadBtnAnterior = new System.Windows.Forms.Button();
            this.SeguridadBtnSiguiente = new System.Windows.Forms.Button();

            this.SeguridadPnlEncabezado.SuspendLayout();
            this.SeguridadPnlFormulario.SuspendLayout();
            this.SeguridadPnlPaginacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvListaModulos)).BeginInit();
            this.SuspendLayout();

            // ---- SeguridadPnlEncabezado ----
            this.SeguridadPnlEncabezado.BackColor = ColorPrimario;
            this.SeguridadPnlEncabezado.Controls.Add(this.SeguridadLblTitulo);
            this.SeguridadPnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeguridadPnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.SeguridadPnlEncabezado.Name = "SeguridadPnlEncabezado";
            this.SeguridadPnlEncabezado.Size = new System.Drawing.Size(900, 60);
            this.SeguridadPnlEncabezado.TabIndex = 0;

            // ---- SeguridadLblTitulo ----
            this.SeguridadLblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeguridadLblTitulo.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.SeguridadLblTitulo.ForeColor = System.Drawing.Color.White;
            this.SeguridadLblTitulo.Location = new System.Drawing.Point(0, 0);
            this.SeguridadLblTitulo.Name = "SeguridadLblTitulo";
            this.SeguridadLblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SeguridadLblTitulo.Size = new System.Drawing.Size(900, 60);
            this.SeguridadLblTitulo.TabIndex = 0;
            this.SeguridadLblTitulo.Text = "Mantenimiento de Módulos";
            this.SeguridadLblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ---- SeguridadPnlFormulario ----
            this.SeguridadPnlFormulario.BackColor = System.Drawing.Color.White;
            this.SeguridadPnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadLblIdModulo);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadTxtIdModulo);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadLblNombreModulo);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadTxtNombreModulo);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadLblErrorNombre);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadLblEstado);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadChkEstado);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadLblDescripcion);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadTxtDescripcion);
            this.SeguridadPnlFormulario.Controls.Add(this.SeguridadLblErrorDescripcion);
            this.SeguridadPnlFormulario.Location = new System.Drawing.Point(20, 75);
            this.SeguridadPnlFormulario.Name = "SeguridadPnlFormulario";
            this.SeguridadPnlFormulario.Size = new System.Drawing.Size(850, 190);
            this.SeguridadPnlFormulario.TabIndex = 1;

            // ---- SeguridadLblIdModulo ----
            this.SeguridadLblIdModulo.AutoSize = true;
            this.SeguridadLblIdModulo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SeguridadLblIdModulo.Location = new System.Drawing.Point(20, 15);
            this.SeguridadLblIdModulo.Name = "SeguridadLblIdModulo";
            this.SeguridadLblIdModulo.Size = new System.Drawing.Size(52, 13);
            this.SeguridadLblIdModulo.TabIndex = 0;
            this.SeguridadLblIdModulo.Text = "Id Módulo";

            // ---- SeguridadTxtIdModulo ----
            this.SeguridadTxtIdModulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SeguridadTxtIdModulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SeguridadTxtIdModulo.Location = new System.Drawing.Point(20, 35);
            this.SeguridadTxtIdModulo.Name = "SeguridadTxtIdModulo";
            this.SeguridadTxtIdModulo.ReadOnly = true;
            this.SeguridadTxtIdModulo.Size = new System.Drawing.Size(100, 20);
            this.SeguridadTxtIdModulo.TabIndex = 1;

            // ---- SeguridadLblNombreModulo ----
            this.SeguridadLblNombreModulo.AutoSize = true;
            this.SeguridadLblNombreModulo.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SeguridadLblNombreModulo.ForeColor = ColorErrorBorde;
            this.SeguridadLblNombreModulo.Location = new System.Drawing.Point(140, 15);
            this.SeguridadLblNombreModulo.Name = "SeguridadLblNombreModulo";
            this.SeguridadLblNombreModulo.Size = new System.Drawing.Size(97, 13);
            this.SeguridadLblNombreModulo.TabIndex = 2;
            this.SeguridadLblNombreModulo.Text = "Nombre módulo *";

            // ---- SeguridadTxtNombreModulo ----
            this.SeguridadTxtNombreModulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SeguridadTxtNombreModulo.Location = new System.Drawing.Point(140, 35);
            this.SeguridadTxtNombreModulo.MaxLength = 60;
            this.SeguridadTxtNombreModulo.Name = "SeguridadTxtNombreModulo";
            this.SeguridadTxtNombreModulo.Size = new System.Drawing.Size(280, 20);
            this.SeguridadTxtNombreModulo.TabIndex = 3;
            this.SeguridadTxtNombreModulo.TextChanged += new System.EventHandler(this.SeguridadTxtNombreModulo_TextChanged);

            // ---- SeguridadLblErrorNombre ----
            this.SeguridadLblErrorNombre.AutoSize = true;
            this.SeguridadLblErrorNombre.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SeguridadLblErrorNombre.ForeColor = ColorErrorBorde;
            this.SeguridadLblErrorNombre.Location = new System.Drawing.Point(140, 60);
            this.SeguridadLblErrorNombre.Name = "SeguridadLblErrorNombre";
            this.SeguridadLblErrorNombre.Size = new System.Drawing.Size(0, 11);
            this.SeguridadLblErrorNombre.TabIndex = 4;
            this.SeguridadLblErrorNombre.Visible = false;

            // ---- SeguridadLblEstado ----
            this.SeguridadLblEstado.AutoSize = true;
            this.SeguridadLblEstado.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SeguridadLblEstado.Location = new System.Drawing.Point(440, 15);
            this.SeguridadLblEstado.Name = "SeguridadLblEstado";
            this.SeguridadLblEstado.Size = new System.Drawing.Size(38, 13);
            this.SeguridadLblEstado.TabIndex = 5;
            this.SeguridadLblEstado.Text = "Estado";

            // ---- SeguridadChkEstado ----
            this.SeguridadChkEstado.AutoSize = true;
            this.SeguridadChkEstado.Checked = true;
            this.SeguridadChkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SeguridadChkEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SeguridadChkEstado.Location = new System.Drawing.Point(440, 35);
            this.SeguridadChkEstado.Name = "SeguridadChkEstado";
            this.SeguridadChkEstado.Size = new System.Drawing.Size(58, 17);
            this.SeguridadChkEstado.TabIndex = 6;
            this.SeguridadChkEstado.Text = "Activo";
            this.SeguridadChkEstado.UseVisualStyleBackColor = true;
            this.SeguridadChkEstado.CheckedChanged += new System.EventHandler(this.SeguridadChkEstado_CheckedChanged);

            // ---- SeguridadLblDescripcion ----
            this.SeguridadLblDescripcion.AutoSize = true;
            this.SeguridadLblDescripcion.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SeguridadLblDescripcion.ForeColor = ColorErrorBorde;
            this.SeguridadLblDescripcion.Location = new System.Drawing.Point(20, 90);
            this.SeguridadLblDescripcion.Name = "SeguridadLblDescripcion";
            this.SeguridadLblDescripcion.Size = new System.Drawing.Size(72, 13);
            this.SeguridadLblDescripcion.TabIndex = 7;
            this.SeguridadLblDescripcion.Text = "Descripción *";

            // ---- SeguridadTxtDescripcion ----
            this.SeguridadTxtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SeguridadTxtDescripcion.Location = new System.Drawing.Point(20, 110);
            this.SeguridadTxtDescripcion.MaxLength = 200;
            this.SeguridadTxtDescripcion.Multiline = true;
            this.SeguridadTxtDescripcion.Name = "SeguridadTxtDescripcion";
            this.SeguridadTxtDescripcion.Size = new System.Drawing.Size(400, 45);
            this.SeguridadTxtDescripcion.TabIndex = 8;
            this.SeguridadTxtDescripcion.TextChanged += new System.EventHandler(this.SeguridadTxtDescripcion_TextChanged);

            // ---- SeguridadLblErrorDescripcion ----
            this.SeguridadLblErrorDescripcion.AutoSize = true;
            this.SeguridadLblErrorDescripcion.Font = new System.Drawing.Font("Tahoma", 8F);
            this.SeguridadLblErrorDescripcion.ForeColor = ColorErrorBorde;
            this.SeguridadLblErrorDescripcion.Location = new System.Drawing.Point(20, 158);
            this.SeguridadLblErrorDescripcion.Name = "SeguridadLblErrorDescripcion";
            this.SeguridadLblErrorDescripcion.Size = new System.Drawing.Size(0, 11);
            this.SeguridadLblErrorDescripcion.TabIndex = 9;
            this.SeguridadLblErrorDescripcion.Visible = false;

            // ---- SeguridadBtnGuardar ----
            this.SeguridadBtnGuardar.BackColor = ColorPrimario;
            this.SeguridadBtnGuardar.Enabled = false;
            this.SeguridadBtnGuardar.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.SeguridadBtnGuardar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnGuardar.Location = new System.Drawing.Point(20, 280);
            this.SeguridadBtnGuardar.Name = "SeguridadBtnGuardar";
            this.SeguridadBtnGuardar.Size = new System.Drawing.Size(120, 35);
            this.SeguridadBtnGuardar.TabIndex = 2;
            this.SeguridadBtnGuardar.Text = "Guardar";
            this.SeguridadBtnGuardar.UseVisualStyleBackColor = false;
            this.SeguridadBtnGuardar.Click += new System.EventHandler(this.SeguridadBtnGuardar_Click);

            // ---- SeguridadBtnModificar ----
            this.SeguridadBtnModificar.BackColor = ColorPrimario;
            this.SeguridadBtnModificar.Enabled = false;
            this.SeguridadBtnModificar.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnModificar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.SeguridadBtnModificar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnModificar.Location = new System.Drawing.Point(150, 280);
            this.SeguridadBtnModificar.Name = "SeguridadBtnModificar";
            this.SeguridadBtnModificar.Size = new System.Drawing.Size(120, 35);
            this.SeguridadBtnModificar.TabIndex = 3;
            this.SeguridadBtnModificar.Text = "Modificar";
            this.SeguridadBtnModificar.UseVisualStyleBackColor = false;
            this.SeguridadBtnModificar.Click += new System.EventHandler(this.SeguridadBtnModificar_Click);

            // ---- SeguridadBtnEliminar ----
            this.SeguridadBtnEliminar.BackColor = ColorAcento;
            this.SeguridadBtnEliminar.Enabled = false;
            this.SeguridadBtnEliminar.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.SeguridadBtnEliminar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnEliminar.Location = new System.Drawing.Point(280, 280);
            this.SeguridadBtnEliminar.Name = "SeguridadBtnEliminar";
            this.SeguridadBtnEliminar.Size = new System.Drawing.Size(120, 35);
            this.SeguridadBtnEliminar.TabIndex = 4;
            this.SeguridadBtnEliminar.Text = "Eliminar";
            this.SeguridadBtnEliminar.UseVisualStyleBackColor = false;
            this.SeguridadBtnEliminar.Click += new System.EventHandler(this.SeguridadBtnEliminar_Click);

            // ---- SeguridadBtnLimpiar ----
            this.SeguridadBtnLimpiar.BackColor = ColorSecundario;
            this.SeguridadBtnLimpiar.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.SeguridadBtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnLimpiar.Location = new System.Drawing.Point(410, 280);
            this.SeguridadBtnLimpiar.Name = "SeguridadBtnLimpiar";
            this.SeguridadBtnLimpiar.Size = new System.Drawing.Size(120, 35);
            this.SeguridadBtnLimpiar.TabIndex = 5;
            this.SeguridadBtnLimpiar.Text = "Limpiar";
            this.SeguridadBtnLimpiar.UseVisualStyleBackColor = false;
            this.SeguridadBtnLimpiar.Click += new System.EventHandler(this.SeguridadBtnLimpiar_Click);

            // ---- SeguridadBtnRefrescar ----
            this.SeguridadBtnRefrescar.BackColor = ColorSecundario;
            this.SeguridadBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnRefrescar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.SeguridadBtnRefrescar.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnRefrescar.Location = new System.Drawing.Point(540, 280);
            this.SeguridadBtnRefrescar.Name = "SeguridadBtnRefrescar";
            this.SeguridadBtnRefrescar.Size = new System.Drawing.Size(120, 35);
            this.SeguridadBtnRefrescar.TabIndex = 6;
            this.SeguridadBtnRefrescar.Text = "Refrescar";
            this.SeguridadBtnRefrescar.UseVisualStyleBackColor = false;
            this.SeguridadBtnRefrescar.Click += new System.EventHandler(this.SeguridadBtnRefrescar_Click);

            // ---- dataGridViewCellStyleEncabezado ----
            dataGridViewCellStyleEncabezado.BackColor = ColorPrimario;
            dataGridViewCellStyleEncabezado.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyleEncabezado.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyleEncabezado.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            // ---- dataGridViewCellStyleAlternado ----
            dataGridViewCellStyleAlternado.BackColor = ColorFondo;

            // ---- SeguridadDgvListaModulos ----
            this.SeguridadDgvListaModulos.AllowUserToAddRows = false;
            this.SeguridadDgvListaModulos.AllowUserToDeleteRows = false;
            this.SeguridadDgvListaModulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyleAlternado;
            this.SeguridadDgvListaModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SeguridadDgvListaModulos.BackgroundColor = System.Drawing.Color.White;
            this.SeguridadDgvListaModulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyleEncabezado;
            this.SeguridadDgvListaModulos.EnableHeadersVisualStyles = false;
            this.SeguridadDgvListaModulos.Location = new System.Drawing.Point(20, 325);
            this.SeguridadDgvListaModulos.MultiSelect = false;
            this.SeguridadDgvListaModulos.Name = "SeguridadDgvListaModulos";
            this.SeguridadDgvListaModulos.ReadOnly = true;
            this.SeguridadDgvListaModulos.RowHeadersVisible = false;
            this.SeguridadDgvListaModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SeguridadDgvListaModulos.Size = new System.Drawing.Size(850, 220);
            this.SeguridadDgvListaModulos.TabIndex = 7;
            this.SeguridadDgvListaModulos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeguridadDgvListaModulos_ColumnHeaderMouseClick);
            this.SeguridadDgvListaModulos.SelectionChanged += new System.EventHandler(this.SeguridadDgvListaModulos_SelectionChanged);

            // ---- SeguridadPnlPaginacion ----
            this.SeguridadPnlPaginacion.Controls.Add(this.SeguridadLblResumenPaginacion);
            this.SeguridadPnlPaginacion.Controls.Add(this.SeguridadBtnAnterior);
            this.SeguridadPnlPaginacion.Controls.Add(this.SeguridadBtnSiguiente);
            this.SeguridadPnlPaginacion.Location = new System.Drawing.Point(20, 555);
            this.SeguridadPnlPaginacion.Name = "SeguridadPnlPaginacion";
            this.SeguridadPnlPaginacion.Size = new System.Drawing.Size(850, 35);
            this.SeguridadPnlPaginacion.TabIndex = 8;

            // ---- SeguridadLblResumenPaginacion ----
            this.SeguridadLblResumenPaginacion.AutoSize = true;
            this.SeguridadLblResumenPaginacion.Font = new System.Drawing.Font("Tahoma", 9F);
            this.SeguridadLblResumenPaginacion.Location = new System.Drawing.Point(0, 8);
            this.SeguridadLblResumenPaginacion.Name = "SeguridadLblResumenPaginacion";
            this.SeguridadLblResumenPaginacion.Size = new System.Drawing.Size(0, 13);
            this.SeguridadLblResumenPaginacion.TabIndex = 0;

            // ---- SeguridadBtnAnterior ----
            this.SeguridadBtnAnterior.BackColor = ColorSecundario;
            this.SeguridadBtnAnterior.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnAnterior.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.SeguridadBtnAnterior.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnAnterior.Location = new System.Drawing.Point(650, 0);
            this.SeguridadBtnAnterior.Name = "SeguridadBtnAnterior";
            this.SeguridadBtnAnterior.Size = new System.Drawing.Size(90, 30);
            this.SeguridadBtnAnterior.TabIndex = 1;
            this.SeguridadBtnAnterior.Text = "Anterior";
            this.SeguridadBtnAnterior.UseVisualStyleBackColor = false;
            this.SeguridadBtnAnterior.Click += new System.EventHandler(this.SeguridadBtnAnterior_Click);

            // ---- SeguridadBtnSiguiente ----
            this.SeguridadBtnSiguiente.BackColor = ColorSecundario;
            this.SeguridadBtnSiguiente.FlatAppearance.BorderSize = 0;
            this.SeguridadBtnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeguridadBtnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.SeguridadBtnSiguiente.ForeColor = System.Drawing.Color.White;
            this.SeguridadBtnSiguiente.Location = new System.Drawing.Point(750, 0);
            this.SeguridadBtnSiguiente.Name = "SeguridadBtnSiguiente";
            this.SeguridadBtnSiguiente.Size = new System.Drawing.Size(100, 30);
            this.SeguridadBtnSiguiente.TabIndex = 2;
            this.SeguridadBtnSiguiente.Text = "Siguiente";
            this.SeguridadBtnSiguiente.UseVisualStyleBackColor = false;
            this.SeguridadBtnSiguiente.Click += new System.EventHandler(this.SeguridadBtnSiguiente_Click);

            // ---- FrmMantenimientoModulo ----
            this.BackColor = ColorFondo;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.SeguridadDgvListaModulos);
            this.Controls.Add(this.SeguridadPnlPaginacion);
            this.Controls.Add(this.SeguridadBtnGuardar);
            this.Controls.Add(this.SeguridadBtnModificar);
            this.Controls.Add(this.SeguridadBtnEliminar);
            this.Controls.Add(this.SeguridadBtnLimpiar);
            this.Controls.Add(this.SeguridadBtnRefrescar);
            this.Controls.Add(this.SeguridadPnlFormulario);
            this.Controls.Add(this.SeguridadPnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMantenimientoModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2004 - MantenimientoModulo";

            this.SeguridadPnlEncabezado.ResumeLayout(false);
            this.SeguridadPnlFormulario.ResumeLayout(false);
            this.SeguridadPnlFormulario.PerformLayout();
            this.SeguridadPnlPaginacion.ResumeLayout(false);
            this.SeguridadPnlPaginacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeguridadDgvListaModulos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}