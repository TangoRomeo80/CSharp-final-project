﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;
using System.Drawing;
using System.IO;

namespace WalletBuddy.Executor
{
  class UserServices
  {
    UserDataAccess userDataAccess;

    public UserServices()
    {
      this.userDataAccess = new UserDataAccess();
    }

    public List<User> GetAllUserList()
    {
      return userDataAccess.GetAllUserList();
    }

    public Image GetProfilePicture(User user)
    {
      return userDataAccess.GetProfilePicture(user);
    }

    public int GetUserId(string userName)
    {
      return userDataAccess.GetUserId(userName);
    }

    public string GetUserName(int userId)
    {
      return userDataAccess.GetUserName(userId);
    }

    public int AddUser(User user)
    {
      return userDataAccess.AddUser(user);
    }

    /*public int AddUser(User user)
    {
      this.userDataAccess = new UserDataAccess();
      return this.userDataAccess.AddUser(user);
    }*/

    public int RemoveUser(User user)
    {
      return userDataAccess.RemoveUser(user);
    }

    public string CheckUserName(string userName)
    {
      User user = new User()
      {
        UserName = userName
      };
      return this.userDataAccess.CheckUserName(user);
    }

    public string CheckUserType(string userName)
    {
      User user = new User()
      {
        UserId = GetUserId(userName),
        UserName = userName
      };

      return userDataAccess.CheckUserType(user);
    }

    public bool UserLoginValidate(string userName, string userPassword)
    {
      User user = new User()
      {
        UserId = GetUserId(userName),
        UserName = userName,
        UserPassword = userPassword
      };

      return userDataAccess.UserLoginValidate(user);
    }

    public User GetUserInfo(User user)
    {
      return userDataAccess.GetUserInfo(user);
    }

    public int ChangeInfo(User user, User userToModify)
    {
      return userDataAccess.ChangeInfo(user, userToModify);
    }

    public int ChangePassword(User user, User userToModify)
    {
      return userDataAccess.ChangePassword(user, userToModify);
    }

    public byte[] ConvertToByte(Image image)
    {
      MemoryStream ms = new MemoryStream();
      image.Save(ms, image.RawFormat);
      return ms.GetBuffer();
    }



  }
}
