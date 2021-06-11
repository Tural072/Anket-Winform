using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_Winform
{
    class HelperJson
    {
        public static void JSONSerialization(Human database, string filename)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(filename))
            {
                using (JsonTextWriter jsonTextWriter = new JsonTextWriter(streamWriter))
                {
                    jsonTextWriter.Formatting = Formatting.Indented;
                    serializer.Serialize(jsonTextWriter, database);
                }
            }
        }
        
    }
}
