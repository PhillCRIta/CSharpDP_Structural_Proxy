### Please note before start reading
Those code examples about design pattern have the purpose of personal use, to easily remember the patters; it's like a notepad. I took the following examples from Youtube and some web articles.

The major source of the examples is a Youtube channel of [DoableDanny](https://www.youtube.com/@doabledanny/videos), he's a very good developer. I suggest to all to buy 📒his book about design pattern 📒 , it's very clear.

# Proxy patternn
 The proxy pattern provide a proxy (delega, procura, procuratore) or agent to control access to another object with adds some functionality like caching, logging, lazy loading, access control without change client code. 

**CLIENT > PROXY > TARGET**

In our example: when I dedice to play a song, the class proxy call the concrete class to create new object and then it start the download of file; after the file is downloaded, the proxy call PlaySong of concrete class. Wwith this Proxy , the song is downloaded only when i want play a song, if the song already downloaded, it is not necessary to download again.