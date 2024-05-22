using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos.CrudConexiones;

namespace Negocio.Usuarios_cn
{
    public class N_Usuarios
    {
        private ConsultasUsuario obj_usuario = new ConsultasUsuario();

        //Metodo para mostrar en tabla
        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = obj_usuario.MostrarUsuarios();
            return tabla;
        }



    }
}
