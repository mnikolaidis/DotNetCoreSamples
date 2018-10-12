using System;

namespace Enums
{
class Program
    {
        static void Main(string[] args)
        {
            int gender;
            string gender_str;
            bool isCorrect;

            Console.WriteLine("** How to use Enums - Simple way **");

            do
            {

                Console.WriteLine("Insert your gender (0 for female - 1 for male): ");
                isCorrect = int.TryParse(Console.ReadLine(), out gender);

            } while (!isCorrect && (gender != 0 || gender != 1));

            Person p = new Person();

            if (gender == 0)
            {
                p.Gender = Gender.Female;
            }
            else
            {
                p.Gender = Gender.Male;
            }

            Console.WriteLine("** How to use Enums - Converting int to enum **");
            p = new Person
            {
                // Cast your integer to enum
                Gender = (Gender)gender
            };

            Console.WriteLine("** How to use Enums - Converting string to enum **");
            do
            {

                Console.WriteLine("Insert your gender (Female, Male): ");
                gender_str = Console.ReadLine();

            } while (gender_str != "Female" && gender_str != "Male");

            p = new Person
            {
                // Parse (or TryParse) the string to enum.
                // Because Enum.Parse(...) returns an object you have to cast to the actual enum (eg. Gender)
                Gender = (Gender)Enum.Parse(typeof(Gender), gender_str)
            };

        }
    }
}
