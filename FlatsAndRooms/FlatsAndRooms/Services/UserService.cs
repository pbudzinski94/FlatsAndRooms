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
        public IEnumerable<UserToShowVM> GetAllUsers()
        {
            IEnumerable<User> users = userRepository.Get();
            List<UserToShowVM> userVMs = new List<UserToShowVM>();
            foreach (var item in users)
            {
                userVMs.Add(MapUserToUserVM(item));
            }
            return userVMs;
        }
        public bool AddUser(UserToShowVM user)
        {
            return userRepository.Create(MapUserVMToUser(user));
        }
        private UserToShowVM MapUserToUserVM(User user)
        {
            return new UserToShowVM() { EMail = user.EMail, NickName = user.NickName, PhoneNumber = user.PhoneNumber, UserId = user.UserId };
        }
        private User MapUserVMToUser(UserToShowVM user)
        {
            Guid guid = (user.UserId != Guid.Empty) ? user.UserId : Guid.NewGuid();
            return new User() { EMail = user.EMail, NickName = user.NickName, PhoneNumber = user.PhoneNumber, UserId = guid };
        }

    }
}
