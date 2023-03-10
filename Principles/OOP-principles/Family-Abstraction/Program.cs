//https://dotnettutorials.net/lesson/abstraction-csharp-realtime-example/

public class Startup
{
    public static void Main()
    {
        List<Person> people = new List<Person>();
        List<string> ties = new List<string>();

        string searchNameOrBirthday = Console.ReadLine();
        string inputLine = Console.ReadLine();
        while (inputLine != "End")
        {
            string[] parts = inputLine.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 1)
            {
                string[] args = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = $"{args[0]} {args[1]}";
                string birthday = args[2];
                Person person = new Person(name, birthday);
                people.Add(person);
            }
            else
            {
                ties.Add(inputLine);
            }
            inputLine = Console.ReadLine();
        }

        foreach (string tie in ties)
        {
            Person parent = new Person();
            Person child = new Person();

            string[] parts = tie.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            if (parts[0].Contains("/") && parts[1].Contains("/"))
            {
                string parentBirthday = parts[0];
                string childBirthday = parts[1];

                parent = people.First(p => p.Birthday == parentBirthday);
                child = people.First(p => p.Birthday == childBirthday);
            }
            else if (parts[0].Contains("/") || parts[1].Contains("/"))
            {
                if (parts[0].Contains("/"))
                {
                    string birthday = parts[0];
                    string name = parts[1];

                    parent = people.First(p => p.Birthday == birthday);
                    child = people.First(p => p.Name == name);
                }
                else
                {
                    string birthday = parts[1];
                    string name = parts[0];

                    parent = people.First(p => p.Name == name);
                    child = people.First(p => p.Birthday == birthday);
                }
            }
            else
            {
                string parentName = parts[0];
                string childName = parts[1];

                parent = people.First(p => p.Name == parentName);
                child = people.First(p => p.Name == childName);
            }

            if (!parent.Children.Contains(child))
            {
                parent.Children.Add(child);
            }
            if (!parent.Parents.Contains(parent))
            {
                child.Parents.Add(parent);
            }
        }

        Person searchPerson = new Person();
        if (searchNameOrBirthday.Contains("/"))
        {
            searchPerson = people.First(p => p.Birthday == searchNameOrBirthday);
        }
        else
        {
            searchPerson = people.First(p => p.Name == searchNameOrBirthday);
        }

        Console.WriteLine($"{searchPerson.Name} {searchPerson.Birthday}");
        Console.WriteLine($"Parents:");
        if (searchPerson.Parents.Count > 0)
        {
            foreach (Person parent in searchPerson.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
        }
        Console.WriteLine($"Children:");
        if (searchPerson.Children.Count > 0)
        {
            foreach (Person child in searchPerson.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
    }
}

public class Person
{
    private string name;
    private string birthday;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.parents = new List<Person>();
        this.children = new List<Person>();
    }

    public Person(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Birthday
    {
        get { return this.birthday; }
        set { this.birthday = value; }
    }

    public List<Person> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }

    public List<Person> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }
}