using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        if (title == null)
            throw new ArgumentNullException("Title tidak boleh null");

        if (title.Length > 100)
            throw new ArgumentException("Title terlalu panjang");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int nonton)
    {
        if (nonton <= 0 || nonton > 10000000)
            throw new ArgumentException("\nInput penambahan play count" +
                " maksimal 10.000.000 per panggilan method-nya");

        try
        {
            checked
            {
                playCount += nonton;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("-- SUDAH OVERFLOW --");
            return;
        }
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

        for (int i = 0; i < 215; i++)
        {
            vid.IncreasePlayCount(10000000);
            vid.PrintVideoDetails();
        }
    }
}