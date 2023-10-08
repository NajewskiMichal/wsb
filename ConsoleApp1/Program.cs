// See https://aka.ms/new-console-template for more information


using System.Globalization;

Console.WriteLine("Hello, World!");
    Console.WriteLine("Pole powiezchni : " + PolePowierzchni(PobranieWartosci()));

static bool CzyPoprawnyTrojkat(double[] boki)
{
    if (
        boki[0] + boki[1] <= boki[2]
        || boki[0] + boki[2] <= boki[1]
        || boki[1] + boki[2] <= boki[0]
        )
    {
        Console.WriteLine("Z tych bokow nie mozna utworzyc trojka!\nSproboj jeszcze raz");
        return false;
    }
    return true;
}
static double[] PobranieWartosci()
{
    double[] boki = new double[3];
    do
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Podaj {i + 1}. bok trojkata : ");
            while (!double.TryParse(Console.ReadLine(), out boki[i]) || boki[i]<=0)
                Console.WriteLine("Niepoprawna wartość! ");
        }
    } while (!CzyPoprawnyTrojkat(boki));
    return boki;
}

static double PolePowierzchni(double[] boki)
{
    double p = ((boki[0] + boki[1] + boki[2]) / 2.0);
    return Math.Sqrt(p * (p - boki[0]) * (p - boki[1]) * (p - boki[2]));
}


