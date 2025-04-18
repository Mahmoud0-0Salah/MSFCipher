using MSFC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSFC.Contracts
{
	public interface IMSFCipher
	{
		public ICipher GetCaesarCipher(int key);
		public ICipher GetVernamCipher(string key);

	}
}
