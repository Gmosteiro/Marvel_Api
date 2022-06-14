using System.Security.Cryptography;
using System.Text;

namespace PruebasApis.MarvelApi
{
    public class Marvel
    {
        private const string URLBASE = "http://gateway.marvel.com/v1/public";
        private readonly string publicKey = "af09c13931ea272816d746655e13c3fb";
        private readonly string privateKey = "53b1eea498ac5e9757fd382daab13993807c8eae";
        private static HttpClient client = new HttpClient();

        public Marvel()
        {

        }







        private string crearHash(string datos)
        {
            var hash = "";
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(datos));

                StringBuilder sBuilder = new StringBuilder();
                for(int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                hash = sBuilder.ToString();
            }
                return hash;
        }

    }

}
