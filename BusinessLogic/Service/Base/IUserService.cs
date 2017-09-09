﻿using BusinessLogic.DTO.User;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Service.Base
{
    public interface IUserService
    {
        User GetUser(int id);
        UserInfoViewModel GetUserByLogin(string login);
        void EditUser(UserEditViewModel user);
        bool RegisterUser(UserRegistrationViewModel user);
        IEnumerable<User> GetUsers();
        IEnumerable<User> GetUsersFriends(int id);
        IEnumerable<Group> GetUsersGroups(int id);
        IEnumerable<Message> GetUsersMessages(int id);
        void UserNotification(IEnumerable<Message> messages);

    }
}
