// See https://aka.ms/new-console-template for more information
using ClassRoom;
using ClassRoom.Pupils;

Console.WriteLine("Hello, World!");
//Upcast
Pupil firstExcellentPupil = new ExcellentPupil("Pesho", "Peshev", ConsoleColor.Red);
Pupil sexondExcellentPupil = new ExcellentPupil("Gosho", "Peev", ConsoleColor.Green);
Pupil goodPupil = new GoodPupil("Minka", "Mineva", ConsoleColor.Blue);
Pupil badPupil = new BadPupil("Kaka", "Lara", ConsoleColor.DarkGray);


ClassRoomMain classRoom = new ClassRoomMain(firstExcellentPupil, sexondExcellentPupil, goodPupil, badPupil);

Console.WriteLine($"There are {classRoom.GetCountOfPupils()} pupils in the Classroom");
Console.WriteLine($"{new string('*', 50)}\n");

//
// Polymorphism

foreach (Pupil pupil in classRoom.pupils)
{
    //DownCast
    if (pupil is ExcellentPupil e)
    {
        e.Study();
        e.Read();
        e.Write();
        e.Relax();
        Console.WriteLine($"{new string('*', 50)}\n");
        //  Console.ResetColor();
    }

    //DownCast
    else if ((pupil as GoodPupil) != null)
    {
        pupil.Study();
        pupil.Read();
        pupil.Write();
        pupil.Relax();
        Console.WriteLine($"{new string('*', 50)}\n");
        // Console.ResetColor();
    }

    //DownCast
    else if (pupil is BadPupil)
    {
        Pupil anotherPupil = (Pupil)pupil;
        anotherPupil.Study();
        anotherPupil.Read();
        anotherPupil.Write();
        anotherPupil.Relax();
        Console.WriteLine($"{new string('*', 50)}\n");
        Console.ResetColor();
    }
}
