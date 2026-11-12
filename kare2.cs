namespace alanb;

class Kare
{
    double kenar;

    public Kare()
    {
        DegerAl();
    }
    public void DegerAl()
    {
        Console.WriteLine("Karenin kenarini giriniz: ");
        kenar = Convert.ToDouble(Console.ReadLine());
        while(kenar <= 0)
        {
            Console.WriteLine("Pozitif sayi giriniz: ");
            kenar = Convert.ToDouble(Console.ReadLine());
        }
    }

    public double AlanHesapla() { return kenar * kenar; }
    public double CevreHesapla() { return 4 * kenar; }

    public void EkranaYazdir()
    {
        Console.WriteLine("Karenin Alani: " + AlanHesapla());
        Console.WriteLine("Karenin Cevresi: " + CevreHesapla());
    }
}