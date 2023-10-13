using ConsoleApp1;

namespace trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Janusz";
            person.lastName = "Nowak";
            person.weight = 90.5F;
            person.height = 192;
            Console.WriteLine($"Dane użytownika : {person.getData()}");

            Person person2 = new Person();
            person2.firstName = "Janusz";
            person2.lastName = "Kowal";
            person2.weight = 70.5F;
            person2.height = 192;
            Console.WriteLine($"Dane użytownika : {person.getData()}");

        }
    }
}