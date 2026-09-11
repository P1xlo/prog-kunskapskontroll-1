
List<string> vara = new List<string>();
List<int> pris = new List<int>();

int _pris;
string _vara;

vara.Add("mjölk");
pris.Add(20);

Console.WriteLine("");

bool on = true;
while(on)
{
    int tPris = 0;
    for (int i = 0; i < vara.Count; i++)
    {
        Console.WriteLine($"{i+1}. {vara.ElementAt(i)} - {pris.ElementAt(i)} kr");
    }

    foreach (int p in pris)
    {
        tPris += p;
    }

    Console.WriteLine($"\nTotal: {tPris} kr\n");
    if(vara.Count > 0)
        Console.WriteLine("Skriv nummret brevid varan för att ta bort.");

    Console.WriteLine("Lägg till vara:");
    _vara = Console.ReadLine();

    if(int.TryParse(_vara, out int o))
    {
        if(o > 0 && (vara.Count >= o))
        {
            Console.WriteLine($"Tog bort {vara.ElementAt(o - 1)} med priset {pris.ElementAt(o - 1)}");
            vara.RemoveAt(o - 1);
            pris.RemoveAt(o - 1);
        }
        else
        {
            Console.WriteLine($"Skriv ett nummer mellan 1 - {vara.Count}");
        }
    }
    else
    {
        vara.Add(_vara);
        Console.WriteLine("Pris:");
        while(!int.TryParse(Console.ReadLine(), out _pris) || (_pris <= 0))
        {
            Console.WriteLine("Skriv ett nummer över 0");
        }
        pris.Add(_pris);
    }
}