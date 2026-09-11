
List<string> vara = new List<string>();
List<int> pris = new List<int>();
int _pris;

vara.Add("mjölk");
pris.Add(20);

bool on = true;
while(on)
{
    
    for (int i = 0; i < vara.Count; i++)
    {
        Console.WriteLine($"{i+1}. {vara.ElementAt(i)} - {pris.ElementAt(i)} kr");
    }

    Console.WriteLine("Lägg till vara:");
    vara.Add(Console.ReadLine());
    Console.WriteLine("Pris:");
    while(!int.TryParse(Console.ReadLine(), out _pris) || (_pris <= 0))
    {
        Console.WriteLine("Skriv ett nummer över 0");
    }
    pris.Add(_pris);

}