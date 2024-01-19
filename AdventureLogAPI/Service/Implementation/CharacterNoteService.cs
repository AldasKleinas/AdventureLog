using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class CharacterNoteService
    {
        private readonly AdventureLogContext _dbContext;

        public CharacterNoteService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddCharacterNote(CharacterNote characterNote)
        {
            _dbContext.CharacterNotes.Add(characterNote);
            return Save();
        }

        public bool RemoveCharacterNote(int id)
        {
            CharacterNote? characterNote = _dbContext.CharacterNotes.Find(id);
            if (characterNote != null)
            {
                _dbContext.CharacterNotes.Remove(characterNote);
                return Save();
            }
            return false;
        }

        public bool AddCharacterNotes(IEnumerable<CharacterNote> characterNotes)
        {
            foreach (CharacterNote characterNote in characterNotes)
            {
                _dbContext.CharacterNotes.Add(characterNote);
            }
            return Save();
        }

        public bool RemoveCharacterNotes(IEnumerable<CharacterNote> characterNotes)
        {
            foreach (CharacterNote characterNote in characterNotes)
            {
                _dbContext.CharacterNotes.Remove(characterNote);
            }
            return Save();
        }

        public CharacterNote? GetCharacterNote(int id)
        {
            if (CharacterNoteExists(id) == true)
            {
                return _dbContext.CharacterNotes.Find(id);
            }
            return null;
        }

        public IEnumerable<CharacterNote> GetCharacterNotes()
        {
            return _dbContext.CharacterNotes.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdateCharacterNote(CharacterNote characterNote)
        {
            _dbContext.CharacterNotes.Update(characterNote);
            return Save();
        }

        public bool CharacterNoteExists(int id)
        {
            return _dbContext.CharacterNotes.Any(m => m.Id == id);
        }
    }
}
