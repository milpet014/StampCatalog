using StampCatalog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StampCatalog.Services
{
    public class StampService
    {
        private readonly ExtractService _extractor;

        public StampService()
        {
            _extractor = new ExtractService();
        }

        public async Task Initialize()
        {
            string json = await _extractor.ExtractToString("StampCatalog.stamps.json");

        }

        public List<string> GetTabsNames(Category category)
        {
            return new List<string>();
        }

        public List<Stamp> GetStamps(Category category, string tabName)
        {
            return new List<Stamp>();
        }
    }
}
