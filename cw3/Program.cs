namespace cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stworzenie kontenera danego typu
            Kontener kontener1 = new Kontener(1000, 500, 200, 300, 5000);
            Kontener kontener2 = new Chlodniczy(500, 400, 150, 200, 3000, "Fish", 2);
            Kontener kontener3 = new Gaz(800, 600, 250, 400, 4000, 10);
            Kontener kontener4 = new Plyny(1200, 500, 300, 300, 6000, true);
            
            
            Kontenerowiec kontenerowiec1 = new Kontenerowiec( 30.0, 10, 20000);
            Kontenerowiec kontenerowiec2 = new Kontenerowiec( 20.0, 20, 40000);
            
            // Załadowanie ładunku do danego kontenere
            Console.WriteLine(kontener2.PobierzMase());
            kontener2.LadowanieKontenera(2600);
            Console.WriteLine(kontener2.PobierzMase());

            // Załadowanie kontenera na statek
            Console.WriteLine(kontenerowiec1);
            kontenerowiec1.ZaladujKontener(kontener2);
            Console.WriteLine(kontenerowiec1);
            
            // Załadowanie listy kontenerów na statek
            List<Kontener> konteners = new List<Kontener>(){kontener1, kontener2, kontener3};
            Console.WriteLine(kontenerowiec2);
            kontenerowiec2.ZaladujKontener(konteners);
            Console.WriteLine(kontenerowiec2);
            
            // Usunięcie kontenera ze statku
            Console.WriteLine(kontenerowiec2);
            kontenerowiec2.UsunKontener(kontener2);
            Console.WriteLine(kontenerowiec2);
            
            // Rozładowanie kontenera
            kontener3.OproznianieLadunku();
            Console.WriteLine(kontener3.PobierzMase());
            
            // Zastąpienie kontenera na statku o danym numerze innym kontenerem
            Console.WriteLine(kontenerowiec2);
            kontenerowiec2.PodmianaKontenera(kontener3,kontener2);
            Console.WriteLine(kontenerowiec2);
            
            // Możliwość przeniesienie kontenera między dwoma statkami
            kontenerowiec2.PrzeniesienieKontenera(kontenerowiec1, kontener1);
            Console.WriteLine(kontenerowiec1);
            Console.WriteLine(kontenerowiec2);
            
            
            // Wypisanie informacji o danym kontenerze
            Console.WriteLine(kontener1);
            // Wypisanie informacji o danym statku i jego ładunku
            Console.WriteLine(kontenerowiec2);
            
        
        }
    }
}
