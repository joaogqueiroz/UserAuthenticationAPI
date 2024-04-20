using AspNetAPIProject02.Data.Contexts;
using AspNetAPIProject02.Data.Entities;
using AspNetAPIProject02.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetAPIProject02.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SqlServerContext _context;

        public UserRepository(SqlServerContext context)
        {
            _context = context;
        }
        //Dependency injection
        public void Create(User user)
        {
            _context.Entry(user).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Read(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Entry(user).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<User> GetAll()
        {
            //teste
            return _context.User.OrderBy(u => u.Name).ToList();
        }

        public User GetByID(Guid id)
        {
            return _context.User.Find(id);
        }

        public User Get(string email)
        {
            throw new NotImplementedException();
        }

        public User Get(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
