using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface ICharacterNoteService
    {
        public bool AddCharacterNote(CharacterNote characterNote);

        public bool RemoveCharacterNote(int id);

        public bool AddCharacterNotes(IEnumerable<CharacterNote> characterNotes);

        public bool RemoveCharacterNotes(IEnumerable<CharacterNote> characterNotes);

        public CharacterNote? GetCharacterNote(int id);

        public IEnumerable<CharacterNote> GetCharacterNotes();

        public bool UpdateCharacterNote(CharacterNote characterNote);

        public bool CharacterNoteExists(int id);
    }
}
