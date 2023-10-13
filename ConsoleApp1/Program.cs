namespace trojkat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool is_correct = false;
            do
            {
                Console.WriteLine("Podaj długość pierwszego boku : ");
                double a;
                while (!double.TryParse(Console.ReadLine(), out a) || a <= 0)
                {
                    Console.WriteLine("Nieprawidłowe dane");
                }
                Console.WriteLine("Podaj długość drugiego boku : ");
                double b;
                while (!double.TryParse(Console.ReadLine(), out b) || b <= 0)
                {
                    Console.WriteLine("Nieprawidłowe dane");
                }
                Console.WriteLine("Podaj długość trzeciego boku : ");
                double c;
                while (!double.TryParse(Console.ReadLine(), out c) || c <= 0)
                {
                    Console.WriteLine("Nieprawidłowe dane");
                }


                if (IsTriangle(a, b, c))
                {
                    
                    double area = CalculateArea(a, b, c);
                    Console.OutputEncoding=System.Text.Encoding.Unicode;
                    Console.Write($"Pole trójkąta o bokach {a}, {b}, {c} wynosi ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{area:F5}cm²");
                    Console.ResetColor();
                    is_correct = true;
                    Console.OutputEncoding=System.Text.Encoding.Default;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nPodane długośći boków nie utworzą trójkąta");
                    Console.ResetColor();
                    Thread.Sleep(1700);
                    Console.Clear();
                }

            } while (!is_correct);
            static bool IsTriangle(double a, double b, double c)
            {
                return a + b > c && b + c > a && c + a > b;
            }
            static double CalculateArea(double a, double b, double c)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}
