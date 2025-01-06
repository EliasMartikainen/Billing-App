using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using BillingApp.Models;

namespace BillingApp.Services
{
    public class UserService
    {
        // In-memory storage for users
        private static List<User> _users = new List<User>();
        private static int _userIdCounter = 1;

        /// <summary>
        /// Creates a new user with a hashed password. Returns the created user.
        /// </summary>
        public User CreateUser(string username, string plainPassword, string role = "User")
        {
            // Check if username is taken
            if (_users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("Username already exists.");
            }

            var hashedPassword = HashPassword(plainPassword);

            // Convert string role to Role enum
            if (!Enum.TryParse(role, true, out Role userRole))
            {
                throw new ArgumentException("Invalid role specified.");
            }

            var newUser = new User
            {
                UserId = _userIdCounter++,
                Username = username,
                PasswordHash = hashedPassword,
                Role = userRole
            };

            _users.Add(newUser);
            return newUser;
        }

        /// <summary>
        /// Validate username/password. Returns User if valid, or null if invalid.
        /// </summary>
        public User? ValidateUser(string username, string plainPassword)
        {
            var user = _users
                .FirstOrDefault(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null) return null;

            // Compare hashed passwords
            var hashed = HashPassword(plainPassword);
            return (hashed == user.PasswordHash) ? user : null;
        }

        /// <summary>
        /// Get user by ID
        /// </summary>
        public User GetUserById(int userId)
        {
            return _users.FirstOrDefault(u => u.UserId == userId);
        }

        /// <summary>
        /// Return all users (for debugging or admin)
        /// </summary>
        public List<User> GetAllUsers()
        {
            return _users;
        }

        /// <summary>
        /// Basic password hashing using SHA256 (demo only, consider salted hashing like BCrypt in real apps).
        /// </summary>
        private string HashPassword(string plainPassword)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
                var builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
