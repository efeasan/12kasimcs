namespace alanb;

class Program
{
    static void Main(string[] args)
    {
        Kare kare = new Kare();
        kare.DegerAl();
        kare.EkranaYazdir();

        Console.WriteLine();

        Daire daire = new Daire();
        daire.DegerAl();
        daire.EkranaYazdir();

        Console.WriteLine();

        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.DegerAl();
        dikdortgen.EkranaYazdir();
    }
}