using MSFC.Contracts;
using System;
using System.Text;

namespace MSFC.Entities
{
	internal class RailFenceCipher : ICipher
	{
		private readonly int rails;

		public RailFenceCipher(int key)
		{
			if (key < 2)
				throw new ArgumentException("Number of rails must be greater than one.", nameof(key));

			rails = key;
		}

		public string Encrypt(string text)
		{
			if (text == null)
				throw new ArgumentNullException(nameof(text), "Text cannot be null.");

			char[,] grid = new char[rails, text.Length];

			int direction = 1; 
			int row = 0;
			for (int i = 0; i < text.Length; i++)
			{
				grid[row, i] = text[i];

				if (row == 0)
					direction = 1;
				else if (row == rails - 1)
					direction = -1;

				row += direction;
			}

			StringBuilder cipherText = new StringBuilder();
			for (int r = 0; r < rails; r++)
			{
				for (int c = 0; c < text.Length; c++)
				{
					if (grid[r, c] != '\0') 
						cipherText.Append(grid[r, c]);
				}
			}

			return cipherText.ToString();
		}

		public string Decrypt(string cipherText)
		{
			if (cipherText == null)
				throw new ArgumentNullException(nameof(cipherText), "Ciphertext cannot be null.");

			char[,] grid = new char[rails, cipherText.Length];

			int direction = 1;
			int row = 0;
			for (int i = 0; i < cipherText.Length; i++)
			{
				grid[row, i] = '*'; 
				if (row == 0)
					direction = 1;
				else if (row == rails - 1)
					direction = -1;

				row += direction;
			}

			int index = 0;
			for (int r = 0; r < rails; r++)
			{
				for (int c = 0; c < cipherText.Length; c++)
				{
					if (grid[r, c] == '*')
					{
						grid[r, c] = cipherText[index++];
					}
				}
			}

			StringBuilder plainText = new StringBuilder();
			row = 0;
			direction = 1;
			for (int i = 0; i < cipherText.Length; i++)
			{
				plainText.Append(grid[row, i]);
				if (row == 0)
					direction = 1;
				else if (row == rails - 1)
					direction = -1;

				row += direction;
			}

			return plainText.ToString();
		}
	}
}
