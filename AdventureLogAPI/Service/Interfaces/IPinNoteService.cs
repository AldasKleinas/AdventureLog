using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface IPinNoteService
    {
        public bool AddPinNote(PinNote pinNote);

        public bool RemovePinNote(int id);

        public bool AddPinNotes(IEnumerable<PinNote> pinNotes);

        public bool RemovePinNotes(IEnumerable<PinNote> pinNotes);

        public PinNote? GetPinNote(int id);

        public IEnumerable<PinNote> GetPinNotes();

        public bool UpdatePinNote(PinNote pinNote);

        public bool PinNoteExists(int id);
    }
}
