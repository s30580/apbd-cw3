namespace cw3;

public class Kontener
{
    protected int masaLadunku;
    protected int wysokosc;
    protected int wagaWlasna;
    protected int glebokosc;
    protected string numerSeryjny;
    protected int maksymalnaLadownosc;

    public Kontener(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, string numerSeryjny, int maksymalnaLadownosc)
    {
        this.masaLadunku = masaLadunku;
        this.wysokosc = wysokosc;
        this.wagaWlasna = wagaWlasna;
        this.glebokosc = glebokosc;
        this.numerSeryjny = numerSeryjny;
        this.maksymalnaLadownosc = maksymalnaLadownosc;
    }

    public virtual void  OproznianieLadunku()
    {
        masaLadunku = 0;
        Console.WriteLine("Opróanie ladunku: "+numerSeryjny);
    }

    public virtual void LadowanieKontenera(int masaLadunku)
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            throw new OverfillException();
        }
        else
        {
            this.masaLadunku = masaLadunku;
        }
    }

    public int PobierzMase() => masaLadunku;
    public string NumerSeryjny() => numerSeryjny;
    
    public override string ToString()
    {
        return "===================\n" +
               "Kontener\n" +
               "Numer seryjny: " + numerSeryjny + "\n" +
               "Waga własna: " + wagaWlasna + " kg\n" +
               "Masa ładunku: " + masaLadunku + " kg\n" +
               "Maksymalna ładowność: " + maksymalnaLadownosc + " kg\n" +
               "Wymiary (WxG): " + wysokosc + "m x " + glebokosc + "m\n" +
               "===================\n";
    }
}