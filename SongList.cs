using Structural_Proxy.ExternalPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Proxy
{
	internal class SongList
	{
		private Dictionary<string, IMusic> _songList=new Dictionary<string, IMusic>();
		public void Add(IMusic song)
		{
			_songList.Add(song.GetSongId(), song);
		}
		public void PlaySong(string songId)
		{
			var song = _songList[songId];
			song.PlaySound();
		}
	}
}
