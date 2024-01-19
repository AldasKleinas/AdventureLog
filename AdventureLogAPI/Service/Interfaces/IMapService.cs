using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface IMapService
    {
        public bool AddMap(Map map);

        public bool RemoveMap(int id);

        public bool AddMaps(IEnumerable<Map> maps);

        public bool RemoveMaps(IEnumerable<Map> maps);

        public Map? GetMap(int id);

        public IEnumerable<Map> GetMaps();

        public bool UpdateMap(Map map);

        public bool MapExists(int id);
    }
}
