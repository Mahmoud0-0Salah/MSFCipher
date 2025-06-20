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
		private string key;

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
				this.key = MatchLengthWithDynamicPad(key,text, new char[] { 'A', 'B', 'C', 'D', 'E', '*', '#', '@','$','%', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' });

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

		private string MatchLengthWithDynamicPad(string input, string target, char[] padChars)
		{
			int targetLength = target.Length;
			int inputLength = input.Length;

			if (inputLength > targetLength)
			{
				return input.Substring(0, targetLength); 
			}
			else if (inputLength < targetLength)
			{
				int padCount = targetLength - inputLength;
				var sb = new StringBuilder(input);

				for (int i = 0; i < padCount; i++)
				{
					char padChar = padChars[i % padChars.Length]; 
					sb.Append(padChar);
				}

				return sb.ToString();
			}

			return input; 
		}


	}
}
