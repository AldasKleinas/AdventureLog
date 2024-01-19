using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class PinService
    {
        private readonly AdventureLogContext _dbContext;

        public PinService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddPin(Pin pin)
        {
            _dbContext.Pins.Add(pin);
            return Save();
        }

        public bool RemovePin(int id)
        {
            Pin? pin = _dbContext.Pins.Find(id);
            if (pin != null)
            {
                _dbContext.Pins.Remove(pin);
                return Save();
            }
            return false;
        }

        public bool AddPins(IEnumerable<Pin> pins)
        {
            foreach (Pin pin in pins)
            {
                _dbContext.Pins.Add(pin);
            }
            return Save();
        }

        public bool RemovePins(IEnumerable<Pin> pins)
        {
            foreach (Pin pin in pins)
            {
                _dbContext.Pins.Remove(pin);
            }
            return Save();
        }

        public Pin? GetPin(int id)
        {
            if (PinExists(id) == true)
            {
                return _dbContext.Pins.Find(id);
            }
            return null;
        }

        public IEnumerable<Pin> GetPins()
        {
            return _dbContext.Pins.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdatePin(Pin pin)
        {
            _dbContext.Pins.Update(pin);
            return Save();
        }

        public bool PinExists(int id)
        {
            return _dbContext.Pins.Any(m => m.Id == id);
        }
    }
}