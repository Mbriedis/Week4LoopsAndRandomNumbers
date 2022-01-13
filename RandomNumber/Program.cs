// See https://aka.ms/new-console-template for more information
//programm genereerib juhuslikku numbrit 1-10;
//kui genereeritud number on 5, programm lõpetab oma tööd ja soovib kasutajale kena päeva;
//kui genereeritud number on midagi muud, programm jätkab oma tööd;
Random rnd=new Random();   
int i=0;
while (i != 5)
{
    int myRandomNumber = rnd.Next(1, 11) ;
    Console.WriteLine($"juhuslik number on: {myRandomNumber}");
    if(myRandomNumber == 5)
    { i = myRandomNumber; }
}
Console.WriteLine("Kena päeva!");    