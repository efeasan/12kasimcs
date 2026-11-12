namespace alanb;

public class Dikdortgen
{
    double kisaKenar;
    double uzunKenar;

    public void DegerAl()
    {
        Console.Write("Dikdortgenin kisa kenarini giriniz: ");
        kisaKenar = Convert.ToDouble(Console.ReadLine());
        while (kisaKenar <= 0)
        {
            Console.Write("Pozitif sayi giriniz: ");
            kisaKenar = Convert.ToDouble(Console.ReadLine());
        }

        Console.Write("Dikdortgenin uzun kenarini giriniz: ");
        uzunKenar = Convert.ToDouble(Console.ReadLine());
        while (uzunKenar <= 0)
        {
            Console.Write("Pozitif sayi giriniz: ");
            uzunKenar = Convert.ToDouble(Console.ReadLine());
        }
    }

    public double AlanHesapla() { return kisaKenar * uzunKenar; }
    public double CevreHesapla() { return 2 * (kisaKenar + uzunKenar); }

    public void EkranaYazdir()
    {
        Console.WriteLine("Dikdortgenin Alani: " + AlanHesapla());
        Console.WriteLine("Dikdortgenin Cevresi: " + CevreHesapla());
    }
}