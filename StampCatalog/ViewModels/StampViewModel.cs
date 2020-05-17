using StampCatalog.Models;
using System.Collections.Generic;

namespace StampCatalog.ViewModels
{
    public class StampViewModel
    {
        public List<Stamp> Stamps { get; set; }

        public StampViewModel()
        {
            Stamps = new List<Stamp>();

            Stamp mi01 = new Stamp();
            mi01.Name = "Mi_01";
            mi01.Image = "https://i.colnect.net/b/2188/891/Slovakia-State-Arms.jpg";
            mi01.CatalogNum = "POF:Sk 1 Mi:Sk 162";

            Stamps.Add(mi01);
        }
    }
}