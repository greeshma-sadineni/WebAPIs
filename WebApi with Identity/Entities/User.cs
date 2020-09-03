using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_with_Identity.Entities
{
    public class User
    {[Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LasttName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] PassWordHash { get; set; }
        [Required]
        public byte[] PassWordSalt { get; set; }


        public void CreatePasswordHash(string password)
        {
           using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                PassWordSalt = hmac.Key;
                PassWordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        public bool VerifyPasswordHash(string password)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(PassWordSalt))
            {
                var computedhash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i <computedhash.Length; i++)
                {
                    if (computedhash[i] != PassWordHash[i])
                        return false;
                }
            }
            return true;
        }
    }
}
