using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_Seguridad.Contratos
{
    public interface IRepositorioUsuarios : IRepositorioGenerico<ClsUsuarios>
    {
        //clase para validar el login del usuario
        ClsUsuarios SeguridadMetValidarLogin(string NombreUsuario, string ContrasenaUsuario);
    }
}