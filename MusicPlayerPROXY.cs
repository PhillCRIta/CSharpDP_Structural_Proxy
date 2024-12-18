using Structural_Proxy.ExternalPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Proxy
{
	internal class MusicPlayerPROXY : IMusic //you must implement the interface of external package
	{
		private string _songId;
		private MusicPlayer _musicPlayer;//external class , used for compose the proxy class

		public MusicPlayerPROXY(string songId)
		{
			_songId = songId;
		}

		public string GetSongId()
		{
			return _songId;
		}

		public void PlaySound()
		{
			if (_musicPlayer == null)
			{
				_musicPlayer = new MusicPlayer(_songId);
			}
			_musicPlayer.PlaySound();
		}
	}
}
