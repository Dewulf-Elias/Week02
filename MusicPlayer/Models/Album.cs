namespace MusicPlayer.Models;

public class Album
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public Genre Genre { get; set; }
    public int Year { get; set; }
    public List<Song> Songs { get; set; }

    public Album(string name, string artist, Genre genre, int year)
    {
        Name = name;
        Artist = artist;
        Genre = genre;
        Year = year;
        Songs = new List<Song>();
    }

    public Song GetLongestSong()
    {
        Song longest = Songs[0];
        foreach (Song song in Songs)
        {
            if (song.Duration > longest.Duration)
            {
                longest = song;
            }
        }
        return longest;
    }

    public int TotalDuration()
    {
        int total = 0;
        foreach (Song song in Songs)
        {
            total += song.Duration;
        }
        return total;
    }
}
