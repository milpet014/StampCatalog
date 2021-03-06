﻿using System;
using System.Collections.Generic;

namespace StampCatalog.Models
{
    public class StampDto
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Serie { get; set; }
        public string Theme { get; set; }
        public string CatalogNum { get; set; }
        public string Size { get; set; }
        public DateTime Date { get; set; }
        public string Color { get; set; }
        public string CatValue { get; set; }
        public string Value { get; set; }
        public List<string> SerieContainsCatNums { get; set; }
        public string Image { get; set; }
        public List<string> Sheets { get; set; }
    }
}
