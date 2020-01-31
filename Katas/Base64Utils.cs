using System.Text;

namespace Katas
{
    public static class Base64Utils
    {
        public static string ToBase64(string s)
        {
            var bytes = Encoding.ASCII.GetBytes(s);
            return System.Convert.ToBase64String(bytes);
        }

        public static string FromBase64(string s)
        {
            var bytes = System.Convert.FromBase64String(s);
            return Encoding.ASCII.GetString(bytes);
        }
    }
}
