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
		public ICipher GetOneTimePadCipher();
		public ICipher GetMonoalphabeticCipher(string key);
		public ICipher GetRowColumnTranspositionCipher(int key);
		public ICipher GetRailFenceCipher(int key);
	}
}
