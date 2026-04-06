using System;
using System.Collections.Generic;

Console.WriteLine("Bienvenido al sistema de registro de pacientes");

bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> nombres = new Dictionary<int, string>();
Dictionary<int, string> apellidos = new Dictionary<int, string>();
Dictionary<int, string> direcciones = new Dictionary<int, string>();
Dictionary<int, string> telefonos = new Dictionary<int, string>();
Dictionary<int, string> enfermedades = new Dictionary<int, string>();
Dictionary<int, int> edades = new Dictionary<int, int>();
Dictionary<int, bool> seguros = new Dictionary<int, bool>();

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
            AgregarPaciente(ids, nombres, apellidos, direcciones, telefonos, enfermedades, edades, seguros);
            break;

        case 2:
            VerPacientes(ids, nombres, apellidos, direcciones, telefonos, enfermedades, edades, seguros);
            break;

        case 3:
            BuscarPaciente(ids, nombres, apellidos, telefonos, enfermedades);
            break;

        case 4:
            ModificarPaciente(ids, nombres, apellidos, direcciones, telefonos, enfermedades, edades, seguros);
            break;

        case 5:
            EliminarPaciente(ids, nombres, apellidos, direcciones, telefonos, enfermedades, edades, seguros);
            break;

        case 6:
            runing = false;
            break;

        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}

static void AgregarPaciente(
    List<int> ids,
    Dictionary<int, string> nombres,
    Dictionary<int, string> apellidos,
    Dictionary<int, string> direcciones,
    Dictionary<int, string> telefonos,
    Dictionary<int, string> enfermedades,
    Dictionary<int, int> edades,
    Dictionary<int, bool> seguros)
{
    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Apellido: ");
    string apellido = Console.ReadLine();

    Console.Write("Direccion: ");
    string direccion = Console.ReadLine();

    Console.Write("Telefono: ");
    string telefono = Console.ReadLine();

    Console.Write("Enfermedad: ");
    string enfermedad = Console.ReadLine();

    Console.Write("Edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.Write("Tiene seguro? 1=Si 2=No: ");
    bool seguro = Convert.ToInt32(Console.ReadLine()) == 1;

    int id = ids.Count + 1;

    ids.Add(id);
    nombres.Add(id, nombre);
    apellidos.Add(id, apellido);
    direcciones.Add(id, direccion);
    telefonos.Add(id, telefono);
    enfermedades.Add(id, enfermedad);
    edades.Add(id, edad);
    seguros.Add(id, seguro);

    Console.WriteLine("Paciente agregado correctamente");
}

static void VerPacientes(
    List<int> ids,
    Dictionary<int, string> nombres,
    Dictionary<int, string> apellidos,
    Dictionary<int, string> direcciones,
    Dictionary<int, string> telefonos,
    Dictionary<int, string> enfermedades,
    Dictionary<int, int> edades,
    Dictionary<int, bool> seguros)
{
    if (ids.Count == 0)
    {
        Console.WriteLine("No hay pacientes registrados");
        return;
    }

    foreach (int id in ids)
    {
        string textoSeguro = seguros[id] ? "Si" : "No";

        Console.WriteLine("\nID: " + id);
        Console.WriteLine("Nombre: " + nombres[id]);
        Console.WriteLine("Apellido: " + apellidos[id]);
        Console.WriteLine("Direccion: " + direcciones[id]);
        Console.WriteLine("Telefono: " + telefonos[id]);
        Console.WriteLine("Enfermedad: " + enfermedades[id]);
        Console.WriteLine("Edad: " + edades[id]);
        Console.WriteLine("Seguro: " + textoSeguro);
    }
}

static void BuscarPaciente(
    List<int> ids,
    Dictionary<int, string> nombres,
    Dictionary<int, string> apellidos,
    Dictionary<int, string> telefonos,
    Dictionary<int, string> enfermedades)
{
    Console.Write("Digite el nombre del paciente: ");
    string nombreBuscado = Console.ReadLine().ToLower();

    bool encontrado = false;

    foreach (int id in ids)
    {
        if (nombres[id].ToLower() == nombreBuscado)
        {
            Console.WriteLine("\nPaciente encontrado:");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nombre: " + nombres[id]);
            Console.WriteLine("Apellido: " + apellidos[id]);
            Console.WriteLine("Telefono: " + telefonos[id]);
            Console.WriteLine("Enfermedad: " + enfermedades[id]);
            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Paciente no encontrado");
    }
}

static void ModificarPaciente(
    List<int> ids,
    Dictionary<int, string> nombres,
    Dictionary<int, string> apellidos,
    Dictionary<int, string> direcciones,
    Dictionary<int, string> telefonos,
    Dictionary<int, string> enfermedades,
    Dictionary<int, int> edades,
    Dictionary<int, bool> seguros)
{
    Console.Write("Digite el ID del paciente a modificar: ");
    int idBuscado = Convert.ToInt32(Console.ReadLine());

    if (!ids.Contains(idBuscado))
    {
        Console.WriteLine("No existe un paciente con ese ID");
        return;
    }

    Console.Write("Nuevo nombre: ");
    nombres[idBuscado] = Console.ReadLine();

    Console.Write("Nuevo apellido: ");
    apellidos[idBuscado] = Console.ReadLine();

    Console.Write("Nueva direccion: ");
    direcciones[idBuscado] = Console.ReadLine();

    Console.Write("Nuevo telefono: ");
    telefonos[idBuscado] = Console.ReadLine();

    Console.Write("Nueva enfermedad: ");
    enfermedades[idBuscado] = Console.ReadLine();

    Console.Write("Nueva edad: ");
    edades[idBuscado] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Tiene seguro? 1=Si 2=No: ");
    seguros[idBuscado] = Convert.ToInt32(Console.ReadLine()) == 1;

    Console.WriteLine("Paciente modificado");
}

static void EliminarPaciente(
    List<int> ids,
    Dictionary<int, string> nombres,
    Dictionary<int, string> apellidos,
    Dictionary<int, string> direcciones,
    Dictionary<int, string> telefonos,
    Dictionary<int, string> enfermedades,
    Dictionary<int, int> edades,
    Dictionary<int, bool> seguros)
{
    Console.Write("Digite el ID del paciente a eliminar: ");
    int idBuscado = Convert.ToInt32(Console.ReadLine());

    if (!ids.Contains(idBuscado))
    {
        Console.WriteLine("No existe un paciente con ese ID");
        return;
    }

    ids.Remove(idBuscado);
    nombres.Remove(idBuscado);
    apellidos.Remove(idBuscado);
    direcciones.Remove(idBuscado);
    telefonos.Remove(idBuscado);
    enfermedades.Remove(idBuscado);
    edades.Remove(idBuscado);
    seguros.Remove(idBuscado);

    Console.WriteLine("Paciente eliminado");
}