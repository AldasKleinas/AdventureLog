using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface IIconService
    {
        public bool AddIcon(Icon icon);

        public bool RemoveIcon(int id);

        public bool AddIcons(IEnumerable<Icon> icons);

        public bool RemoveIcons(IEnumerable<Icon> icons);

        public Icon? GetIcon(int id);

        public IEnumerable<Icon> GetIcons();

        public bool UpdateIcon(Icon icon);

        public bool IconExists(int id);
    }
}
