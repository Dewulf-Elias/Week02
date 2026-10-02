namespace MusicPlayer.Models;

public class Player
{
    public void PlaySong(Song song)
    {
        Console.WriteLine($"Playing song: {song.Title}");
    }

    public void PlaySong(Album album)
    {
        Console.WriteLine($"Playing album: {album.Name} - {album.Artist}");
        foreach (Song song in album.Songs)
        {
            PlaySong(song);
        }
    }
}
