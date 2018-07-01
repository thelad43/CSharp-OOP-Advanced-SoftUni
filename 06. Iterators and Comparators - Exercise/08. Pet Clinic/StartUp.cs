namespace _08._Pet_Clinic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private static List<Pet> pets;
        private static List<PetClinic> clinics;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            pets = new List<Pet>();
            clinics = new List<PetClinic>();

            for (int i = 0; i < n; i++)
            {
                var commandTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (commandTokens[0])
                {
                    case "Create":
                        try
                        {
                            if (commandTokens[1] == "Pet")
                            {
                                CreatePet(commandTokens);
                            }
                            else
                            {
                                CreateClinic(commandTokens);
                            }
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;

                    case "HasEmptyRooms":
                        Console.WriteLine(HasEmptyRooms(commandTokens));
                        break;

                    case "Release":
                        Console.WriteLine(Release(commandTokens));
                        break;

                    case "Add":
                        Console.WriteLine(AddPet(commandTokens));
                        break;

                    case "Print":
                        PrintClinic(commandTokens);
                        break;

                    default:
                        throw new ArgumentException();
                }
            }
        }

        private static void PrintClinic(string[] commandTokens)
        {
            var name = commandTokens[1];
            var clinic = clinics.FirstOrDefault(c => c.Name == name);

            if (commandTokens.Length == 3)
            {
                var roomNumber = int.Parse(commandTokens[2]);
                Console.WriteLine(clinic.GetRoomState(roomNumber));
            }
            else
            {
                Console.WriteLine(clinic.GetAllRoomsState());
            }
        }

        private static bool AddPet(string[] commandTokens)
        {
            var petName = commandTokens[1];
            var clinicName = commandTokens[2];

            var pet = pets.FirstOrDefault(p => p.Name == petName);
            var clinic = clinics.FirstOrDefault(c => c.Name == clinicName);

            return clinic.AddPet(pet);
        }

        private static bool Release(string[] commandTokens)
        {
            var name = commandTokens[1];
            var clinic = clinics.FirstOrDefault(c => c.Name == name);
            return clinic.Release();
        }

        private static bool HasEmptyRooms(string[] commandTokens)
        {
            var name = commandTokens[1];
            var clinic = clinics.FirstOrDefault(c => c.Name == name);
            return clinic.HasEmptyRooms;
        }

        private static void CreateClinic(string[] commandTokens)
        {
            var clinicName = commandTokens[2];
            var rooms = int.Parse(commandTokens[3]);

            var clinic = new PetClinic(clinicName, rooms);
            clinics.Add(clinic);
        }

        private static void CreatePet(string[] commandTokens)
        {
            var name = commandTokens[2];
            var age = int.Parse(commandTokens[3]);
            var kind = commandTokens[4];

            var pet = new Pet(name, age, kind);
            pets.Add(pet);
        }
    }
}