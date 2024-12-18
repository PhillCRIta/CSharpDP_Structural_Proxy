using Structural_Proxy;
using Structural_Proxy.ExternalPackage;
/*
 The proxy pattern provide a proxy (delega, procura, procuratore) or agent to control access to another object 
 with adds some functionality like caching, logging, lazy loading, access control without change client code
CLIENT > PROXY > TARGET
 */

var songList = new SongList();
var songListProxy = new SongList();
string[] songIds = { "asd", "123", "poiu" };
//in this case for every MusicPlayer added to the list, the program download immediatly the song
foreach (var songId in songIds)
{
	//the musicplayer class is an external class , you can't modify it
	songList.Add(new MusicPlayer(songId));
}
songList.PlaySong("poiu");
songList.PlaySong("poiu");
//to delaying the download operation or other activities you must create an object proxy
//video list mustn't dialogue directly with music player class

Console.WriteLine("***************Using a proxy object");
//instead in case of Proxy, only when i dedice to play a song, the class proxy call the concrete class to create new object and then it start the download of file,
//after the file is downloaded, the proxy call PlaySong of concrete class
//with this Proxy , the song is downloaded only when i want play a song
//if the song already downloaded , it is not necessary to download again
foreach (var songId in songIds)
{
	//the musicplayer class is an external class , you can't modify it
	songListProxy.Add(new MusicPlayerPROXY(songId));
}
songListProxy.PlaySong("poiu");
songListProxy.PlaySong("poiu");
songListProxy.PlaySong("123");
//songListProxy.PlaySong("a"); >> throw an error
