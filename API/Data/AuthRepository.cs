using System;
using System.Threading.Tasks;
using API.Data;
using CostManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CostManagementAPI.Data
{
    public class AuthRepository : IAuthRepository
    {
        public ApplicationDbContext _Context { get; set; }
        public AuthRepository(ApplicationDbContext context)
        {
            _Context = context;
        }
        public async Task<User> Login(string username, string password)
        {
            var user = await _Context.User.FirstOrDefaultAsync(x => x.Username == username);

            if(user == null)
              return null;

            // if(!VerifyPasswordHash(password,user.PasswordHash,user.PasswordSalt))
            //     return null;

            return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
               var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
               for (int i = 0; i < computeHash.Length; i++)
               {
                   if(computeHash[i] != passwordHash[i]) 
                        return false;
               }
            }
            return true;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordhash, passwordsalt;
            CreatePassword(password, out passwordhash, out passwordsalt);

            user.PasswordHash = passwordhash;
            user.PasswordSalt = passwordsalt;

            await _Context.User.AddAsync(user);
            await _Context.SaveChangesAsync();
            return user;
        }

        private void CreatePassword(string password, out byte[] passwordhash, out byte[] passwordsalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordsalt = hmac.Key;
                passwordhash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _Context.User.AnyAsync(x => x.Username == username))
                return true;

            return false;
        }

        public string GenerateIsbn(string isbn) // string must have 9 digits
        {
            if (isbn == null)
                throw new ArgumentNullException();

            isbn = NormalizeIsbn(isbn);

            if (isbn.Length != 9)
                throw new ArgumentException();

            int result;
            for (int i = 0; i != 9; i++)
                if (!int.TryParse(isbn[i].ToString(), out result))
                    throw new ArgumentException();

            int sum = 0;
            for (int i = 0; i != 9; i++)
                sum += (i + 1) * int.Parse(isbn[i].ToString());

            int remainder = sum % 11;
            if (remainder == 10)
                return isbn + 'X';
            else
                return isbn + (char)('0' + remainder);
        }

        public string NormalizeIsbn(string isbn)
        {
            return isbn.Replace("-", "").Replace(" ", "");
        }

    }
}