using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace StampCatalog.Services
{
    public class ExtractService
    {
        public async Task<string> ExtractToString(string name)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream(name);
            using StreamReader reader = new StreamReader(stream);
            string readed = await reader.ReadToEndAsync();
            return readed;
        }
    }
}