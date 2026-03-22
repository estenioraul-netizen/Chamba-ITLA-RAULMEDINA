using System;
//Raul estenio medina matos 2024-0211

using System.Collections.Generic;

namespace AgendaPersonal
{
    class Contactes
    {
        public int id;
        public string name;
        public string lastname;
        public string address;
        public string telephone;
        public string email;
        public int age;
        public bool bestFriend;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a mi lista de Contactes");

            bool runing = true;
            List<Contactes> contacts = new List<Contactes>();

            while (runing)
            {
                Console.WriteLine("1. Agregar Contacto     2. Ver Contactos    3. Buscar Contactos     4. Modificar Contacto   5. Eliminar Contacto     6. Salir");
                Console.WriteLine("Digite el numero de la opcion deseada");

                int typeOption = Convert.ToInt32(Console.ReadLine());

                switch (typeOption)
                {
                    case 1:
                        {
                            AddContact(contacts);
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("Nombre   Apellido   Direccion   Telefono   Email   Edad   MejorAmigo");
                            Console.WriteLine("////////////----------------------------------//////////////////////");

                            foreach (Contactes contact in contacts)
                            {
                                string isBestFriendStr;

                                if (contact.bestFriend == true)
                                {
                                    isBestFriendStr = "Si";
                                }
                                else
                                {
                                    isBestFriendStr = "No";
                                }

                                Console.WriteLine(contact.name + " " + contact.lastname + " " + contact.address + " " + contact.telephone + " " + contact.email + " " + contact.age + " " + isBestFriendStr);
                            }
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("Digite el nombre a buscar:");
                            string searchName = Console.ReadLine();

                            bool found = false;

                            foreach (Contactes contact in contacts)
                            {
                                if (contact.name.ToLower() == searchName.ToLower())
                                {
                                    string isBestFriendStr;

                                    if (contact.bestFriend == true)
                                    {
                                        isBestFriendStr = "Si";
                                    }
                                    else
                                    {
                                        isBestFriendStr = "No";
                                    }

                                    Console.WriteLine(contact.name + " " + contact.lastname + " " + contact.telephone);
                                    found = true;
                                }
                            }

                            if (found == false)
                            {
                                Console.WriteLine("Contacto no encontrado");
                            }
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Digite el ID del contacto a modificar:");
                            int id = Convert.ToInt32(Console.ReadLine());

                            bool found = false;

                            foreach (Contactes contact in contacts)
                            {
                                if (contact.id == id)
                                {
                                    Console.WriteLine("Nuevo nombre:");
                                    contact.name = Console.ReadLine();

                                    Console.WriteLine("Nuevo telefono:");
                                    contact.telephone = Console.ReadLine();

                                    Console.WriteLine("Contacto modificado");
                                    found = true;
                                }
                            }

                            if (found == false)
                            {
                                Console.WriteLine("ID no existe");
                            }
                        }
                        break;

                    case 5:
                        {
                            Console.WriteLine("Digite el ID del contacto a eliminar:");
                            int deleteId = Convert.ToInt32(Console.ReadLine());

                            bool found = false;

                            for (int i = 0; i < contacts.Count; i++)
                            {
                                if (contacts[i].id == deleteId)
                                {
                                    contacts.RemoveAt(i);
                                    Console.WriteLine("Contacto eliminado");
                                    found = true;
                                    break;
                                }
                            }

                            if (found == false)
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
        }

        static void AddContact(List<Contactes> contacts)
        {
            Contactes contact = new Contactes();

            Console.WriteLine("Digite el nombre de la persona");
            contact.name = Console.ReadLine();

            Console.WriteLine("Digite el apellido de la persona");
            contact.lastname = Console.ReadLine();

            Console.WriteLine("Digite la direccion");
            contact.address = Console.ReadLine();

            Console.WriteLine("Digite el telefono de la persona");
            contact.telephone = Console.ReadLine();

            Console.WriteLine("Digite el email de la persona");
            contact.email = Console.ReadLine();

            Console.WriteLine("Digite la edad de la persona en numeros");
            contact.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Es mejor amigo? 1=si, 2=No");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                contact.bestFriend = true;
            }
            else
            {
                contact.bestFriend = false;
            }

            contact.id = contacts.Count + 1;

            contacts.Add(contact);
        }
    }
}

//Raul estenio medina matos 2024-0211