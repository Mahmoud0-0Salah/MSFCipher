using MSFC.Contracts;
using System;
using System.Text;

namespace MSFC.Entities
{
	internal class RowColumnTranspositionCipher : ICipher
	{
		private readonly int columns;
		public RowColumnTranspositionCipher(int columns)
		{
			if (columns < 1)
				throw new ArgumentException("Number of columns must be greater than zero.", nameof(columns));

			this.columns = columns;
		}

		public string Encrypt(string text)
		{
			if (text == null)
				throw new ArgumentNullException(nameof(text), "Text cannot be null.");

			int rows = (int)Math.Ceiling((double)text.Length / columns);

			char[,] grid = new char[rows, columns];

			int index = 0;
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < columns; c++)
				{
					if (index < text.Length)
					{
						grid[r, c] = text[index];
						index++;
					}
					else
					{
						grid[r, c] = ' '; 
					}
				}
			}

			StringBuilder cipherText = new StringBuilder();
			for (int c = 0; c < columns; c++)
			{
				for (int r = 0; r < rows; r++)
				{
					cipherText.Append(grid[r, c]);
				}
			}

			return cipherText.ToString();
		}

		public string Decrypt(string cipherText)
		{
			if (cipherText == null)
				throw new ArgumentNullException(nameof(cipherText), "Ciphertext cannot be null.");

			int rows = (int)Math.Ceiling((double)cipherText.Length / columns);

			char[,] grid = new char[rows, columns];

			int index = 0;
			for (int c = 0; c < columns; c++)
			{
				for (int r = 0; r < rows; r++)
				{
					if (index < cipherText.Length)
					{
						grid[r, c] = cipherText[index];
						index++;
					}
				}
			}

			StringBuilder plainText = new StringBuilder();
			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < columns; c++)
				{
					plainText.Append(grid[r, c]);
				}
			}


			return plainText.ToString().TrimEnd(' ');
		}
	}
}
