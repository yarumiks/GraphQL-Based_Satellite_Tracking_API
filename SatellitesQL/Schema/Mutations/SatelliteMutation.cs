using HotChocolate.Types.Relay;
using Newtonsoft.Json;
using SatellitesQL.LocalDefinedSatellites;
using SatellitesQL.Serfvice;
using System.Text.Json.Nodes;
using static SatellitesQL.Serfvice.SatelliteCategories;

namespace SatellitesQL.Schema.Mutations
{
    public class SatelliteMutation
    {
        string path;
        public SatelliteMutation()
        {
            path = System.IO.Path.Combine(AppContext.BaseDirectory, "LocalDefinedSatellites/Satellitesjson.json");
        }
        public LocalDefinedSatellites.JsonType AddSatellite([GraphQLType(typeof(SatelliteCategoryType))] SatelliteCategory name,List<int>? noradIds)
        {
            LocalDefinedSatellites.JsonValue satellites;

            if (File.Exists(path))
            {
                string chunk = File.ReadAllText(path);
                satellites = JsonConvert.DeserializeObject<LocalDefinedSatellites.JsonValue>(chunk) ?? new LocalDefinedSatellites.JsonValue();
            }
            else
                satellites = new LocalDefinedSatellites.JsonValue();


            var categoryExist = satellites.SatelliteCategories
                .FirstOrDefault(s => 
                s.Name != null && 
                s.Name.Equals(name.ToString(), StringComparison.OrdinalIgnoreCase));

            if (categoryExist != null) 
            {
                if (categoryExist.NoradIds == null)
                    categoryExist.NoradIds = new List<int>();

                foreach (var id in noradIds)
                {
                    if (!categoryExist.NoradIds.Contains(id))
                        categoryExist.NoradIds.Add(id);
                }
                return categoryExist;
            }
            else
            {
                var newDatas = new LocalDefinedSatellites.JsonType
                {
                    Name = name.ToString(),
                    NoradIds = noradIds ?? new List<int>()
                };
                satellites.SatelliteCategories.Add(newDatas);

                string updatedJson = JsonConvert.SerializeObject(satellites, Formatting.Indented);
                File.WriteAllText(path, updatedJson);

                return newDatas;
            }

        }

        public string RemoveSatellite([GraphQLType(typeof(SatelliteCategoryType))] SatelliteCategory name, int deleteId)
        {
             LocalDefinedSatellites.JsonValue satellites;
            if (File.Exists(path))
            {
                string chunk = File.ReadAllText(path);
                satellites = JsonConvert.DeserializeObject<LocalDefinedSatellites.JsonValue>(chunk)
                             ?? new LocalDefinedSatellites.JsonValue();
                
                var categoryExist = satellites.SatelliteCategories
                .FirstOrDefault(s => s.Name != null && s.Name.Equals(name.ToString(), StringComparison.OrdinalIgnoreCase));
                
                if (categoryExist == null)
                    throw new GraphQLException($"Category '{name}' not found.");


                if (categoryExist.NoradIds != null && categoryExist.NoradIds.Contains(deleteId))
                {
                    
                    categoryExist.NoradIds.Remove(deleteId);

                    string updatedJson = JsonConvert.SerializeObject(satellites, Formatting.Indented);
                    File.WriteAllText(path, updatedJson);

                    return $"{deleteId} value was successfully deleted";
                }
            }
            return $"{deleteId} value not found";
        }

        public bool UpdateSatellite([GraphQLType(typeof(SatelliteCategoryType))] SatelliteCategory name,int oldId, int newId) 
        {
            LocalDefinedSatellites.JsonValue satellites;
            if (File.Exists(path))
            {
                
                string chunk = File.ReadAllText(path);
                satellites = JsonConvert.DeserializeObject<LocalDefinedSatellites.JsonValue>(chunk) ?? new LocalDefinedSatellites.JsonValue();

                var categoryExist = satellites.SatelliteCategories
                .FirstOrDefault(s => s.Name != null && s.Name.Equals(name.ToString(), StringComparison.OrdinalIgnoreCase));

                if (categoryExist == null)
                    throw new GraphQLException($"Category '{name}' not found.");

                if (categoryExist.NoradIds.Contains(oldId))
                {
                    int index = categoryExist.NoradIds.IndexOf(oldId);
                    categoryExist.NoradIds[index] = newId;

                    string updatedJson = JsonConvert.SerializeObject(satellites, Formatting.Indented);
                    File.WriteAllText(path, updatedJson);

                    return true;
                }
            }
                return false;


        }
    }
}
