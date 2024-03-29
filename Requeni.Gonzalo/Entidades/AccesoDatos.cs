﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;
        
        public AccesoDatos()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);
        }

        public List<Persona> TraerTodos()
        {
            List<Persona> personas = new List<Persona>();
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "SELECT id,nombre,apellido,edad FROM Padron.dbo.Personas";
            try
            {
                this._conexion.Open();
                SqlDataReader lector = this._comando.ExecuteReader();
                while(lector.Read())
                {
                    Persona p = new Persona((int)lector["id"], lector["nombre"].ToString(), lector["apellido"].ToString(), (int)lector["edad"]);
                    personas.Add(p);
                }
                this._conexion.Close();
            }
            catch(Exception e)
            {

            }
            return personas;
        }

        public bool AgregarPersona(Persona p)
        {
            this._comando = new SqlCommand();
            this._comando.Connection = this._conexion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "INSERT INTO Padron.dbo.Personas (nombre,apellido,edad) VALUES ('" + p.nombre + "','" + p.apellido + "'," + p.edad.ToString() + ")";
            try
            {
                this._conexion.Open();
                if(this._comando.ExecuteNonQuery() > 0)
                {
                    this._conexion.Close();
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            return false;
        }
    }
}
