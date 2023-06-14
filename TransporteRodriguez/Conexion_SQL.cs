﻿using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace TransporteRodriguez
{
    public static class Conexion_SQL
    {
        private static MySqlConnection mysqlConexion;
        //Para consultas a la base uso query
        private static MySqlCommand query;
        //Credenciales de la conexion
        private static String cadenaConexion = "Server=localhost;Database=bd_transporte_rodriguez;Uid=root;Pwd='';";
        //El constructor se ejecutaria solo 1 vez porque es estatica la clase
        static Conexion_SQL()
        {
            mysqlConexion = new MySqlConnection(cadenaConexion);
        }
        public static void Conectar()
        {
            try
            {
                //Console.WriteLine("Conectando...");
                mysqlConexion.Open();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex);
            }
            finally
            {
                mysqlConexion.Close();
            }
        }
        public static void Insertar<T>(T gen, string nombreTabla)
        {
            mysqlConexion.Open();

            Type tipoDeObjeto = typeof(T);
            PropertyInfo[] propiedades = tipoDeObjeto.GetProperties();

            StringBuilder camposDb = new StringBuilder();
            StringBuilder values = new StringBuilder();
            for (int i = 0; i < propiedades.Length - 1; i++)
            {
                if (!propiedades[i].Name.ToLower().Contains("id"))
                {
                    camposDb.Append(propiedades[i].Name + ",");
                    values.Append("@" + propiedades[i].Name + ",");
                }
            }
            camposDb.Append(propiedades[propiedades.Length - 1].Name);
            values.Append("@" + propiedades[propiedades.Length - 1].Name);

            string consulta = $"INSERT INTO {nombreTabla} ({camposDb}) VALUES ({values})";
            query = new MySqlCommand(consulta, mysqlConexion);



            foreach (PropertyInfo propiedad in propiedades)
            {
                if (propiedad.GetValue(gen) is Enum)
                {
                    query.Parameters.AddWithValue($"@{propiedad.Name}", propiedad.GetValue(gen).ToString());
                }
                else
                {
                    query.Parameters.AddWithValue($"@{propiedad.Name}", propiedad.GetValue(gen));
                }
            }
            query.ExecuteNonQuery();
            mysqlConexion.Close();
        }

        public static void DarDeBaja<T>(int i, string nombreTabla, T gen)
        {
            mysqlConexion.Open();

            Type tipoDeObjeto = typeof(T);

            PropertyInfo[] propiedades = tipoDeObjeto.GetProperties();
            string camposDb = null;
            //ESTARIAMOS OBTENIENDO LA PRIMER PROPIEDAD QUE INCLUYA "id" QUE SERIA EL ID DEL OBJETO EN SI
            for (int j = 0; j < propiedades.Length - 1; j++)
            {
                if (propiedades[j].Name.ToLower().Contains("id"))
                {
                    camposDb = propiedades[j].Name;
                    break;
                }
            }

            string consulta = $"UPDATE {nombreTabla} SET Estado=0 WHERE {camposDb}={i}";
            query = new MySqlCommand(consulta, mysqlConexion);
            query.ExecuteNonQuery();
            mysqlConexion.Close();
        }
        public static List<String> ObtenerPuestos(string nombreTabla)
        {
            mysqlConexion.Open();
            List<String> lista = new List<String>();
            string consulta = $"SELECT * FROM {nombreTabla}";
            MySqlCommand query = new MySqlCommand(consulta, mysqlConexion);
            MySqlDataReader lectura = query.ExecuteReader();
            while (lectura.Read())
            {
                string puesto=lectura.GetString("Puesto");
                lista.Add(puesto);

            }

            mysqlConexion.Close();
            return lista;

        }
        public static List<Empleado> ObtenerEmpleado(string nombreTabla)
        {
        mysqlConexion.Open();
        List<Empleado> lista = new List<Empleado>();

        string consulta = $"SELECT * FROM {nombreTabla}";
        MySqlCommand query = new MySqlCommand(consulta, mysqlConexion);

        MySqlDataReader lectura = query.ExecuteReader();
        while (lectura.Read())
        {
            Empleado empleado = new Empleado();
            empleado.IdEmpleado = lectura.GetInt32("IdEmpleado");
            empleado.Puesto = (Puestos)Enum.Parse(typeof(Puestos), lectura.GetString("Puesto"));
            //empleado.Puesto = (Puestos)Enum.Parse(typeof(Puestos),lectura.GetString("Puesto"));
            empleado.Nombre = lectura.GetString("Nombre");
            empleado.Contraseña = lectura.GetString("Contraseña");
            empleado.Mail = lectura.GetString("Mail");
            empleado.Estado = lectura.GetBoolean("Estado");
            lista.Add(empleado);
        }
        mysqlConexion.Close();
        return lista;
        }

        public static void Modificar<T>(T gen, string nombreTabla)
        {
            //ABRO CONEXION
            mysqlConexion.Open();
            //OBTENGO EL TIPO DE OBJETO PARA ASI PODER ACCEDER A LAS PROPIEDADES
            Type tipoDeObjeto = typeof(T);
            //GUARDO LAS PROPIEDADES EN UN ARRAY DE TIPO PropertyInfo
            PropertyInfo[] propiedades = tipoDeObjeto.GetProperties();

            StringBuilder camposDb = new StringBuilder();
            //ITERO LA CATIDAD DE PROPIEDADES -1 PARA EVITAR LA ',' EN EL ULTIMO ELEMENTO
            for (int i = 0; i < propiedades.Length - 1; i++)
            {
                //VERIFICO QUE LA PROPIEDAD NO CONTENGA ID YA QUE EL MISMO NO SE PODRA MODIFICAR Y ES UNA PK
                if (!propiedades[i].Name.ToLower().Contains("id"))
                {
                    camposDb.Append(propiedades[i].Name + "=@" + propiedades[i].Name + ",");
                }
            }
            // LA ULTIMA PROPIEDAD ACTUALIZADA SE SUMA AL StringBuilder Y QUEDA SIN LA ','
            camposDb.Append($"{propiedades[propiedades.Length - 1].Name}=@{propiedades[propiedades.Length - 1].Name}");

            string consulta = $"UPDATE {nombreTabla} SET {camposDb} WHERE {propiedades[0].Name} = {propiedades[0].GetValue(gen)}";
            //ENVIO LA CONSULTA
            query = new MySqlCommand(consulta, mysqlConexion);
            //propiedad va ir tomando los valores de cada propiedad - de esta forma esten o no modificados los atributos, se pisaran.
            foreach (PropertyInfo propiedad in propiedades)
            {
                if (propiedad.GetValue(gen) is Enum)
                {
                    //
                    query.Parameters.AddWithValue($"@{propiedad.Name}", propiedad.GetValue(gen).ToString());
                }
                else
                {
                    query.Parameters.AddWithValue($"@{propiedad.Name}", propiedad.GetValue(gen));
                }
            }
            //EJECUTO INSTRUCCION
            query.ExecuteNonQuery();
            //CIERRO CONEXION
            mysqlConexion.Close();
        }
    }
}
