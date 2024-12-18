using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Proxy.ExternalPackage
{
	internal interface IMusic
	{
		void PlaySound();
		string GetSongId();
	}
}
