using System;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUserRepository
    {
         Task<User> GetUserByIdAsync(int id);
        Task<IReadOnlyList<User>> GetUsersAsync();
        void CreateUser(User user);
         void SaveChanges();
    }
}