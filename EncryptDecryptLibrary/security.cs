using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecryptLibrary
{

    /*
    openssl genrsa -des3 -out private.pem 2048
    openssl rsa -in private.pem -outform PEM -pubout -out public.pem
    */

    public class securityPasswordFinderInterface : IPasswordFinder
    {
        private string password { get; set; }
        public char[] GetPassword()
        {
            char[] result = this.password.ToCharArray();
            return result;
        }
        public securityPasswordFinderInterface(string password)
        {
            this.password = password;
            this.GetPassword();
        }
    }


    public class securityHelper
    {
        public string Encrypt(string plainText, string publicCertificateFile)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            
            PemReader pr = new PemReader(
                (StreamReader)File.OpenText(publicCertificateFile)
            );
            RsaKeyParameters keys = (RsaKeyParameters)pr.ReadObject();

            OaepEncoding eng = new OaepEncoding(new RsaEngine());
            eng.Init(true, keys);

            int length = plainTextBytes.Length;
            int blockSize = eng.GetInputBlockSize();
            List<byte> cipherTextBytes = new List<byte>();
            for (int chunkPosition = 0;
                chunkPosition < length;
                chunkPosition += blockSize)
            {
                int chunkSize = Math.Min(blockSize, length - chunkPosition);
                cipherTextBytes.AddRange(eng.ProcessBlock(
                    plainTextBytes, chunkPosition, chunkSize
                ));
            }
            return Convert.ToBase64String(cipherTextBytes.ToArray());
        }
        
        public string Decrypt(string encryptedText, string certificateKey, string privateCertificateFile)
        {
            try
            {

                byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);

                IPasswordFinder pf = new securityPasswordFinderInterface(certificateKey);
                PemReader pr = new PemReader(
                    (StreamReader)File.OpenText(privateCertificateFile), pf
                );

                AsymmetricCipherKeyPair keys = (AsymmetricCipherKeyPair)pr.ReadObject();

                OaepEncoding eng = new OaepEncoding(new RsaEngine());
                eng.Init(false, keys.Private);

                int length = cipherTextBytes.Length;
                int blockSize = eng.GetInputBlockSize();
                List<byte> plainTextBytes = new List<byte>();
                for (int chunkPosition = 0;
                    chunkPosition < length;
                    chunkPosition += blockSize)
                {
                    int chunkSize = Math.Min(blockSize, length - chunkPosition);
                    plainTextBytes.AddRange(eng.ProcessBlock(
                        cipherTextBytes, chunkPosition, chunkSize
                    ));
                }
                return Encoding.UTF8.GetString(plainTextBytes.ToArray());
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}





