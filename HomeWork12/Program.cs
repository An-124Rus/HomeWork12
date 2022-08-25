internal class Program
{
    private static void Main(string[] args)
    {
        float rubleToUsd = 60f;
        float usdToRuble = 0.0166f;
        float rubleToEuro = 59.5f;
        float euroToRuble = 0.0168f;
        float usdToEuro = 1.01f;
        float euroToUsd = 0.992f;
        string userInput;
        float currencyCount;

        Console.WriteLine("Добро пожаловать в конвертер валют.");
        Console.Write("Введите ваш баланс в рублях: ");
        float rub = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите ваш баланс в долларах: ");
        float usd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите ваш баланс в евро: ");
        float euro = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Нажмите - 1 для конвертации рублей в доллары");
        Console.WriteLine("Нажмите - 2 для конвертации долларов в рубли");
        Console.WriteLine("Нажмите - 3 для конвертации рублей в евро");
        Console.WriteLine("Нажмите - 4 для конвертации евро в рубли");
        Console.WriteLine("Нажмите - 5 для конвертации долларов в евро");
        Console.WriteLine("Нажмите - 6 для конвертации евро в доллары");
        Console.WriteLine("Для выхода нажмите - 0");
        userInput = (Console.ReadLine());

        while (userInput != "0")
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Конвертация рублей в доллары.");
                    Console.Write("Сколько рублей вы хотите конвертировать?: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());

                    if (rub > currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubleToUsd;

                        Console.WriteLine($"Ваш баланс {rub} рублей и {usd} долларов");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    break;

                case "2":
                    Console.WriteLine("Конвертация долларов в рубли.");
                    Console.Write("Сколько долларов вы хотите конвертировать?: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());

                    if (usd > currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount / usdToRuble;

                        Console.WriteLine($"Ваш баланс {usd} долларов и {rub} рублей");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество долларов");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    break;

                case "3":
                    Console.WriteLine("Конвертация рублей в евро.");
                    Console.Write("Сколько рублей вы хотите конвертировать?: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());

                    if (rub > currencyCount)
                    {
                        rub -= currencyCount;
                        euro += currencyCount / rubleToEuro;

                        Console.WriteLine($"Ваш баланс {rub} рублей и {euro} евро");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    break;

                case "4":
                    Console.WriteLine("Конвертация евро в рубли.");
                    Console.Write("Сколько евро вы хотите конвертировать?: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());

                    if (euro > currencyCount)
                    {
                        euro -= currencyCount;
                        rub += currencyCount / euroToRuble;

                        Console.WriteLine($"Ваш баланс {euro} евро и {rub} рублей");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество евро");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    break;

                case "5":
                    Console.WriteLine("Конвертация долларов в евро.");
                    Console.Write("Сколько долларов вы хотите конвертировать?: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());

                    if (usd > currencyCount)
                    {
                        usd -= currencyCount;
                        euro += currencyCount / usdToEuro;

                        Console.WriteLine($"Ваш баланс {usd} долларов и {euro} евро");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество долларов");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    break;

                case "6":
                    Console.WriteLine("Конвертация евро в доллары.");
                    Console.Write("Сколько евро вы хотите конвертировать?: ");
                    currencyCount = Convert.ToInt32(Console.ReadLine());

                    if (euro > currencyCount)
                    {
                        euro -= currencyCount;
                        usd += currencyCount / euroToUsd;

                        Console.WriteLine($"Ваш баланс {euro} евро и {usd} долларов");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество евро");
                        Console.WriteLine("Для новой конвертации нажите цифры с 1 по 6, для выхода нажмите - 0");
                        userInput = (Console.ReadLine());
                    }
                    break;
            }
        }

        Console.WriteLine($"Конвертация закончена. Ваш баланс {rub} рублей, {usd} долларов, {euro} евро.");
    }
}