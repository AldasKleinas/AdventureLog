using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Interfaces
{
    public interface IUserService
    {
        public bool AddUser(User user);

        public bool RemoveUser(int id);

        public bool AddUsers(IEnumerable<User> users);

        public bool RemoveUsers(IEnumerable<User> users);

        public User? GetUser(int id);

        public IEnumerable<User> GetUsers();

        public bool UpdateUser(User user);

        public bool UserExists(int id);
    }
}
