﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<MarcaDominio> listar()
        {
            List<MarcaDominio> listado = new List<MarcaDominio>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source = LAPTOP-41LKJ1NF\\SQLEXPRESS; initial catalog = CATALOGO_DB;integrated security = sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id,Descripcion from MARCAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    MarcaDominio aux = new MarcaDominio();
                    aux.Id = lector.GetInt32(0);
                    aux.Descripcion = lector.GetString(1);
                    listado.Add(aux);
                }

                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
