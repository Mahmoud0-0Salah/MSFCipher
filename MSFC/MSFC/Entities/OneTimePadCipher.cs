using MSFC.Contracts;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MSFC.Entities
{
	internal class OneTimePadCipher : ICipher
	{
		private string key;


		public OneTimePadCipher()
		{
			key = string.Empty; 
		}

		public string GetKey() => key;

		public string Encrypt(string text)
		{
			if (text == null)
				throw new ArgumentNullException(nameof(text), "Text cannot be null.");

			key = GenerateRandomKey(text.Length);
			StringBuilder result = new StringBuilder(text.Length);

			for (int i = 0; i < text.Length; i++)
			{
				result.Append((char)(text[i] ^ key[i]));
			}

			return result.ToString();
		}

		public string Decrypt(string cipherText)
		{
			if (cipherText == null)
				throw new ArgumentNullException(nameof(cipherText), "Ciphertext cannot be null.");

			if (string.IsNullOrEmpty(key))
				throw new InvalidOperationException("Cannot decrypt without a valid key. Encrypt or set the key first.");

			if (cipherText.Length != key.Length)
				throw new ArgumentException("Ciphertext and key must be of the same length.");

			StringBuilder result = new StringBuilder(cipherText.Length);

			for (int i = 0; i < cipherText.Length; i++)
			{
				result.Append((char)(cipherText[i] ^ key[i]));
			}

			return result.ToString();
		}

		private string GenerateRandomKey(int length)
		{
			byte[] randomBytes = new byte[length];
			using (var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(randomBytes);
			}

			char[] keyChars = new char[length];
			for (int i = 0; i < length; i++)
			{
				keyChars[i] = (char)((randomBytes[i] % 95) + 32);
			}

			return new string(keyChars);
		}
	}
}
