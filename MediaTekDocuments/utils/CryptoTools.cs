using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.utils
{
    /// <summary>
    /// Classe utilitaire concernant la cryptographie des mots de passes basée sur la Password-Based Key Derivation Function 2 (pbkdf2)
    /// </summary>
    public class CryptoTools
    {
        /// <summary>
        /// Constante concernant la taille du salt (64 Bytes)
        /// </summary>
        private const int SALT_SIZE = 64;
        /// <summary>
        /// Taille du hash (sans sel) 512 Bits = 64 Bytes car SHA512
        /// </summary>
        private const int HASH_SIZE = 64;
        /// <summary>
        /// Nombre d'iterations de dérivation de clefs 
        /// Constante définie sur une valeur conseillée par l'OWASP https://cheatsheetseries.owasp.org/cheatsheets/Password_Storage_Cheat_Sheet.html#pbkdf2
        /// </summary>
        private const int ITERATIONS = 210000;
        /// <summary>
        /// Algorithme de hashage utilisé (SHA512)
        /// </summary>
        private static readonly HashAlgorithmName ALGO = HashAlgorithmName.SHA512;
        /// <summary>
        /// Génère un hash salé depuis une chaîne en clair.
        /// </summary>
        /// <param name="plaintext">Chaîne à hasher</param>
        /// <returns>string somme de contrôle finale encodée en base64</returns>
        public static string HashPassword(string plaintext)
        {
            if(plaintext.Length <= 0) {
                return string.Empty;
            } 
            byte[] salt = new byte[SALT_SIZE];
            var generator = RandomNumberGenerator.Create();
            generator.GetBytes(salt);
            Rfc2898DeriveBytes hasher = new Rfc2898DeriveBytes(plaintext, salt, ITERATIONS, ALGO);
            byte[] hash = hasher.GetBytes(HASH_SIZE);
            byte[] hashBytes = new byte[SALT_SIZE + HASH_SIZE];
            Array.Copy(salt, 0, hashBytes, 0, SALT_SIZE);
            Array.Copy(hash, 0, hashBytes, SALT_SIZE, HASH_SIZE);
            return Convert.ToBase64String(hashBytes);

        }
        /// <summary>
        /// Méthode de vérification d'identité entre un mot de passe en claire et un hash de référence
        /// </summary>
        /// <param name="plaintext">Mot de passe en clair</param>
        /// <param name="hashReference">HASH de référence (base64)</param>
        /// <returns>true si le mot de passe en clair correspond au hash de référence, false sinon</returns>
        public static bool VerifyPassword(string plaintext, string hashReference)
        {
            if(plaintext.Length <= 0 || hashReference.Length <= 0) {
                return false;
            }
            byte[] hashBytes = Convert.FromBase64String(hashReference);
            byte[] salt = new byte[SALT_SIZE];
            Array.Copy(hashBytes, 0, salt, 0, SALT_SIZE); 
            var pbkdf2 = new Rfc2898DeriveBytes(plaintext, salt, ITERATIONS, ALGO);
            byte[] hash = pbkdf2.GetBytes(HASH_SIZE);
            for(int i = 0; i < HASH_SIZE; i++) {
                if (hash[i] != hashBytes[SALT_SIZE + i]) {
                    return false;
                }
            }
            return true;
        }
    }
}
