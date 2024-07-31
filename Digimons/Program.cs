using Digimons.Models;
using Digimons.FileRelated;

internal class Program
{
    private static void Main(string[] args)
    {
        var oldDigimons = FileActions.ReadFile();

        foreach(var digi in oldDigimons)
        {
            digi.ShowYouself();
        }

        var digi1 = new Digimon("Tailmon", 5, 10, 50, DigimonType.Virus);
        var digi2 = new Digimon("Angemon", 7, 20, 80, DigimonType.Data);
        var digi3 = new Digimon("Patamon", 10, 25, 100, DigimonType.Unknown);
        var digi4 = new Digimon("Gabumon", 15, 40, 150, DigimonType.Virus);
        var digi5 = new Digimon("Agumon", 15, 40, 150, DigimonType.Vaccine);

        var newdigimons = new Digimon[] { digi1, digi2, digi3, digi4, digi5 };
        var digimonsToFile = oldDigimons.Concat(newdigimons);

        FileActions.CreateFile(digimonsToFile.ToArray());
        Console.WriteLine("\n");

        var newData = FileActions.ReadFile();
        foreach (var digi in newData)
        {
            digi.ShowYouself();
        }
    }
}