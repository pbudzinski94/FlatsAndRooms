using FlatAndRooms.Models;
using FlatsAndRooms.Repositories;
using FlatsAndRooms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Services
{
    public class UserService
    {
        private UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public IEnumerable<UserVM> GetAllUsers()
        {
            IEnumerable<User> users = userRepository.Get();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (var item in users)
            {
                userVMs.Add(MapUserToUserVM(item));
            }
            return userVMs;
        }
        public void AddFewUsersToDatabase(IEnumerable<UserVM> users)
        {
            List<User> temp = new List<User>();
            foreach (var item in users)
            {
                temp.Add(MapUserVMToUser(item));
            }
            userRepository.Create(temp);
        }
        private UserVM MapUserToUserVM(User user)
        {
            return new UserVM() { EMail = user.EMail, NickName = user.NickName, PhoneNumber = user.PhoneNumber, UserId = user.UserId };
        }
        private User MapUserVMToUser(UserVM user)
        {
            Guid guid = (user.UserId != null) ? user.UserId : Guid.NewGuid();
            return new User() { EMail = user.EMail, NickName = user.NickName, PhoneNumber = user.PhoneNumber, UserId = guid };
        }
    }
}
