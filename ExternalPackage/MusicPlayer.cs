using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Proxy.ExternalPackage
{
	internal class MusicPlayer : IMusic
	{
		private string _songId;

		public MusicPlayer(string songId)
		{
			_songId = songId;
			Download();
		}

		private void Download()
		{
			Console.WriteLine("I'm downloading song with id: " + _songId);
		}

		public string GetSongId()
		{
			return _songId;
		}

		public void PlaySound()
		{
			Console.WriteLine("Let's now plaiyng the song: " + _songId);
		}
	}
}
