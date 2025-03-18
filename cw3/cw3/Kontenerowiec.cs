namespace cw3;

public class Kontenerowiec
{
    private List<Kontener> kontenery;
    private double maksPredkosc;
    private int maksKontenery;
    private double maksWagaWszystkichKontenerow;

    public Kontenerowiec(List<Kontener> kontenery, double maksPredkosc, int maksKontenery, double maksWagaWszystkichKontenerow)
    {
        this.kontenery = kontenery;
        this.maksPredkosc = maksPredkosc;
        this.maksKontenery = maksKontenery;
        this.maksWagaWszystkichKontenerow = maksWagaWszystkichKontenerow;
    }

    public void ZaladujKontener(Kontener kontener)
    {
        var sumaMas = kontenery.Select(i => i.PobierzMase()).Sum();
        if (sumaMas + kontener.PobierzMase() > maksWagaWszystkichKontenerow &&
            kontenery.Count + 1 > maksKontenery)
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
        if (staryKontener.NumerSeryjny() == nowyKontener.NumerSeryjny())
        {
            kontenery.Remove(staryKontener);
            kontenery.Add(nowyKontener);
        }
        else
        {
            Console.WriteLine("Nie pasujace numery seryjne");
        }
    }

    public void przeniesiKontenera(Kontenerowiec kontenerowiec,Kontener kontener)
    {
        if (kontenery.Contains(kontener))
        {
            kontenery.Remove(kontener);
            kontenerowiec.ZaladujKontener(kontener);
        }
    }

    public override string ToString()
    {
        return "===================\n" +
               "Kontenerowiec\n" +
               "Maksymalna prędkość: " + maksPredkosc + " węzłów\n" +
               "Maksymalna liczba kontenerów: " + maksKontenery + "\n" +
               "Maksymalna waga ładunku: " + maksWagaWszystkichKontenerow + " ton\n" +
               "Aktualna liczba kontenerów: " + kontenery.Count + "\n" +
               "===================\n";
    }
}