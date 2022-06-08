using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace TiendaDatos
{
    class AppConexion
    {
        public static string CadenaConexion()
        {
            string baseDatos = ConfigurationManager.AppSettings["BaseDatos"];
            string server = ConfigurationManager.AppSettings["Servidor"];
            string Usuario = ConfigurationManager.AppSettings["Usuario"];
            string Password = ConfigurationManager.AppSettings["Password"];

            string cadenaAuxiliar = $"Server={server}; Database ={baseDatos}; UID ={Usuario}; PWD ={Password}";
            string cadenaConexion = $"metadata=res://*/TiendaWebModel.csdl|res://*/TiendaWebModel.ssdl|res://*/TiendaWebModel.msl;" +
                                    $"provider=System.Data.SqlClient;provider connection string='{cadenaAuxiliar}'";

            return cadenaConexion;
        }
    }
}
