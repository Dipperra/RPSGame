using System;

class Program
{
    public const string Paper = "бумага";
    public const string Rock = "камень";
    public const string Scissors = "ножницы";

    static void Main()
    {
        Console.WriteLine("Введите 'камень', 'ножницы' или 'бумага' для игры.");
        Console.WriteLine("Введите 'стоп' для завершения игры.");
        Random random = new Random();
        Console.WriteLine("Ваш выбор: ");

        while (true)
        {
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "стоп")
            {
                break;
            }
            if (userInput != Rock && userInput != Scissors && userInput != Paper)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, попробуйте еще раз.");
                continue;
            }

            string PSChoice = GetpsChoice(random);
            Console.WriteLine($"Выбор оппонента: {PSChoice}");
            string result = GetResult(userInput, PSChoice);
            Console.WriteLine(result);
        }
    }

    static string GetpsChoice(Random random)
    {
        int choice = random.Next(1, 4);
        string psChoice = choice switch
        {
            1 => Rock,
            2 => Paper,
            3 => Scissors
        };

        return psChoice;
    }

    static string GetResult(string userChoice, string psChoice)
    {
        if (userChoice == psChoice)
        {
            return "ничья";
        }
        else if ((userChoice == Rock && psChoice == Scissors) || (userChoice == Paper && psChoice == Rock) || (userChoice == Scissors && psChoice == Paper))
        {
            return "Вы выиграли";
        }
        else
        {
            return "Вы проиграли";
        }
    }
}
