using MSFC;
using MSFC.Contracts;
using MSFC.Entities;
namespace ConsoleApp1
{

	internal class Program
	{
		static void Main(string[] args)
		{
			IMSFCipher MSF = new MSFCipher();

			ICipher cipher = MSF.GetCaesarCipher(3);
			Console.WriteLine($"--------------------------Caesar--------------------------");
			// Encrypt a message
			string message = "Hello, World!";
			string encryptedMessage = cipher.Encrypt(message);
			Console.WriteLine($"Encrypted Message: {encryptedMessage}");

			// Decrypt the message
			string decryptedMessage = cipher.Decrypt(encryptedMessage);
			Console.WriteLine($"Decrypted Message: {decryptedMessage}");
			Console.WriteLine($"----------------------------------------------------------\n");

			Console.WriteLine($"--------------------------Vernam--------------------------");
			cipher = MSF.GetVernamCipher("TestTestTestT");
			// Encrypt a message
			encryptedMessage = cipher.Encrypt(message);
			Console.WriteLine($"Encrypted Message: {encryptedMessage}");

			// Decrypt the message
			decryptedMessage = cipher.Decrypt(encryptedMessage);
			Console.WriteLine($"Decrypted Message: {decryptedMessage}");
			Console.WriteLine($"----------------------------------------------------------\n");


			Console.WriteLine($"--------------------------OneTimePad--------------------------");
			cipher = MSF.GetOneTimePadCipher();
			// Encrypt a message
			encryptedMessage = cipher.Encrypt(message);
			Console.WriteLine($"Encrypted Message: {encryptedMessage}");

			// Decrypt the message
			decryptedMessage = cipher.Decrypt(encryptedMessage);
			Console.WriteLine($"Decrypted Message: {decryptedMessage}");
			Console.WriteLine($"----------------------------------------------------------\n");

			Console.WriteLine($"--------------------------Monoalphabetic--------------------------");
			cipher = MSF.GetMonoalphabeticCipher("QWERTYUIOPASDFGHJKLZXCVBNM");
			// Encrypt a message
			encryptedMessage = cipher.Encrypt(message);
			Console.WriteLine($"Encrypted Message: {encryptedMessage}");

			// Decrypt the message
			decryptedMessage = cipher.Decrypt(encryptedMessage);
			Console.WriteLine($"Decrypted Message: {decryptedMessage}");
			Console.WriteLine($"----------------------------------------------------------\n");

			Console.WriteLine($"--------------------------RowColumnTransposition--------------------------");
			cipher = MSF.GetRowColumnTranspositionCipher(5);
			// Encrypt a message
			encryptedMessage = cipher.Encrypt(message);
			Console.WriteLine($"Encrypted Message: {encryptedMessage}");

			// Decrypt the message
			decryptedMessage = cipher.Decrypt(encryptedMessage);
			Console.WriteLine($"Decrypted Message: {decryptedMessage}");
			Console.WriteLine($"----------------------------------------------------------\n");
		}
	}
}
