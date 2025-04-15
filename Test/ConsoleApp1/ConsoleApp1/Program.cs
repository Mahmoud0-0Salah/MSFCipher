using MSFC;
using MSFC.Contracts;
using MSFC.Entities;
namespace ConsoleApp1
{

	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a new instance of the MSFCipher class
			IMSFCipher MSF = new MSFCipher();

			ICipher cipher = new MSFCipher().GetCaesarCipher(3);
			Console.WriteLine($"--------------------------Caesar--------------------------");
			// Encrypt a message
			string message = "Hello, World!";
			string encryptedMessage = cipher.Encrypt(message);
			Console.WriteLine($"Encrypted Message: {encryptedMessage}");

			// Decrypt the message
			string decryptedMessage = cipher.Decrypt(encryptedMessage);
			Console.WriteLine($"Decrypted Message: {decryptedMessage}");
			Console.WriteLine($"----------------------------------------------------------");
		}
	}
}
