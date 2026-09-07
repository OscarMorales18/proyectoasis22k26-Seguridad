using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    /// <summary>
    /// EST-10, Sección 6 — Estándar de Mensajes y Diálogos.
    /// Usa el predeterminado de Visual Studio (icono + botones estándar de MessageBox),
    /// respetando el ícono y el color que exige el documento para cada caso.
    /// Reutilizable por cualquier formulario del sistema.
    /// </summary>
    public static class DialogosEstandar
    {
        /// <summary>Confirmación — ícono de advertencia (ámbar). Botones "No" / "Sí, eliminar".</summary>
        public static bool MetMostrarConfirmacion(string mensaje)
        {
            DialogResult resultado = MessageBox.Show(
                mensaje,
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            return resultado == DialogResult.Yes;
        }

        /// <summary>Éxito — ícono de verificación (verde). Un solo botón "Aceptar".</summary>
        public static void MetMostrarExito(string mensaje)
        {
            MessageBox.Show(mensaje, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>Error — ícono de X (rojo). Un solo botón "Aceptar".</summary>
        public static void MetMostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
