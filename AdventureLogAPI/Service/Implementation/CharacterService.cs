using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class CharacterService
    {
        private readonly AdventureLogContext _dbContext;

        public CharacterService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddCharacter(Character character)
        {
            _dbContext.Characters.Add(character);
            return Save();
        }

        public bool RemoveCharacter(int id)
        {
            Character? character = _dbContext.Characters.Find(id);
            if (character != null)
            {
                _dbContext.Characters.Remove(character);
                return Save();
            }
            return false;
        }

        public bool AddCharacters(IEnumerable<Character> characters)
        {
            foreach (Character character in characters)
            {
                _dbContext.Characters.Add(character);
            }
            return Save();
        }

        public bool RemoveCharacters(IEnumerable<Character> characters)
        {
            foreach (Character character in characters)
            {
                _dbContext.Characters.Remove(character);
            }
            return Save();
        }

        public Character? GetCharacter(int id)
        {
            if (CharacterExists(id) == true)
            {
                return _dbContext.Characters.Find(id);
            }
            return null;
        }

        public IEnumerable<Character> GetCharacters()
        {
            return _dbContext.Characters.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdateCharacter(Character character)
        {
            _dbContext.Characters.Update(character);
            return Save();
        }

        public bool CharacterExists(int id)
        {
            return _dbContext.Characters.Any(m => m.Id == id);
        }
    }
}
