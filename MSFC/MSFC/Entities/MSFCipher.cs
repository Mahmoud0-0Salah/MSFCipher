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

		public CaesarCipher GetCaesarCipher(int key)
		{
			return new CaesarCipher(key);
		}

	}
}
