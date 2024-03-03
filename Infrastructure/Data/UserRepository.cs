using System;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly FlashCatStorage _storage;

    public UserRepository(FlashCatStorage storage)
    {
        _storage = storage;
    }

    public async Task<User> GetUserByIdAsync(int id)
    {
        return await _storage.Users.FindAsync(id);
    }

    public async Task<IReadOnlyList<User>> GetUsersAsync()
    {
        return await _storage.Users.ToListAsync();
    }

    public void CreateUser(User user)
    {
        _storage.Users.Add(user);
    }

    public void SaveChanges()
    {
        _storage.SaveChanges();
    }
}
}