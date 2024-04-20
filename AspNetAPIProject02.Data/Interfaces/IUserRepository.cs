using AspNetAPIProject02.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetAPIProject02.Data.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        void Read(User user);
        void Delete(User user);
        List<User> GetAll();
        User GetByID(Guid id);
        User Get(string email);
        User Get(string email, string password);
    }
}
