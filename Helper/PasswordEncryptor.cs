using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSIP.Helper
{
    public class PasswordEncryptor
    {
        // Encrypts the password, the admin enters 
        
       public string PassWordEncryptor(string value)
        {
            try
            {
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    UTF8Encoding utf8 = new UTF8Encoding();
                    byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                    return Convert.ToBase64String(data);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong" + error);
            }

            return value;
        }

    }
}
