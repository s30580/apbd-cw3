namespace cw3;

public class Plyny:Kontener,IHazardNotifier
{
    private bool czyNiebezpieczny;

    public Plyny(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, string numerSeryjny, int maksymalnaLadownosc, bool czyNiebezpieczny) : base(masaLadunku, wysokosc, wagaWlasna, glebokosc, numerSeryjny, maksymalnaLadownosc)
    {
        this.czyNiebezpieczny = czyNiebezpieczny;
    }

    public void Notify()
    {
        Console.WriteLine("Niebezpieczenstwo!: "+numerSeryjny);
    }

    public override void LadowanieKontenera(int masaLadunku)
    {
        if ((czyNiebezpieczny &&
            masaLadunku > this.maksymalnaLadownosc * 0.5) ||
            !czyNiebezpieczny && masaLadunku > this.maksymalnaLadownosc * 0.9)
        {
            Notify();
        }
        base.LadowanieKontenera(masaLadunku);
    }
}