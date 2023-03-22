using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sypher
{
    public class GuillouQuisquater
    {
        private RSAParameters publicKey;
        private RSAParameters privateKey;

        public GuillouQuisquater()
        {
            GenerateKeys();
        }

        private void GenerateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
            }
        }

        public byte[] Encrypt(byte[] message)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(publicKey);
                return rsa.Encrypt(message, true);
            }
        }

        public byte[] Decrypt(byte[] encryptedMessage)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(privateKey);
                return rsa.Decrypt(encryptedMessage, true);
            }
        }
    }
}
