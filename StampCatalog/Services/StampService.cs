﻿using StampCatalog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StampCatalog.Services
{
    public class StampService
    {
        private readonly ExtractService _extractor;
        private List<StampTabEntry> _entries;

        public StampService()
        {
            _extractor = new ExtractService();
        }

        public async Task Initialize()
        {
            string json = await _extractor.ExtractToString("StampCatalog.stamps.json");

            List<StampTabEntryDto> dtoList = JsonConvert.DeserializeObject<List<StampTabEntryDto>>(json);

            List<StampTabEntry> entryList = new List<StampTabEntry>();
            _entries = entryList;

            foreach (StampTabEntryDto dto in dtoList)
            {
                Dictionary<string, Stamp> stampsDictionary = new Dictionary<string, Stamp>();
                StampTabEntry stampTabEntry = new StampTabEntry();

                stampTabEntry.Category = dto.Category;
                stampTabEntry.Title = dto.Title;

                foreach (StampDto dto2 in dto.StampDtos)
                {
                    Stamp stamp = new Stamp();

                    stamp.CatalogNum = dto2.CatalogNum;
                    stamp.CatValue = dto2.CatValue;
                    stamp.Color = dto2.Color;
                    stamp.Country = dto2.Country;
                    stamp.Date = dto2.Date;
                    stamp.Image = dto2.Image;
                    stamp.Name = dto2.Name;
                    stamp.Serie = dto2.Serie;
                    stamp.Size = dto2.Size;
                    stamp.Theme = dto2.Theme;
                    stamp.Value = dto2.Value;
                    stamp.SerieContains = new List<Stamp>();

                    stampsDictionary[stamp.CatalogNum] = stamp;
                }

                foreach (StampDto dto2 in dto.StampDtos)
                {
                    Stamp stamp = stampsDictionary[dto2.CatalogNum];
                    List<Stamp> serieContainsList = stamp.SerieContains; 

                    foreach (string catalogNumber in dto2.SerieContainsCatNums)
                    {
                        Stamp stamp2 = stampsDictionary[catalogNumber];
                        serieContainsList.Add(stamp2);
                    }

                }

                entryList.Add(stampTabEntry);
            }
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
