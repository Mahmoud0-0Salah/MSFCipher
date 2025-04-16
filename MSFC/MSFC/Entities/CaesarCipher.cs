using MSFC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFC.Entities
{
	internal class CaesarCipher : ICipher
	{
		private readonly int key;
		public CaesarCipher(int Key) => this.key = Key;
		public string Encrypt(string text)
		{
			if (text == null)
				throw new ArgumentNullException(nameof(text), "Text cannot be null.");

			string result = "";

			foreach (char c in text)
			{
				if (char.IsLetter(c))
				{
					char baseChar = char.IsUpper(c) ? 'A' : 'a';
					char shifted = (char)(((c - baseChar + key) % 26) + baseChar);
					result += shifted;
				}
				else
				{
					result += c; 
				}
			}

			return result;
		}

		public string Decrypt(string cipherText)
		{
			if (cipherText == null)
				throw new ArgumentNullException(nameof(cipherText), "Ciphertext cannot be null.");

			string result = "";

			foreach (char c in cipherText)
			{
				if (char.IsLetter(c))
				{
					char baseChar = char.IsUpper(c) ? 'A' : 'a';
					char shifted = (char)(((c - baseChar - key + 26) % 26) + baseChar);
					result += shifted;
				}
				else
				{
					result += c; 
				}
			}

			return result;
		}
	}
}
