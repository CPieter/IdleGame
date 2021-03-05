using Logic.Model;
using System;
using System.Collections.Generic;

namespace DataInterface
{
    public interface IUserDA
    {
        User Create(User user);
        List<User> ReadAll();
        int Delete(Guid id);
    }
}
