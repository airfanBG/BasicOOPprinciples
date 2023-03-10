//https://dotnettutorials.net/lesson/inheritance-c-sharp/

public class Startup
{
    public static void Main()
    {
        List<Song> songs = new List<Song>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] inputParts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                if (inputParts.Length != 3)
                {
                    throw new InvalidDataException("Some msg");
                }
                ParseSong(songs, inputParts);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        PrintTotalTime(songs);
    }

    private static void ParseSong(List<Song> songs, string[] inputParts)
    {
        string[] time = inputParts[2].Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
        int minutes;
        int seconds;
        if (int.TryParse(time[0], out minutes) && int.TryParse(time[1], out seconds))
        {
            Song song = new Song(inputParts[0], inputParts[1], minutes, seconds);
            songs.Add(song);
            Console.WriteLine("Song added.");
        }
        else
        {
            throw new InvalidDataException("Some msg");
        }
    }

    private static void PrintTotalTime(List<Song> songs)
    {
        long totalSecond = songs.Sum(m => m.Minutes * 60) + songs.Sum(s => s.Seconds);
        TimeSpan ts = TimeSpan.FromSeconds(totalSecond);
        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {ts.Hours}h {ts.Minutes}m {ts.Seconds}s");
    }
}


public class Song
{
    private const int ArtistMinNameLength = 3;
    private const int ArtistMaxNameLength = 20;
    private const int SongMinNameLength = 3;
    private const int SongMaxNameLength = 30;
    private const int MinutesMin = 0;
    private const int MinutesMax = 14;
    private const int SecondsMin = 0;
    private const int SecondsMax = 59;

    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public int Seconds
    {
        get { return this.seconds; }
        set
        {
            if (value < SecondsMin || value > SecondsMax)
            {
                throw new InvalidDataException("Some msg");
            }
            this.seconds = value;
        }
    }

    public int Minutes
    {
        get { return this.minutes; }
        set
        {
            if (value < MinutesMin || value > MinutesMax)
            {
                throw new InvalidDataException("Some msg");
            }
            this.minutes = value;
        }
    }

    public string SongName
    {
        get { return this.songName; }
        set
        {
            if (value.Length < SongMinNameLength || value.Length > SongMaxNameLength)
            {
                throw new InvalidDataException("Some msg");
            }
            this.songName = value;
        }
    }

    public string ArtistName
    {
        get { return this.artistName; }
        set
        {
            if (value.Length < ArtistMinNameLength || value.Length > ArtistMaxNameLength)
            {
                throw new InvalidDataException("Some msg");
            }
            this.artistName = value;
        }
    }
}