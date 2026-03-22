using System;

// Practica pacientes POO 
//Raul estenio medina matos 2024-0211
using System.Collections.Generic;

namespace RegistroPacientes
{
    class Paciente
    {
        public int id;
        public string nombre;
        public string apellido;
        public string direccion;
        public string telefono;
        public string enfermedad;
        public int edad;
        public bool seguro;
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool runing = true;
            List<Paciente> pacientes = new List<Paciente>();

            Console.WriteLine("Bienvenido al sistema de registro de pacientes");

            while (runing)
            {
                Console.WriteLine("\n1. Agregar paciente");
                Console.WriteLine("2. Ver pacientes");
                Console.WriteLine("3. Buscar paciente");
                Console.WriteLine("4. Modificar paciente");
                Console.WriteLine("5. Eliminar paciente");
                Console.WriteLine("6. Salir");
                Console.Write("Elija una opcion: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarPaciente(pacientes);
                        break;

                    case 2:
                        VerPacientes(pacientes);
                        break;

                    case 3:
                        BuscarPaciente(pacientes);
                        break;

                    case 4:
                        ModificarPaciente(pacientes);
                        break;

                    case 5:
                        EliminarPaciente(pacientes);
                        break;

                    case 6:
                        runing = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        static void AgregarPaciente(List<Paciente> pacientes)
        {
            Paciente p = new Paciente();

            p.id = pacientes.Count + 1;

            Console.Write("Nombre: ");
            p.nombre = Console.ReadLine();

            Console.Write("Apellido: ");
            p.apellido = Console.ReadLine();

            Console.Write("Direccion: ");
            p.direccion = Console.ReadLine();

            Console.Write("Telefono: ");
            p.telefono = Console.ReadLine();

            Console.Write("Enfermedad: ");
            p.enfermedad = Console.ReadLine();

            Console.Write("Edad: ");
            p.edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tiene seguro? 1=Si 2=No: ");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                p.seguro = true;
            }
            else
            {
                p.seguro = false;
            }

            pacientes.Add(p);
            Console.WriteLine("Paciente agregado correctamente");
        }

        static void VerPacientes(List<Paciente> pacientes)
        {
            if (pacientes.Count == 0)
            {
                Console.WriteLine("No hay pacientes registrados");
                return;
            }

            foreach (Paciente p in pacientes)
            {
                string tieneSeguro;

                if (p.seguro == true)
                {
                    tieneSeguro = "Si";
                }
                else
                {
                    tieneSeguro = "No";
                }

                Console.WriteLine("\nID: " + p.id);
                Console.WriteLine("Nombre: " + p.nombre);
                Console.WriteLine("Apellido: " + p.apellido);
                Console.WriteLine("Direccion: " + p.direccion);
                Console.WriteLine("Telefono: " + p.telefono);
                Console.WriteLine("Enfermedad: " + p.enfermedad);
                Console.WriteLine("Edad: " + p.edad);
                Console.WriteLine("Seguro: " + tieneSeguro);
            }
        }

        static void BuscarPaciente(List<Paciente> pacientes)
        {
            Console.Write("Digite el nombre del paciente: ");
            string nombreBuscado = Console.ReadLine();

            bool encontrado = false;

            foreach (Paciente p in pacientes)
            {
                if (p.nombre.ToLower() == nombreBuscado.ToLower())
                {
                    Console.WriteLine("\nPaciente encontrado:");
                    Console.WriteLine("ID: " + p.id);
                    Console.WriteLine("Nombre: " + p.nombre);
                    Console.WriteLine("Apellido: " + p.apellido);
                    Console.WriteLine("Telefono: " + p.telefono);
                    Console.WriteLine("Enfermedad: " + p.enfermedad);
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Paciente no encontrado");
            }
        }

        static void ModificarPaciente(List<Paciente> pacientes)
        {
            Console.Write("Digite el ID del paciente a modificar: ");
            int idBuscado = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            foreach (Paciente p in pacientes)
            {
                if (p.id == idBuscado)
                {
                    Console.Write("Nuevo nombre: ");
                    p.nombre = Console.ReadLine();

                    Console.Write("Nuevo apellido: ");
                    p.apellido = Console.ReadLine();

                    Console.Write("Nueva direccion: ");
                    p.direccion = Console.ReadLine();

                    Console.Write("Nuevo telefono: ");
                    p.telefono = Console.ReadLine();

                    Console.Write("Nueva enfermedad: ");
                    p.enfermedad = Console.ReadLine();

                    Console.Write("Nueva edad: ");
                    p.edad = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Tiene seguro? 1=Si 2=No: ");
                    if (Convert.ToInt32(Console.ReadLine()) == 1)
                    {
                        p.seguro = true;
                    }
                    else
                    {
                        p.seguro = false;
                    }

                    Console.WriteLine("Paciente modificado");
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("No existe un paciente con ese ID");
            }
        }

        static void EliminarPaciente(List<Paciente> pacientes)
        {
            Console.Write("Digite el ID del paciente a eliminar: ");
            int idBuscado = Convert.ToInt32(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < pacientes.Count; i++)
            {
                if (pacientes[i].id == idBuscado)
                {
                    pacientes.RemoveAt(i);
                    Console.WriteLine("Paciente eliminado");
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("No existe un paciente con ese ID");
            }
        }
    }
}