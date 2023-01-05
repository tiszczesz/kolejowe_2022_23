// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text;

 string CalculateSha1(string text)
{
    var enc = Encoding.ASCII; //
    byte[] buffer = enc.GetBytes(text);

    var sha1 = System.Security.Cryptography.SHA1.Create();

    var hash = sha1.ComputeHash(buffer);

    return enc.GetString(hash);
}
 string HashSHA1Decryption(string value)
        {
            var shaSHA1 = System.Security.Cryptography.SHA1.Create();
            var inputEncodingBytes = Encoding.ASCII.GetBytes(value);
            var hashString = shaSHA1.ComputeHash(inputEncodingBytes);

            var stringBuilder = new StringBuilder();
            var itf8 = Encoding.UTF8;
            for (var x = 0; x < hashString.Length; x++)
            {
                stringBuilder.Append(hashString[x].ToString("x2"));
            }
            return stringBuilder.ToString();
        }

Console.WriteLine(HashSHA1Decryption("jjj"));
// string test = "jjj"; // forgive me

// string shouldBe = "c84c766f873ecedf75aa6cf35f1e305e095fec83"; // according to http://www.sha1-online.com/

// string wouldBe = CalculateSha1(test);
// Console.WriteLine(wouldBe);
// //System.Diagnostics.Debug.Assert(shouldBe.Equals(wouldBe));




