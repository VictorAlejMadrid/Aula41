namespace Digimons.Models
{
    public enum DigimonType { Virus, Vaccine, Data, Unknown }
    public class Digimon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int HealthPoints { get; set;}
        public DigimonType Type { get; set; }

        public Digimon(string name, int level, int attack, int healthPoints, DigimonType type)
        {
            Name = name;
            Level = level;
            Attack = attack;
            HealthPoints = healthPoints;
            Type = type;
        }

        public void ShowYouself()
        {
            Console.WriteLine($"{this.Name}: HP {this.HealthPoints}, Attack {this.Attack}, Tipo {this.Type}");
        }
    }
}
