using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace App_VariableSesion
{
    public class LogicaN
    {
        //atributos
        SqlDataReader objReader;
        string strError;
        string contr;
        string usuario;
        //propiedades
        public string Usuario
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string Contr
        {
            set { contr = value; }
            get { return contr; }
        }
        public SqlDataReader GetReader
        {
            get { return objReader; }
        }
        public string geterror
        {
            get { return strError; }
        }


        public bool consultar()
        {
            string strSQL = "EXEC usp_validar '" + usuario + "','" + contr + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.Consultar(strSQL, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }
    }
}