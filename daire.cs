namespace alanb;

public class Daire
{
    double yaricap;

    public Daire()
    {
        DegerAl();
    }

    public void DegerAl()
    {
        Console.Write("Dairenin yaricapini giriniz: ");
        yaricap = Convert.ToDouble(Console.ReadLine());
        while (yaricap <= 0)
        {
            Console.Write("Pozitif sayi giriniz: ");
            yaricap = Convert.ToDouble(Console.ReadLine());
        }
    }

    public double AlanHesapla() { return Math.PI * yaricap * yaricap; }
    public double CevreHesapla() { return 2 * Math.PI * yaricap; }

    public void EkranaYazdir()
    {
        Console.WriteLine("Dairenin Alani: " + AlanHesapla());
        Console.WriteLine("Dairenin Cevresi: " + CevreHesapla());
    }
}