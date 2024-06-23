using System;

namespace homeWorkTwelveСurrencyСonverter
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            const string CommandRubConvertToDollar = "1";
            const string CommandRubConvertToEuro = "2";
            const string CommandDollarsConvertToRubles = "3";
            const string CommandDollarsConvertToEuro = "4";
            const string CommandEuroConvertToRubles = "5";
            const string CommandEuroConvertToDollars = "6";
            const string CommandExit = "7";
            
            float numberRubles = 1000;
            float numberDollars = 1000;
            float numberEuro = 1000;
            float rubConvertToDollar = 0.07f;
            float rubConvertToEuro = 0.08f;
            float dollarsConvertToRubles = 70f;
            float dollarsConvertToEuro = 1.5f;
            float euroConvertToDollars = 0.9f;
            float euroConvertToRubles = 80;

            bool isRunning = true;

            string userCommand;

            float exchangeCurrencyNumber;

            while (isRunning)
            {
                Console.WriteLine($"You have {numberRubles} rubles, {numberDollars} dollars and {numberEuro} euro on your account\n");

                Console.WriteLine("Select the desired operation: ");
                Console.WriteLine($"{CommandRubConvertToDollar}.exchange rubles for dollars.");
                Console.WriteLine($"{CommandRubConvertToEuro}.exchange rubles for euro.");
                Console.WriteLine($"{CommandDollarsConvertToRubles}.exchange dollars for rubles.");
                Console.WriteLine($"{CommandDollarsConvertToEuro}.exchange dollars for euro.");
                Console.WriteLine($"{CommandEuroConvertToDollars}.exchange euro for dollars.");
                Console.WriteLine($"{CommandEuroConvertToRubles}.exchange euro for rubles.");
                Console.WriteLine($"{CommandExit}.Close end of application\n");

                userCommand = Console.ReadLine();

                switch (userCommand)
                {
                    case CommandRubConvertToDollar:
                        Console.Write("What amount rubles do you want to exchange?: ");
                        exchangeCurrencyNumber = Convert.ToSingle(Console.ReadLine());

                        if (numberRubles >= exchangeCurrencyNumber)
                        {
                            numberRubles -= exchangeCurrencyNumber;
                            numberDollars += exchangeCurrencyNumber * rubConvertToDollar;
                        }
                        else
                        {
                            Console.WriteLine("not enough rubles on the account.\n");
                        }
                        break;

                    case CommandRubConvertToEuro:
                        Console.Write("What amount rubles do you want to exchange?: ");
                        exchangeCurrencyNumber = Convert.ToSingle(Console.ReadLine());

                        if (numberRubles >= exchangeCurrencyNumber)
                        {
                            numberRubles -= exchangeCurrencyNumber;
                            numberEuro += exchangeCurrencyNumber * rubConvertToEuro;
                        }
                        else
                        {
                            Console.WriteLine("not enough rubles on the account.\n");
                        }
                        break;

                    case CommandDollarsConvertToRubles:
                        Console.Write("What amount dollars do you want to exchange?: ");
                        exchangeCurrencyNumber = Convert.ToSingle(Console.ReadLine());

                        if (numberDollars >= exchangeCurrencyNumber)
                        {
                            numberDollars -= exchangeCurrencyNumber;
                            numberRubles += exchangeCurrencyNumber * dollarsConvertToRubles;
                        }
                        else
                        {
                            Console.WriteLine("not enough dollars on the account.\n");
                        }
                        break;

                    case CommandDollarsConvertToEuro:
                        Console.Write("What amount dollars do you want to exchange?: ");
                        exchangeCurrencyNumber = Convert.ToSingle(Console.ReadLine());

                        if (numberDollars >= exchangeCurrencyNumber)
                        {
                            numberDollars -= exchangeCurrencyNumber;
                            numberEuro += exchangeCurrencyNumber * dollarsConvertToEuro;
                        }
                        else
                        {
                            Console.WriteLine("not enough dollars on the account.\n");
                        }
                        break;

                    case CommandEuroConvertToRubles:
                        Console.Write("What amount euro do you want to exchange?: ");
                        exchangeCurrencyNumber = Convert.ToSingle(Console.ReadLine());

                        if (numberEuro >= exchangeCurrencyNumber)
                        {
                            numberEuro -= exchangeCurrencyNumber;
                            numberRubles += exchangeCurrencyNumber * euroConvertToRubles;
                        }
                        else
                        {
                            Console.WriteLine("not enough euro on the account.\n");
                        }
                        break;

                    case CommandEuroConvertToDollars:
                        Console.Write("What amount euro do you want to exchange?: ");
                        exchangeCurrencyNumber = Convert.ToSingle(Console.ReadLine());

                        if (numberEuro >= exchangeCurrencyNumber)
                        {
                            numberEuro -= exchangeCurrencyNumber;
                            numberDollars += exchangeCurrencyNumber * euroConvertToDollars;
                        }
                        else
                        {
                            Console.WriteLine("not enough euro on the account.\n");
                        }
                        break;

                    case CommandExit:
                        isRunning = false;
                        Console.WriteLine("Cood bye!");
                        break;

                    default:
                        Console.WriteLine("The command does not exist. Try again.\n");
                        break;
                }
            }
        }
    }
}
