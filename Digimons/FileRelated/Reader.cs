using Digimons.Models;
using Newtonsoft.Json;

namespace Digimons.FileRelated
{
    public static partial class FileActions
    {
        public static Digimon[] ReadFile()
        {
            try
            {
                using (FileStream fs = new FileStream("data.json", FileMode.Open))
                {
                    var reader = new StreamReader(fs);

                    var data = reader.ReadToEnd();

                    var digimons = JsonConvert.DeserializeObject<Digimon[]>(data);

                    return digimons!;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo data.json não existente... Iniciando aplicação sem dados.");
                return Array.Empty<Digimon>();
            }
        }
    }
}