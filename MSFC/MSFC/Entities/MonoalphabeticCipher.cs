using MSFC.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSFC.Entities
{
	internal class MonoalphabeticCipher : ICipher
	{
		private readonly Dictionary<char, char> encryptMap;
		private readonly Dictionary<char, char> decryptMap;

		public MonoalphabeticCipher(string key)
		{
			if (string.IsNullOrEmpty(key))
				throw new ArgumentException("Key cannot be null or empty.", nameof(key));

			key = key.ToUpper();

			if (key.Length != 26 || !IsValidKey(key))
				throw new ArgumentException("Key must be a permutation of 26 unique uppercase letters.");

			encryptMap = new Dictionary<char, char>();
			decryptMap = new Dictionary<char, char>();

			char current = 'A';
			foreach (char k in key)
			{
				encryptMap[current] = k;
				decryptMap[k] = current;
				current++;
			}
		}

		public string Encrypt(string text)
		{
			if (text == null)
				throw new ArgumentNullException(nameof(text), "Text cannot be null.");

			StringBuilder result = new StringBuilder();

			foreach (char c in text)
			{
				if (char.IsLetter(c))
				{
					bool isUpper = char.IsUpper(c);
					char upperChar = char.ToUpper(c);
					char mapped = encryptMap[upperChar];

					result.Append(isUpper ? mapped : char.ToLower(mapped));
				}
				else
				{
					result.Append(c);
				}
			}

			return result.ToString();
		}

		public string Decrypt(string cipherText)
		{
			if (cipherText == null)
				throw new ArgumentNullException(nameof(cipherText), "Ciphertext cannot be null.");

			StringBuilder result = new StringBuilder();

			foreach (char c in cipherText)
			{
				if (char.IsLetter(c))
				{
					bool isUpper = char.IsUpper(c);
					char upperChar = char.ToUpper(c);
					char mapped = decryptMap[upperChar];

					result.Append(isUpper ? mapped : char.ToLower(mapped));
				}
				else
				{
					result.Append(c);
				}
			}

			return result.ToString();
		}

		private bool IsValidKey(string key)
		{
			var seen = new HashSet<char>();
			foreach (char c in key)
			{
				if (!char.IsUpper(c) || !seen.Add(c))
					return false;
			}
			return seen.Count == 26;
		}
	}
}
