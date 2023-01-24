Random rnd = new Random();
var randomNumber = rnd.Next(1, 11);
var userNumber = 0;
bool valid = false;
int i = 0;
bool[] givenNumbers = new bool[10];

Console.Title = "Gra Zgadnij Liczbę!";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Zasady: Zgadnij liczbę z przedziału 1 - 10!\n");
Console.ResetColor();

do
{
    do
    {
        Console.Write("Podaj liczbę: ");
        valid = int.TryParse(Console.ReadLine(), out userNumber);
        if (!valid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Podaj prawidłową liczbę całkowitą!");
            Console.ResetColor();
        }
    } while (!valid);

    if (userNumber < 1 || userNumber > 10)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Podaj liczbę z zakresu 1-10!");
        Console.ResetColor();
        continue;
    }

    if (givenNumbers[userNumber - 1])
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Podana liczba była już typowana!");
        Console.ResetColor();
        continue;
    }
    else
    {
        givenNumbers[userNumber - 1] = true;
    }

    if (randomNumber < userNumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Wylosowana liczba jest mniejsza od Twojej..");
        Console.ResetColor();
    }
    else if (randomNumber > userNumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Wylosowana liczba jest większa od Twojej..");
        Console.ResetColor();
    }
    i++;

} while (userNumber != randomNumber);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Brawo!! Odgadłeś wylosowaną liczbę za {i} próbą!");
Console.ResetColor();

Console.ReadKey();
