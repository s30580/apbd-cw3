namespace cw3;

public class Chlodniczy:Kontener
{
    private string rodzajProduktu;
    private double temperatura;
    Dictionary<string, double> productTemperatures = new Dictionary<string, double>
    {
        { "Bananas", 13.3 },
        { "Chocolate", 18 },
        { "Fish", 2 },
        { "Meat", -15 },
        { "Ice cream", -18 },
        { "Frozen pizza", -30 },
        { "Cheese", 7.2 },
        { "Sausages", 5 },
        { "Butter", 20.5 },
        { "Eggs", 19 }
    };
    public Chlodniczy(int masaLadunku, int wysokosc, int wagaWlasna, int glebokosc, int maksymalnaLadownosc, string rodzajProduktu, int temperatura) : base(masaLadunku, wysokosc, wagaWlasna, glebokosc, maksymalnaLadownosc)
    {
        this.rodzajProduktu = rodzajProduktu;
        this.temperatura = temperatura;
        this.numerSeryjny = "KON-" + "C-" + numerSeryjnyGlobal;
    }

    public void LadowanieKontenera(int masaLadunku,string ladowanyProdukt)
    {
        if (temperatura<productTemperatures[ladowanyProdukt] || rodzajProduktu!=ladowanyProdukt)
        {
            throw new Exception("Nie mozna zaladowac produktu"+ladowanyProdukt+" do "+numerSeryjny);
        }
        base.LadowanieKontenera(masaLadunku);
    }
}