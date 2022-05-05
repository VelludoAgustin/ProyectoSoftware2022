﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSoftwareIndividual;
using ProyectoSoftwareIndividual.Consultas;
using ProyectoSoftwareIndividual.Constructores;
using ProyectoSoftwareIndividual.Controladores;
using TrabajoPracticoIndividualProyectoSoftware.CrearTablas;

namespace ProyectoSoftwareIndividual.Menu
{
    public class MenuPrincipal
    {
        public void Menu()
        {
            List<EstadoDeAlquileres> ContadorEstados= new Consulta_Lista_de_Estados().ListarEstados();
            List<Libros> ContadorLibros = new Consulta_Lista_de_Libros().ListarLibros();
            if(ContadorEstados.Count==0)
            {
                new ConstructorEstadoDeAlquileres().InicializacionDeEstados();
            }
            if(ContadorLibros.Count==0)
            {
                new Constructor_de_Libro().InicializacionDeLibros();
            }



            int opcion = -1;
            while(opcion!=0)
            {
                try
                {
                    while (opcion != 0)
                    {
                        new Opciones_Menu().ImprimirMenu();
                        Console.WriteLine("Ingrese la opcion deseada");
                        opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1://Registrar nuevo Cliente
                                Console.Clear();
                                var opcion1 = new Controlador_de_Cliente();
                                opcion1.Controlador_CrearCliente();
                                Console.Clear();
                                break;
                            case 2://Registrar nuevo Alquiler
                                Console.Clear();
                                var opcion2 = new Controlador_de_Alquiler();
                                opcion2.Controlador_CrearAlquiler("Alquilado");
                                Console.Clear();
                                break;
                            case 3://Registrar nuevo Reserva
                                Console.Clear();
                                var opcion3 = new Controlador_de_Alquiler();
                                opcion3.Controlador_CrearAlquiler("Reservado");
                                Console.Clear();
                                break;
                            case 4://Enlistar las reservas con el detalle de los libros
                                Console.Clear();
                                var opcion4 = new Controlador_de_Alquiler();
                                opcion4.Controlador_ListarReservas();
                                Console.Clear();
                                break;
                            case 5://Enlistar la información de los libros de aquellos que se tenga stock
                                Console.Clear();
                                var opcion5 = new Controlador_de_Libros();
                                opcion5.Controlador_ImprimirLibrosConStock();
                                Console.Clear();
                                break;
                        }
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("No se ha introducido un numero correcto");
                    Console.ReadKey();
                }
            }
        }
    }
}
