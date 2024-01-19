using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class IconService
    {
        private readonly AdventureLogContext _dbContext;

        public IconService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddIcon(Icon icon)
        {
            _dbContext.Icons.Add(icon);
            return Save();
        }

        public bool RemoveIcon(int id)
        {
            Icon? icon = _dbContext.Icons.Find(id);
            if (icon != null)
            {
                _dbContext.Icons.Remove(icon);
                return Save();
            }
            return false;
        }

        public bool AddIcons(IEnumerable<Icon> icons)
        {
            foreach (Icon icon in icons)
            {
                _dbContext.Icons.Add(icon);
            }
            return Save();
        }

        public bool RemoveIcons(IEnumerable<Icon> icons)
        {
            foreach (Icon icon in icons)
            {
                _dbContext.Icons.Remove(icon);
            }
            return Save();
        }

        public Icon? GetIcon(int id)
        {
            if (IconExists(id) == true)
            {
                return _dbContext.Icons.Find(id);
            }
            return null;
        }

        public IEnumerable<Icon> GetIcons()
        {
            return _dbContext.Icons.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdateIcon(Icon icon)
        {
            _dbContext.Icons.Update(icon);
            return Save();
        }

        public bool IconExists(int id)
        {
            return _dbContext.Icons.Any(m => m.Id == id);
        }
    }
}