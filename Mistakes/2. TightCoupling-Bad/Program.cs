// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//https://www.partech.nl/nl/publicaties/2021/06/coupling-in-c-sharp
//https://en.wikipedia.org/wiki/Coupling_(computer_programming)
public class Remote
{
    private Television Tv { get; set; }
    protected Remote()
    {
        Tv = new Television();
    }
    static Remote()
    {
        _remoteController = new Remote();
    }
    static Remote _remoteController;
    public static Remote Control
    {
        get
        {
            return _remoteController;
        }
    }
    public void RunTv()
    {
        Tv.Start();
    }
}
public class Television
{
    public void Start()
    {

    }
}