using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface IPinService
    {
        public bool AddPin(Pin pin);

        public bool RemovePin(int id);

        public bool AddPins(IEnumerable<Pin> pins);

        public bool RemovePins(IEnumerable<Pin> pins);

        public Pin? GetPin(int id);

        public IEnumerable<Pin> GetPins();

        public bool UpdatePin(Pin pin);

        public bool PinExists(int id);
    }
}
