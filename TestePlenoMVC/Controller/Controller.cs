using Google.Authenticator;
using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestePlenoMVC.Model;

namespace TestePlenoMVC.Controller
{
    public class Controller
    {
        Usuario usuario = new Usuario();


        public string GenerateSecretKey()
        {
            byte[] keyS = new byte[10];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(keyS);
            }

            usuario.key = keyS;
            return Google.Authenticator.Base32Encoding.ToString(keyS);
        }

        public Image GenerateQRCode()
        {

            var authenticator = new TwoFactorAuthenticator();
            var secret = GenerateSecretKey();
            var setupInfo = authenticator.GenerateSetupCode("Teste Pleno", "Authenticator", secret, true);
            string qrCodeUrl = setupInfo.QrCodeSetupImageUrl;
            byte[] imageBytes = Convert.FromBase64String(qrCodeUrl.Replace("data:image/png;base64,", ""));
            using (var ms = new MemoryStream(imageBytes))
            {
                var QrCode = Image.FromStream(ms);
                return QrCode;
            }
        }

        public bool ValidateSecretKey(string code)
        {
            var totp = new Totp(usuario.key);
            long timeStep = 0;
            return totp.VerifyTotp(code, out timeStep, null);
        }

        public bool SaveUser(string user, string pass)
        {
            if (user != "" && pass != "")
            {
                usuario.usuario = user;
                usuario.senha = pass;

                return true;
            }
            return false;
        }

        public bool ValidateUser(string user, string pass, string code)
        {
            if(user == usuario.usuario &&  pass == usuario.senha && ValidateSecretKey(code))
            { return true; }

            return false;

        }

    }
}

