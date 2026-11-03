namespace ConsoleApp7;

class Program
{
    static void Main(string[] args)
    {
        Zakaznik Peto = new Zakaznik();
        Peto.Meno = "Peto";
        Peto.Email = "Peto.V@skola.sk";
        Peto.Adresa = "Trnavska 5 Trnava";
        
        Produkt Produkt1 = new Produkt();
        Produkt1.Nazov= "Pracka";
        Produkt1.Cena = 599;
        
        Produkt Produkt2 = new Produkt();
        Produkt2.Nazov= "zehlicka";
        Produkt2.Cena = 120;
        
        Objednavka Objednavka1 = new Objednavka();
        Objednavka1.Id = 1;
        Objednavka1.Objednavatel = Peto;
        Objednavka1.Polozky.Add(Produkt1);
        Objednavka1.Polozky.Add(Produkt2);
    }
}

class Zakaznik
{
    public string Email;
    public string Meno;
    public string Adresa;
}

class Produkt
{
    public double Cena;
    public string Nazov;
}

class Objednavka
{
    public int Id;
    public Zakaznik Objednavatel;
    public List<Produkt> Polozky= new List<Produkt>();
}

