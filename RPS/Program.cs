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
        while (true)
        {
            Console.WriteLine("Ваш выбор: ");
            string userInput = Console.ReadLine();

            if (userInput == "стоп")
            {
                break;
            }
            if (userInput != Rock && userInput != Scissors && userInput != Paper)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, попробуйте еще раз.");
                continue;
            }
            int Choice = random.Next(1, 4);
            string PSChoice = "";
            if (Choice == 1)
            {
                PSChoice = Rock;
            }
            else if (Choice == 2)
            {
                PSChoice = Paper;
            }
            else if (Choice == 3)
            {
                PSChoice = Scissors;
            }
            Console.WriteLine($"Выбор оппонента: {PSChoice}");
            if (PSChoice == userInput)
            {
                Console.WriteLine("ничья");
            }
            else if ((userInput == Rock && PSChoice == Scissors) || (userInput == Paper && PSChoice == Rock) || (userInput == Scissors && PSChoice == Paper))
            {
                Console.WriteLine("Вы выиграли");
            }
            else
            {
                Console.WriteLine("Вы проиграли");
            }
        }
    }
}