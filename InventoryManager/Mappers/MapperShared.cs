using System.Collections.Generic;
using System.Linq;
using InventoryManager.DataAccess;
using InventoryManager.Models;

namespace InventoryManager.Mappers
{
    public interface IMapperShared
    {
        List<ColorModel> MapColorModel(List<Dictionary<string, string>> dataRecords);
        List<CutNamesModel> MapCutModel(List<Dictionary<string, string>> dataRecords);
        List<EmbelishmentNamesModel> MapEmbelishMentNamesModel(List<Dictionary<string, string>> dataRecords);
        List<RegionModel> MapRegionModel(List<Dictionary<string, string>> dataRecords);
        List<EraModel> MapEraModel(List<Dictionary<string, string>> dataRecords);
        List<GenderModel> MapGenderModel(List<Dictionary<string, string>> dataRecords);
        List<LayerModel> MapLayerModel(List<Dictionary<string, string>> dataRecords);
        List<LocationModel>MapLocationModel(List<Dictionary<string, string>> dataRecords);
        List<NameModel> MapNameModel(List<Dictionary<string, string>> dataRecords);
        List<UsesModel> MapUseModel(List<Dictionary<string, string>> dataRecords);
        List<ItemSourceModel> MapItemSourceModel(List<Dictionary<string, string>> dataRecords);
        List<PatternNumbersModel> MapPatternModel(List<Dictionary<string, string>> dataRecords);
        List<TrimModel> MapTrimModel(List<Dictionary<string, string>> dataRecords);
        List<BasicContactsModel> MapBasicContactsModel(List<Dictionary<string, string>> dataRecords);
    }

    public class MapperShared : MapperHelper, IMapperShared
    {

        public List<ColorModel> MapColorModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new ColorModel
                    {
                        ColorID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ColorModel()).FirstOrDefault()),
                        Color = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ColorModel()).Last())
                    }).ToList();
        }

        public List<CutNamesModel> MapCutModel(List<Dictionary<string, string>> dataRecords)
        {
            var cutModelList = new List<CutNamesModel>();

            foreach (var item in dataRecords)
            {

                var cutModel = new CutNamesModel
                {
                    CutNameID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new CutNamesModel()).FirstOrDefault()),
                    CutName = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new CutNamesModel()).Last())
                };

                cutModelList.Add(cutModel);
            }

            return cutModelList;
        }

        public List<EmbelishmentNamesModel> MapEmbelishMentNamesModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new EmbelishmentNamesModel
                    {
                        EmbelishmentID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new EmbelishmentNamesModel()).FirstOrDefault()),
                        EmbelishmentName = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new EmbelishmentNamesModel()).Last())
                    }).ToList();
        }

        public List<RegionModel> MapRegionModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new RegionModel
                    {
                        RegionID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new RegionModel()).FirstOrDefault()),
                        Region = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new RegionModel()).Last())
                    }).ToList();
        }

        public List<EraModel> MapEraModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new EraModel
                    {
                        EraId = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new EraModel()).FirstOrDefault()),
                        Era = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new EraModel()).Last())
                    }).ToList();
        }

        public List<GenderModel> MapGenderModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new GenderModel
                    {
                        GenderID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GenderModel()).FirstOrDefault()),
                        Gender = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new GenderModel()).Last())
                    }).ToList();
        }

        public List<LayerModel> MapLayerModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new LayerModel
                    {
                        LayerID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new LayerModel()).FirstOrDefault()),
                        Layer = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new LayerModel()).Last())
                    }).ToList();
        }

        public List<LocationModel>MapLocationModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new LocationModel
                    {
                        LocationID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new LocationModel()).FirstOrDefault()),
                        Location = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new LocationModel()).Last())
                    }).ToList();
        }

        public List<NameModel> MapNameModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new NameModel
                    {
                        NameID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new NameModel()).FirstOrDefault()),
                        Name = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new NameModel()).Last())
                    }).ToList();
        }

        public List<UsesModel> MapUseModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new UsesModel
                    {
                        UsesID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new UsesModel()).FirstOrDefault()),
                        Uses = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new UsesModel()).Last())
                    }).ToList();
        }

        public List<ItemSourceModel> MapItemSourceModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new ItemSourceModel
            {
                ItemSourceID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ItemSourceModel()).FirstOrDefault()),
                ItemSource = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ItemSourceModel()).Last())
            }).ToList();
        }

        public List<PatternNumbersModel> MapPatternModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new PatternNumbersModel
            {
                PatternNumberID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new PatternNumbersModel()).FirstOrDefault()),
                PatternCompanies = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new PatternNumbersModel()).Last())
            }).ToList(); 
        }

        public List<TrimModel> MapTrimModel(List<Dictionary<string, string>> dataRecords)
        {
            return dataRecords.Select(item => new TrimModel
            {
                TrimNameID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new TrimModel()).FirstOrDefault()),
                TrimName = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new TrimModel()).Last())
            }).ToList(); 
        }

        public List<BasicContactsModel> MapBasicContactsModel(List<Dictionary<string, string>> dataRecords)
        {
            var list = new List<BasicContactsModel>();
            foreach (var item in dataRecords)
                list.Add(new BasicContactsModel
                {
                    ID = GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ContactsFullModel()).Find(s => s.Equals("ID"))),
                    FullName = string.Format("{0}" + " " + "{1}",
                    GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ContactsFullModel()).Find(s => s.Contains("First"))),
                    GetValueFromDict(item, _DataHelpers.GetNamesFromModel(new ContactsFullModel()).Find(s => s.Contains("Last"))))
                });
            return list;
        }
    }
}
