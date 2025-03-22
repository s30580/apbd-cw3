namespace cw3;

public class Gaz:Kontener,IHazardNotifier
{
    private int cisnienie;

    public Gaz(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc, int cisnienie) : base(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc)
    {
        this.cisnienie = cisnienie;
        this.numerSeryjny = "KON-" + "G-" + numerSeryjnyGlobal;
    }

    public void Notify()
    {
        Console.WriteLine("Niebezpieczenstwo!: "+numerSeryjny);
    }

    public override void OproznianieLadunku()
    {
        double piecProcent = this.masaLadunku*0.05;
        base.OproznianieLadunku();
        this.masaLadunku+= (int) piecProcent;
    }
}