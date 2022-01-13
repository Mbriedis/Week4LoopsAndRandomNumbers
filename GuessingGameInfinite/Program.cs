// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//programm genereerib juhuslikku numbrit 1-10;
//kasutaja peab ära arvama numbri;
//kui kasutaja suutis numbrit ära arvata, siis on mängu võitnud;
//katsete arv on piiramatu;
//programm genereerib juhuslikku numbrit 1.kord;
Random rnd = new Random();
int cpuNumber = rnd.Next(1, 11);
int i=0;
while (i < cpuNumber)   
{
    Console.WriteLine("Arva ära number");
    int GuessNr = Convert.ToInt32(Console.ReadLine());
    if (cpuNumber == GuessNr)
    {
        Console.WriteLine("Oled võitnud!");
        break;
    }
    else
    {
        //(i=i+1) == i++
        i++;

        Console.WriteLine("proovi uuesti!");
        Console.WriteLine($"oled {i} korda proovinud!");
    }
}
Console.WriteLine("Kena päeva");

