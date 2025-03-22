namespace cw3;

public class Kontenerowiec
{
    private List<Kontener> kontenery;
    private double maksPredkosc;
    private int maksKontenery;
    private double maksWagaWszystkichKontenerow;

    public Kontenerowiec(double maksPredkosc, int maksKontenery, double maksWagaWszystkichKontenerow)
    {
        this.kontenery = new List<Kontener>();
        this.maksPredkosc = maksPredkosc;
        this.maksKontenery = maksKontenery;
        this.maksWagaWszystkichKontenerow = maksWagaWszystkichKontenerow;
    }

    public void ZaladujKontener(Kontener kontener)
    {
        var sumaMas = kontenery.Select(i => i.PobierzMase()).Sum();
        if (sumaMas + kontener.PobierzMase() > maksWagaWszystkichKontenerow ||
            kontenery.Count + 1 > maksKontenery || kontenery.Contains(kontener))
        {
            throw new Exception("Nie mozna zaladowac tego kontenera: "+kontener.NumerSeryjny());
        }
        kontenery.Add(kontener);
    }

    public void UsunKontener(Kontener kontener)
    {
        kontenery.Remove(kontener);
    }

    public void ZaladujKontener(List<Kontener> kontenery)
    {
        foreach (var kontener in kontenery)
        {
            ZaladujKontener(kontener);
        }
    }

    public void PodmianaKontenera(Kontener staryKontener,Kontener nowyKontener)
    {
        if (staryKontener.NumerSeryjny() != nowyKontener.NumerSeryjny())
        {
            kontenery.Remove(staryKontener);
            kontenery.Add(nowyKontener);
        }
        else if(!kontenery.Contains(staryKontener))
        {
            Console.WriteLine("Nie ma takiego kontenera na statku");
        }
        else 
        {
            Console.WriteLine("Próba podmiany tego samego kontenera");
        }
    }

    public void PrzeniesienieKontenera(Kontenerowiec kontenerowiec,Kontener kontener)
    {
        if (kontenery.Contains(kontener))
        {
            kontenery.Remove(kontener);
            kontenerowiec.ZaladujKontener(kontener);
        }
        else
        {
            Console.WriteLine("Nie ma takiego kontenera na statku");
        }
    }
    public double ObliczMaseKontenerow()
    {
        double sumaMasy = 0;
        foreach (var kontener in kontenery)
        {
            sumaMasy += kontener.PobierzMase();
        }
        return sumaMasy;
    }

    public string WypiszNumerySeryjne()
    {
        string wypiszNumerySeryjne = "\n";
        foreach (var kontener in kontenery)
        {
            wypiszNumerySeryjne += kontener.NumerSeryjny() + "\n";
        }
        return wypiszNumerySeryjne;
    }

    public override string ToString()
    {
        return "===================\n" +
               "Kontenerowiec\n" +
               "Maksymalna prędkość: " + maksPredkosc + " węzłów\n" +
               "Maksymalna liczba kontenerów: " + maksKontenery + "\n" +
               "Maksymalna waga ładunku: " + maksWagaWszystkichKontenerow + " ton\n" +
               "Aktualna liczba kontenerów: " + kontenery.Count + "\n" +
               "Aktualna masa kontenerów: " + ObliczMaseKontenerow() + "\n" +
               "Numery Seryjne kontenerów: " + WypiszNumerySeryjne()+ "\n" +
               "===================\n";
    }
}