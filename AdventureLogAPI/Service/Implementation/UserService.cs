using AdventureLogAPI.Models;

namespace AdventureLogAPI.Service.Implementation
{
    public class UserService
    {
        private readonly AdventureLogContext _dbContext;

        public UserService(AdventureLogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddUser(User user)
        {
            _dbContext.Users.Add(user);
            return Save();
        }

        public bool RemoveUser(int id)
        {
            User? user = _dbContext.Users.Find(id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                return Save();
            }
            return false;
        }

        public bool AddUsers(IEnumerable<User> users)
        {
            foreach (User user in users)
            {
                _dbContext.Users.Add(user);
            }
            return Save();
        }

        public bool RemoveUsers(IEnumerable<User> users)
        {
            foreach (User user in users)
            {
                _dbContext.Users.Remove(user);
            }
            return Save();
        }

        public User? GetUser(int id)
        {
            if (UserExists(id) == true)
            {
                return _dbContext.Users.Find(id);
            }
            return null;
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0;
        }

        public bool UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            return Save();
        }

        public bool UserExists(int id)
        {
            return _dbContext.Users.Any(m => m.Id == id);
        }
    }
}