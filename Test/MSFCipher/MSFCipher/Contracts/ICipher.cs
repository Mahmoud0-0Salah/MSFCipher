using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFCipher.Contracts
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
	
		/// <exception cref="ArgumentNullException">Thrown when plaintext or key is null.</exception>
		/// 
		
		/// <exception cref="ArgumentException">Thrown when the key is invalid.</exception>
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

		/// <exception cref="ArgumentNullException">Thrown when ciphertext or key is null.</exception>
		/// 

		/// <exception cref="ArgumentException">Thrown when the key is invalid.</exception>
		///		

		string Decrypt(string ciphertext);


	}
}
