﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.LoginConexion;

namespace Negocio.Login_cn
{
    public class Usuario_N
    {
        DatosUsuario userdatos = new DatosUsuario();
        public bool LoginUsuario(string usuario, string pass)
        {
            return userdatos.Login(usuario, pass);
        }
    }
}
