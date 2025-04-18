using MSFC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFC.Entities
{
	public class MSFCipher : IMSFCipher
	{
		public MSFCipher() { }

		public ICipher GetCaesarCipher(int key)
		{
			return new CaesarCipher(key);
		}

		public ICipher GetMonoalphabeticCipher(string key)
		{
			return new MonoalphabeticCipher(key);
		}

		public ICipher GetOneTimePadCipher()
		{
			return new OneTimePadCipher();
		}

		public ICipher GetRowColumnTranspositionCipher(int key)
		{
			return new RowColumnTranspositionCipher(key);
		}

		public ICipher GetVernamCipher(string key)
		{
			return new VernamCipher(key);
		}
	}
}
