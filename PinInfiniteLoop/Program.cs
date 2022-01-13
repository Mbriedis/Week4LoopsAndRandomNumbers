// See https://aka.ms/new-console-template for more information

//programm küsib kasutajal sisestada Pin-Koodi;
//programm võrdleb sisestatud pin koodi arvuga 1234;
//kui sisestatud pin kood 1234, siis konsool kuvab "tere tulemast"; 
//kui sisestatud midagi muud, siis konsool kuvab: Vale pin;
//katsete arv on piiramatu
bool loopActive = true; //boolean -->true/false
int i=0;

while (loopActive)
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

        Console.WriteLine("Vale PIN, proovi uuesti!");
        Console.WriteLine($"Oled vale PIN {i} korda sisestanud.");
    }
}
Console.WriteLine("Kena päeva");
