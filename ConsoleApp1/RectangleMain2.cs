using ConsoleApp1;

namespace trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b;
            Console.Write("Podaj pierwszy bok : ");
            while (!double.TryParse(Console.ReadLine(), out a) || a < 0)
            {
                Console.Write("Niepoprawna wartość");
                Thread.Sleep(240);
                Console.Write(",\nWprowadź poprawną wartość boku 1 : ");
            }
            Console.Write("Podaj drugi bok : ");
            while (!double.TryParse(Console.ReadLine(), out b) || b < 0)
            {
                Console.Write("Niepoprawna wartość");
                Thread.Sleep(240);
                Console.Write(",\nWprowadź poprawną wartość boku 2 : ");
            }
            Rectangle rectangle = new Rectangle(a,b);

            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write($"Pole prostokąta o bokach {a}, {b} wynosi ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{rectangle.CalculateRectangleArea(a, b)} cm²");
            Console.ResetColor();
            Console.OutputEncoding = System.Text.Encoding.Default;
        }

    }
}
