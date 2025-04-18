using MSFC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFC.Entities
{
	internal class VernamCipher : ICipher
	{
		private readonly string key;

		public VernamCipher(string key)
		{
			if (string.IsNullOrEmpty(key))
				throw new ArgumentException("Key cannot be null or empty.", nameof(key));

			this.key = key;
		}

		public string Encrypt(string text)
		{
			if (text == null)
				throw new ArgumentNullException(nameof(text), "Text cannot be null.");

			if (text.Length != key.Length)
				throw new ArgumentException("Text and key must be of the same length.");

			StringBuilder result = new StringBuilder();

			for (int i = 0; i < text.Length; i++)
			{
				char encryptedChar = (char)(text[i] ^ key[i]);
				result.Append(encryptedChar);
			}

			return result.ToString();
		}

		public string Decrypt(string cipherText)
		{
			return Encrypt(cipherText); // Encryption and decryption are the same in Vernam Cipher
		}
	}
}
