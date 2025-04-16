using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFC.Contracts
{
	public interface ICipher
	{
		//make functions summary and description for each function
		/// <summary>
		/// Encrypts the given plaintext.
		/// <param name="plaintext">The plaintext to encrypt.</param>
		/// 
		
		/// <returns>The encrypted ciphertext.</returns>
		/// 
	
		/// <exception cref="ArgumentNullException">Thrown when plaintext is null.</exception>
		/// 
		
		string Encrypt(string plaintext);

		/// <summary>
		/// 

		/// Decrypts the given ciphertext.
		/// 

		/// <param name="ciphertext">The ciphertext to decrypt.</param>
		/// 

		/// <returns>The decrypted plaintext.</returns>
		/// 

		/// <exception cref="ArgumentNullException">Thrown when ciphertext is null.</exception>
		/// 

		string Decrypt(string ciphertext);


	}
}
