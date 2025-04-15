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
		public CaesarCipher GetCaesarCipher(int key);
 
	}
}
