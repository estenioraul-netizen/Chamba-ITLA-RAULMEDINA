Console.WriteLine("Bienvenido a mi lista de Contactes");


//names, lastnames, addresses, telephones, emails, ages, bestfriend
bool runing = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


while (runing)
{
    Console.WriteLine(@"1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto        6. Salir");
    Console.WriteLine("Digite el número de la opción deseada");

    int typeOption = Convert.ToInt32(Console.ReadLine());

    switch (typeOption)
    {
        case 1:
            {
                //Console.WriteLine("Digite el nombre de la persona");
                //string name = Console.ReadLine();
                //Console.WriteLine("Digite el apellido de la persona");
                //string lastname = Console.ReadLine();
                //Console.WriteLine("Digite la dirección");
                //string address = Console.ReadLine();
                //Console.WriteLine("Digite el telefono de la persona");
                //string phone = Console.ReadLine();
                //Console.WriteLine("Digite el email de la persona");
                //string email = Console.ReadLine();
                //Console.WriteLine("Digite la edad de la persona en números");
                //int age = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");
                ////var temp = Convert.ToInt32(Console.ReadLine());
                ////bool isBestFriend;
                ////if (temp == 1)
                ////{ isBestFriend = true; }
                ////else
                ////{ isBestFriend = false; }
                //bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

                //var id = ids.Count + 1;
                //ids.Add(id);
                //names.Add(id, name);
                //lastnames.Add(id, lastname);
                //addresses.Add(id, address);
                //telephones.Add(id, phone);
                //emails.Add(id, email);
                //ages.Add(id, age);
                //bestFriends.Add(id, isBestFriend);

                AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);

            }
            break;
        case 2: //extract this to a method
            {
                Console.WriteLine($"Nombre          Apellido            Dirección           Telefono            Email           Edad            Es Mejor Amigo?");
                Console.WriteLine($"____________________________________________________________________________________________________________________________");
                foreach (var id in ids)
                {
                    var isBestFriend = bestFriends[id];

                    //string isBestFriendStr;

                    //if (isBestFriend == true)
                    //{
                    //    isBestFriendStr = "Si";
                    //}
                    //else {
                    //    isBestFriendStr = "No";
                    //}

                    string isBestFriendStr = (isBestFriend == true) ? "Si" : "No";
                    Console.WriteLine($"{names[id]}         {lastnames[id]}         {addresses[id]}         {telephones[id]}            {emails[id]}            {ages[id]}          {isBestFriendStr}");
                }

            }
            break;
        case 3: //buscar contacto
            {
                Console.WriteLine("Digite el nombre a buscar:");
                string searchName = Console.ReadLine();

                bool found = false;

                foreach (var id in ids)
                {
                    if (names[id].ToLower() == searchName.ToLower())
                    {
                        string isBestFriendStr = bestFriends[id] ? "Si" : "No";

                        Console.WriteLine($"{names[id]} {lastnames[id]} {addresses[id]} {telephones[id]} {emails[id]} {ages[id]} {isBestFriendStr}");
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Contacto no encontrado");
                }
            }
            break;

        case 4: // modificar contacto
            {
                Console.WriteLine("Digite el ID del contacto a modificar:");
                int id = Convert.ToInt32(Console.ReadLine());

                if (ids.Contains(id))
                {
                    Console.WriteLine("Nuevo nombre:");
                    names[id] = Console.ReadLine();

                    Console.WriteLine("Nuevo apellido:");
                    lastnames[id] = Console.ReadLine();

                    Console.WriteLine("Nueva direccion:");
                    addresses[id] = Console.ReadLine();

                    Console.WriteLine("Nuevo telefono:");
                    telephones[id] = Console.ReadLine();

                    Console.WriteLine("Nuevo email:");
                    emails[id] = Console.ReadLine();

                    Console.WriteLine("Nueva edad:");
                    ages[id] = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Es mejor amigo? 1=Si, 2=No:");
                    bestFriends[id] = Convert.ToInt32(Console.ReadLine()) == 1;

                    Console.WriteLine("Contacto modificado");
                }
                else
                {
                    Console.WriteLine("ID no existe");
                }
            }
            break;
        case 5: // eliminar contactos
            {
                Console.WriteLine("Digite el ID del contacto a eliminar:");
                int deleteId = Convert.ToInt32(Console.ReadLine());

                if (ids.Contains(deleteId))
                {
                    ids.Remove(deleteId);
                    names.Remove(deleteId);
                    lastnames.Remove(deleteId);
                    addresses.Remove(deleteId);
                    telephones.Remove(deleteId);
                    emails.Remove(deleteId);
                    ages.Remove(deleteId);
                    bestFriends.Remove(deleteId);

                    Console.WriteLine("Contacto eliminado correctamente");
                }
                else
                {
                    Console.WriteLine("ID no existe");
                }
            }
            break;
        case 6:
            runing = false;
            break;
        default:
            Console.WriteLine("Tu eres o te haces el idiota?");
            break;
    }
}


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("Digite el nombre de la persona");
    string name = Console.ReadLine();
    Console.WriteLine("Digite el apellido de la persona");
    string lastname = Console.ReadLine();
    Console.WriteLine("Digite la dirección");
    string address = Console.ReadLine();
    Console.WriteLine("Digite el telefono de la persona");
    string phone = Console.ReadLine();
    Console.WriteLine("Digite el email de la persona");
    string email = Console.ReadLine();
    Console.WriteLine("Digite la edad de la persona en números");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Especifique si es mejor amigo: 1. Si, 2. No");

    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);



    
}

