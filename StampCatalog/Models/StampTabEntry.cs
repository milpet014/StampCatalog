using System.Collections.Generic;

namespace StampCatalog.Models
{
    public class StampTabEntry
    {
        public Category Category { get; set; }
        public string Title { get; set; }
        public List<Stamp> Stamps { get; set; }
    }
}
