namespace cw3;

public class Kontener
{
    protected double masaLadunku;
    protected double wysokosc;
    protected double wagaWlasna;
    protected double glebokosc;
    protected string numerSeryjny;
    protected double maksymalnaLadownosc;
    protected static int  numerSeryjnyGlobal = 0;

    public Kontener(double masaLadunku, double wysokosc, double wagaWlasna, double glebokosc, double maksymalnaLadownosc)
    {
        this.masaLadunku = masaLadunku;
        this.wysokosc = wysokosc;
        this.wagaWlasna = wagaWlasna;
        this.glebokosc = glebokosc;
        this.numerSeryjny = "KON-" + "K-" + ++numerSeryjnyGlobal;
        this.maksymalnaLadownosc = maksymalnaLadownosc;
    }

    public virtual void  OproznianieLadunku()
    {
        masaLadunku = 0;
        Console.WriteLine("Opróżanie ladunku: "+numerSeryjny);
    }

    public virtual void LadowanieKontenera(int masaLadunku)
    {
        if (masaLadunku > maksymalnaLadownosc)
        {
            throw new OverfillException();
        }
        else
        {
            this.masaLadunku += masaLadunku;
        }
    }

    public double PobierzMase() => masaLadunku;
    public string NumerSeryjny() => numerSeryjny;
    
    public override string ToString()
    {
        return "===================\n" +
               "Kontener\n" +
               "Numer seryjny: " + numerSeryjny + "\n" +
               "Waga własna: " + wagaWlasna + " kg\n" +
               "Masa ładunku: " + masaLadunku + " kg\n" +
               "Maksymalna ładowność: " + maksymalnaLadownosc + " kg\n" +
               "Wymiary (WxG): " + wysokosc + "cm x " + glebokosc + "cm\n" +
               "===================\n";
    }
}