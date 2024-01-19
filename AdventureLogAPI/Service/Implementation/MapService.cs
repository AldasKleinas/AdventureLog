using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class MapService
    {
        private readonly AdventureLogContext _dbContext;

        public MapService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddMap(Map map)
        {
            _dbContext.Maps.Add(map);
            return Save();
        }

        public bool RemoveMap(int id)
        {
            Map? map = _dbContext.Maps.Find(id);
            if (map != null)
            {
                _dbContext.Maps.Remove(map);
                return Save();
            }
            return false;
        }

        public bool AddMaps(IEnumerable<Map> maps)
        {
            foreach (Map map in maps)
            {
                _dbContext.Maps.Add(map);
            }
            return Save();
        }

        public bool RemoveMaps(IEnumerable<Map> maps)
        {
            foreach (Map map in maps)
            {
                _dbContext.Maps.Remove(map);
            }
            return Save();
        }

        public Map? GetMap(int id)
        {
            if (MapExists(id) == true)
            {
                return _dbContext.Maps.Find(id);
            }
            return null;
        }

        public IEnumerable<Map> GetMaps()
        {
            return _dbContext.Maps.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdateMap(Map map)
        {
            _dbContext.Maps.Update(map);
            return Save();
        }

        public bool MapExists(int id)
        {
            return _dbContext.Maps.Any(m => m.Id == id);
        }
    }
}