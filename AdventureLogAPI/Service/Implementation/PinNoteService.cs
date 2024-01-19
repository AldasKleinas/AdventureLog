using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class PinNoteService
    {
        private readonly AdventureLogContext _dbContext;

        public PinNoteService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddPinNote(PinNote pinNote)
        {
            _dbContext.PinNotes.Add(pinNote);
            return Save();
        }

        public bool RemovePinNote(int id)
        {
            PinNote? pinNote = _dbContext.PinNotes.Find(id);
            if (pinNote != null)
            {
                _dbContext.PinNotes.Remove(pinNote);
                return Save();
            }
            return false;
        }

        public bool AddPinNotes(IEnumerable<PinNote> pinNotes)
        {
            foreach (PinNote pinNote in pinNotes)
            {
                _dbContext.PinNotes.Add(pinNote);
            }
            return Save();
        }

        public bool RemovePinNotes(IEnumerable<PinNote> pinNotes)
        {
            foreach (PinNote pinNote in pinNotes)
            {
                _dbContext.PinNotes.Remove(pinNote);
            }
            return Save();
        }

        public PinNote? GetPinNote(int id)
        {
            if (PinNoteExists(id) == true)
            {
                return _dbContext.PinNotes.Find(id);
            }
            return null;
        }

        public IEnumerable<PinNote> GetPinNotes()
        {
            return _dbContext.PinNotes.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdatePinNote(PinNote pinNote)
        {
            _dbContext.PinNotes.Update(pinNote);
            return Save();
        }

        public bool PinNoteExists(int id)
        {
            return _dbContext.PinNotes.Any(m => m.Id == id);
        }
    }
}