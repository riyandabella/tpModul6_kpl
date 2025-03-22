public class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int nonton)
    {
        playCount += nonton;
    } 

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video: " + id);
        Console.WriteLine("Judul: " + title);
        Console.WriteLine("Play Count: " + playCount );
    }
}

public class Program
{
    public static void Main()
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract – Bella");
        vid.IncreasePlayCount(5);
        vid.PrintVideoDetails();
    }
}