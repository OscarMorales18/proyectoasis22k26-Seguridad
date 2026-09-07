using System;
using System.Data;
using CapaModelo_Seguridad;

namespace CapaControlador_Seguridad
{
    /// <summary>
    /// EST-10, Sección 3.3 — CapaControlador: lógica de negocio.
    /// Recibe llamadas de la CapaVista, valida y comunica con la CapaModelo.
    /// Cada acción del usuario corresponde a una única responsabilidad clara.
    /// </summary>
    public class ClsModuloControlador
    {
        private readonly ClsModuloModelo _moduloModelo;

        public ClsModuloControlador()
        {
            _moduloModelo = new ClsModuloModelo();
        }

        public DataTable MetListarModulos()
        {
            return _moduloModelo.MetObtenerModulos();
        }

        /// <summary>
        /// Valida los datos capturados. Regresa cadena vacía si son válidos,
        /// o el mensaje de error a mostrar si no lo son.
        /// </summary>
        public string MetValidarDatos(string nombreModulo, string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombreModulo))
                return "El nombre del módulo es obligatorio.";

            if (nombreModulo.Trim().Length < 3)
                return "El nombre del módulo debe tener al menos 3 caracteres.";

            if (string.IsNullOrWhiteSpace(descripcion))
                return "La descripción es obligatoria.";

            return string.Empty;
        }

        /// <summary>
        /// Guarda (inserta o modifica según IdModulo) un registro.
        /// Regresa cadena vacía si todo salió bien, o el mensaje de error.
        /// </summary>
        public string MetGuardarModulo(int idModulo, string nombreModulo, string descripcion, bool estado)
        {
            string mensajeValidacion = MetValidarDatos(nombreModulo, descripcion);
            if (!string.IsNullOrEmpty(mensajeValidacion))
                return mensajeValidacion;

            if (_moduloModelo.MetExisteNombreModulo(nombreModulo.Trim(), idModulo))
                return "Ya existe un módulo con ese nombre.";

            try
            {
                if (idModulo == 0)
                    _moduloModelo.MetInsertarModulo(nombreModulo.Trim(), descripcion.Trim(), estado);
                else
                    _moduloModelo.MetModificarModulo(idModulo, nombreModulo.Trim(), descripcion.Trim(), estado);

                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Ocurrió un error al guardar: " + ex.Message;
            }
        }

        public string MetEliminarModulo(int idModulo)
        {
            try
            {
                _moduloModelo.MetEliminarModulo(idModulo);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Ocurrió un error al eliminar: " + ex.Message;
            }
        }
    }
}
