using System;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Seguridad
{
    /// <summary>
    /// EST-10, Sección 3.2 — CapaModelo: acceso a datos (ODBC + SQL).
    /// Regla absoluta: SQL únicamente puede existir en esta capa.
    /// Tabla asumida: tbl_Modulo (IdModulo, NombreModulo, Descripcion, Estado)
    /// </summary>
    public class ClsModuloModelo
    {
        private readonly string _cadenaConexion;

        public ClsModuloModelo()
        {
            // Ajustar el DSN según la configuración real del proyecto (ODBC).
            _cadenaConexion = "DSN=TerminusDSN;";
        }

        public DataTable MetObtenerModulos()
        {
            DataTable dtModulos = new DataTable();

            using (OdbcConnection conexion = new OdbcConnection(_cadenaConexion))
            {
                string consultaSql = "SELECT IdModulo, NombreModulo, Descripcion, Estado " +
                                      "FROM tbl_Modulo ORDER BY IdModulo";

                using (OdbcDataAdapter adaptador = new OdbcDataAdapter(consultaSql, conexion))
                {
                    adaptador.Fill(dtModulos);
                }
            }

            return dtModulos;
        }

        public int MetInsertarModulo(string nombreModulo, string descripcion, bool estado)
        {
            using (OdbcConnection conexion = new OdbcConnection(_cadenaConexion))
            {
                conexion.Open();

                string consultaSql = "INSERT INTO tbl_Modulo (NombreModulo, Descripcion, Estado) " +
                                      "VALUES (?, ?, ?)";

                using (OdbcCommand comando = new OdbcCommand(consultaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreModulo", nombreModulo);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    return comando.ExecuteNonQuery();
                }
            }
        }

        public int MetModificarModulo(int idModulo, string nombreModulo, string descripcion, bool estado)
        {
            using (OdbcConnection conexion = new OdbcConnection(_cadenaConexion))
            {
                conexion.Open();

                string consultaSql = "UPDATE tbl_Modulo " +
                                      "SET NombreModulo = ?, Descripcion = ?, Estado = ? " +
                                      "WHERE IdModulo = ?";

                using (OdbcCommand comando = new OdbcCommand(consultaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreModulo", nombreModulo);
                    comando.Parameters.AddWithValue("@Descripcion", descripcion);
                    comando.Parameters.AddWithValue("@Estado", estado);
                    comando.Parameters.AddWithValue("@IdModulo", idModulo);
                    return comando.ExecuteNonQuery();
                }
            }
        }

        public int MetEliminarModulo(int idModulo)
        {
            using (OdbcConnection conexion = new OdbcConnection(_cadenaConexion))
            {
                conexion.Open();

                string consultaSql = "DELETE FROM tbl_Modulo WHERE IdModulo = ?";

                using (OdbcCommand comando = new OdbcCommand(consultaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@IdModulo", idModulo);
                    return comando.ExecuteNonQuery();
                }
            }
        }

        public bool MetExisteNombreModulo(string nombreModulo, int idModuloExcluir)
        {
            using (OdbcConnection conexion = new OdbcConnection(_cadenaConexion))
            {
                conexion.Open();

                string consultaSql = "SELECT COUNT(*) FROM tbl_Modulo " +
                                      "WHERE NombreModulo = ? AND IdModulo <> ?";

                using (OdbcCommand comando = new OdbcCommand(consultaSql, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreModulo", nombreModulo);
                    comando.Parameters.AddWithValue("@IdModuloExcluir", idModuloExcluir);
                    int totalCoincidencias = Convert.ToInt32(comando.ExecuteScalar());
                    return totalCoincidencias > 0;
                }
            }
        }
    }
}
