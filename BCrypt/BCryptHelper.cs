using Dynamicweb.Security.SystemTools;
using Dynamicweb.Security.UserManagement;
using System.Security.Cryptography;
namespace PilotApp.BCrypt
{
    public class BCryptHelper

    {
        public static string GenerateSalt()
        {
            var random = new RNGCryptoServiceProvider();

            // Maximum length of salt
            int max_length = 32;

            // Empty salt array
            byte[] salt = new byte[max_length];

            // Build the random bytes
            random.GetNonZeroBytes(salt);

            // Return the string encoded salt
            return Convert.ToBase64String(salt);
        }

        public static string HashPassword(string pwd, string salt)
        {
            string hashedPwd = Crypto.EncryptPassword(pwd, UserPasswordHashAlgorithm.SHA512);
            return hashedPwd;
        }

    }
}