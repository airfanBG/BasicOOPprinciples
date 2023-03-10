// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public interface IRemote
{
    void Run();
}
public class Television : IRemote
{
    protected Television()
    {
    }
    static Television()
    {
        _television = new Television();
    }
    private static Television _television;
    public static Television Instance
    {
        get
        {
            return _television;
        }
    }
    public void Run()
    {
        Console.WriteLine("Television is started!");
    }
}
public class Remote
{
    IRemote _remote;
    public Remote(IRemote remote)
    {
        _remote = remote;
    }

    public void Run()
    {
        _remote.Run();
    }
}