using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface ICharacterService
    {
        public bool AddCharacter(Character character);

        public bool RemoveCharacter(int id);

        public bool AddCharacters(IEnumerable<Character> characters);

        public bool RemoveCharacters(IEnumerable<Character> characters);

        public Character? GetCharacter(int id);

        public IEnumerable<Character> GetCharacters();

        public bool UpdateCharacter(Character character);

        public bool CharacterExists(int id);
    }
}
