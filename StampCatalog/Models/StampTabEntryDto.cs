using System.Collections.Generic;

namespace StampCatalog.Models
{
    class StampTabEntryDto
    {
        public Category Category { get; set; }
        public string Title { get; set; }
        public List<StampDto> StampDtos { get; set; }
    }
}
