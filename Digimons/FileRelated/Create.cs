using Digimons.Models;
using Newtonsoft.Json;

namespace Digimons.FileRelated
{
    public static partial class FileActions
    {
        public static void CreateFile(Digimon[] content)
        {
            using (FileStream fs = new FileStream("data.json", FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            using (JsonWriter jsonWriter = new JsonTextWriter(sw))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sw, content);
            }
        }
    }
}
