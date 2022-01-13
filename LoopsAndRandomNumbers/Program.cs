// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//programm küsib kasutajal sisestada Pin-Koodi;
//programm võrdleb sisestatud pin koodi arvuga 1234;
//kui sisestatud pin kood 1234, siis konsool kuvab "tere tulemast"; 
//kui sisestatud midagi muud, siis konsool kuvab: Vale pin;
//kasutajal on 3 katset;

int i=0; //i interaction
while (i < 3) //While-loop > i=1; 1<3 --> true; 2<3 --> true; 3<3 --> False 
{
    Console.WriteLine("palun sisesta pin");
    int userPin = Convert.ToInt32(Console.ReadLine());
    if (userPin == 1234)
    {
        Console.WriteLine("Tere tulemast");
        break;
    }
    else
    {
        //(i=i+1) == i++
        i++;

        Console.WriteLine($"Vale PIN, {3 - i} katset on jäänud.");
    }
}
        Console.WriteLine("Kena päeva");
