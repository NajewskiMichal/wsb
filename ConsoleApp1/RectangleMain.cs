using ConsoleApp1;

namespace trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Console.Write("Podaj pierwszy bok : ");
            while (!double.TryParse(Console.ReadLine(), out rectangle.a) || rectangle.a < 0)
            {
                Console.Write("Niepoprawna wartość");
                Thread.Sleep(240);
                Console.Write(",\nWprowadź poprawną wartość boku 1 : ");
            }
            Console.Write("Podaj drugi bok : ");
            while (!double.TryParse(Console.ReadLine(), out rectangle.b) || rectangle.b < 0)
            {
                Console.Write("Niepoprawna wartość");
                Thread.Sleep(240);
                Console.Write(",\nWprowadź poprawną wartość boku 2 : ");
            }
            double area = rectangle.a * rectangle.b;
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write($"Pole prostokąta o bokach {rectangle.a}, {rectangle.b} wynosi ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{area:F5}cm²");
            Console.ResetColor();
            Console.OutputEncoding = System.Text.Encoding.Default;
        }

    }
}
