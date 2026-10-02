using MusicPlayer.Models;

Song song1 = new Song("Bohemian Rhapsody", 354);
Song song2 = new Song("Under Pressure", 248);
Song song3 = new Song("Don't Stop Me Now", 209);

Album album = new Album("Greatest Hits", "Queen", Genre.Rock, 1981);
album.Songs.Add(song1);
album.Songs.Add(song2);
album.Songs.Add(song3);

Player player = new Player();

// één voor één
player.PlaySong(song1);
player.PlaySong(song2);
player.PlaySong(song3);
Console.WriteLine();

// overloading: zelfde naam, maar nu met een album
player.PlaySong(album);
Console.WriteLine();

// een methode die een Song-object teruggeeft
Song longest = album.GetLongestSong();
Console.Write("Longest -> ");
player.PlaySong(longest);

Console.WriteLine($"Total duration: {album.TotalDuration()} seconds");
