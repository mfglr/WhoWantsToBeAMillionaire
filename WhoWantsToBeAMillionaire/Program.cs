
int numberOfCorrectAnswers = 0;
string answer;

// 1. soru
Console.WriteLine("UNESCO tarafından \"Dünya Mirası Listesi\"ne alınan ve “beyaz traverten terasları” ile ünlü doğal oluşum Türkiye’nin hangi ilinde yer alır?\n");
Console.WriteLine("A)Denizli");
Console.WriteLine("B)Mardin\n");

Console.Write("Cevabınızı giriniz: ");
answer = Console.ReadLine().ToLower();

if (answer == "a")
{
    numberOfCorrectAnswers++;
    Console.WriteLine("\nTebrikler doğru cevap!\n");
}
else
{
    Console.WriteLine("\nMaalesef yanlış cevap!\n");
}


//2. soru
Console.WriteLine("Mona Lisa tablosunun ressamı kimdir?\n");
Console.WriteLine("A)Leonardo da Vinci");
Console.WriteLine("B)Michelangelo\n");

Console.Write("Cevabınızı giriniz: ");
answer = Console.ReadLine().ToLower();

if (answer == "a")
{
    numberOfCorrectAnswers++;
    Console.WriteLine("\nTebrikler doğru cevap!\n");
}
else
{
    Console.WriteLine("\nMaalesef yanlış cevap!\n");
}


if (numberOfCorrectAnswers == 2)
    Console.WriteLine("Tebrikler büyük ödülü kazandınız!");
else
{
    // 3. soru
    Console.WriteLine("Bir bakkal, bir kalemi 8 TL’den alıp %25 kâr ile satıyor. Kalemin satış fiyatı kaç TL olur?\n");
    Console.WriteLine("A)9");
    Console.WriteLine("B)10\n");

    Console.Write("Cevabınızı giriniz: ");
    answer = Console.ReadLine().ToLower();

    if (answer == "b")
    {
        numberOfCorrectAnswers++;
        Console.WriteLine("\nTebrikler doğru cevap!\n");
    }
    else
    {
        Console.WriteLine("\nMaalesef yanlış cevap!\n");
    }

    if (numberOfCorrectAnswers >= 2)
        Console.WriteLine("Tebrikler büyük ödülü kazandınız!");
    else
    {
        Console.WriteLine("Maalesef büyük ödülü kaybettiniz!");
    }
}



