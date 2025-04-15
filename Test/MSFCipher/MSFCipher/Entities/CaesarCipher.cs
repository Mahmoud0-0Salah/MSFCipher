using MSFCipher.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFCipher.Entities
{
	internal class CaesarCipher : ICipher
	{
		private readonly int key;
		public CaesarCipher(int Key) => this.key = Key;

		public string Encrypt(string text)
		{
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

		public string Decrypt(string text)
		{
			return Encrypt(text); 
		}
	}
}
