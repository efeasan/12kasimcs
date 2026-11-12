namespace alanb;

class Program
{
    static void Main(string[] args)
    {
        Kare kare = new Kare();
        
        kare.EkranaYazdir();

        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.EkranaYazdir();

        Daire daire = new Daire();
        daire.EkranaYazdir();
    }
}