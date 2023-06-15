﻿using Enumerado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteRodriguez
{
    public class Repositorio_Empleados : Interfaz_Padre<Empleado>
    {
        private static List<Empleado> listaEmpleado = new List<Empleado>();
        private readonly static Repositorio_Empleados repo_Empleados = new Repositorio_Empleados();
        public static List<Empleado> ListaEmpleado { get => listaEmpleado; set => listaEmpleado = value; }

        public static Repositorio_Empleados Repo_Empleados => repo_Empleados;
        /// <summary>
        /// Hardcodeo de Empleados
        /// </summary>
        public void Agregar()
        {
            if (ListaEmpleado.Count == 0)
            {/*
                ListaEmpleado.Add(new Empleado("Juan Pérez", "contra123", "juan.perez@gmail.com", true, 1, Puestos.Ventas));
                ListaEmpleado.Add(new Empleado("María García", "miClaveSegura", "maria.garcia@hotmail.com", true, 2, Puestos.Sistemas));
                ListaEmpleado.Add(new Empleado("Carlos Fernández", "qwerty1234", "cfernandez@empresa.com", true, 3, Puestos.Administracion));
                ListaEmpleado.Add(new Empleado("Sofía Rodríguez", "contrasena123", "sofiaro@gmail.com", true, 4, Puestos.Administracion));
                ListaEmpleado.Add(new Empleado("Pedro González", "contra4321", "pgonzalez@empresa.com", true, 5, Puestos.Cobranzas));*/
            }
        }
        /// <summary>
        /// Se obtiene la direccion de memoria de la instancia a travez de su id
        /// </summary>Se obtiene la direccion de memoria de la instancia a travez de su id
        /// <param name="idEmpleado"></param>
        /// <returns></returns>
        public Empleado BuscarInstanciaId(int idEmpleado)
        {
            List<Empleado> listaEmpleados = Conexion_SQL.ObtenerEmpleados("empleados");
            Empleado empleado = null;
            foreach (Empleado empleadoAuxiliar in listaEmpleados)
            {
                if (empleadoAuxiliar.IdEmpleado == idEmpleado)
                {

                    empleado = empleadoAuxiliar;
                    break;
                }
            }
            return empleado;
        }
        /// <summary>
        /// Calcular el id de un nuevo cliente  segun el ultimo 
        /// </summary>
        /// <returns></returns>
        public int CalcularId()
        {
            int retorno;
            Empleado ultimo = ListaEmpleado[ListaEmpleado.Count - 1];
            retorno = (ultimo.IdEmpleado) + 1;
            return retorno;
        }
        /// <summary>
        ///  Buscar instancia utilizando una sobre carga en el ==
        /// </summary>
        /// <param name="usuarioUno"></param>
        /// <returns></returns>
        public Empleado BuscarInstancia(Usuario usuarioUno)
        {
            List<Empleado> ListaEmpleados = Conexion_SQL.ObtenerEmpleados("empleados");
            Empleado retorno = null;
            foreach (Empleado empleado in ListaEmpleados)
            {
                if (empleado == usuarioUno && empleado.Estado == true)
                {
                    retorno = empleado;
                    break;
                }
            }
            return retorno;
        }
        public bool VerificarPuesto(Empleado empleado)
        {
            bool retorno = false;

            if (empleado.Puesto == Puestos.Sistemas)
            {
                retorno = true;
            }
            else
            {
                throw new Exception("Solo los empleados del sector sistemas pueden acceder a esta opcion");
            }
            return retorno;
        }
        public Empleado DarDeBaja(int id) 
        {
            return null;
        }
        public Empleado DarDeBaj(string ID, Empleado empleadoLogueado)
        {
            Empleado empleado = null;
            int idEntero;
            if (ID == "")
            {
                throw new Exception("ERROR, Ingrese un ID o elija una fila haciendole click");
            }
            else
            {
                if (int.TryParse(ID, out idEntero) == false)
                {
                    throw new Exception("ERROR, Ingrese un numero");
                }
                else
                {
                    empleado = BuscarInstanciaId(idEntero);
                    if (empleado is null)
                    {
                        throw new Exception("Empleado no encontrado");
                    }
                    else
                    {
                        if (empleadoLogueado == empleado)
                        {
                            throw new Exception("ERROR, No se puede eliminar asi mismo");

                        }
                        else
                        {
                            if (empleado.Estado == false)
                            {
                                throw new Exception("El empleado con ese ID ya se encontraba dado de baja");
                            }
                            else
                            {
                                // empleado.Estado = false;
                                Conexion_SQL.DarDeBaja(idEntero, "empleados", empleado);
                            }
                        }
                    }

                }
            }
            return empleado;

        }


        public bool CrearEmpleado(string nombre, string mail, string tipoMail, Puestos puesto)
        {
            string mailFinal;
            bool retorno = false;

            if (VerificarPuesto(puesto))
            {
                if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
                {
                    Empleado empleado = new Empleado(nombre, Sistema.generarContraseña(), mailFinal, true, puesto);
                    Conexion_SQL.Insertar(empleado, "empleados");
                    retorno = true;
                }
            }
            else
            {
                throw new Exception("ERROR, Ingrese puesto valido.");
            }

            return retorno;
        }
        /// <summary>
        /// Se realizaran las mismas verificaciones que al crear la instancia y nos apoyaremos de BuscarInstanciaId para afectar directamente
        /// a esa misma instancia
        /// </summary>
        /// <param name="id"></param>segun empleado elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - NO se modifica
        /// <param name="nombre"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="mail"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="tipoMail"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <param name="puesto"></param>segun cliente elegido en un dataGridView se obtiene mediante la propiedad y se pasa como parametro - MODIFICABLE
        /// <returns></returns>
        /// 
        public bool VerificarPuesto(Puestos puesto)
        {
            bool retorno = false;   
            string puestoAux = puesto.ToString();
            List<String> puestos = Conexion_SQL.ObtenerPuestos("puestos");
            foreach (string p in puestos)
            {
                if (puestoAux == p)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public bool ModificarEmpleado(int id,string nombre, string mail, string tipoMail, Puestos puesto)
         {
             string mailFinal;
             bool retorno = false;

            if (VerificarPuesto(puesto))
            {
                if (Validaciones.VerificarNombre(nombre) && Sistema.CrearMail(mail, tipoMail, out mailFinal))
                {
                    retorno = true;
                    Empleado empleado = BuscarInstanciaId(id);
                    empleado.Nombre = nombre;
                    empleado.Puesto = puesto;
                    empleado.Mail = mailFinal;
                    Conexion_SQL.Modificar(empleado, "empleados");
                }
            }
            else
            {
                throw new Exception("ERROR, Ingrese puesto valido.");
            }
            

             return retorno;
         }
     
    }
}