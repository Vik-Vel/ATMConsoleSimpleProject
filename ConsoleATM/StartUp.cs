using System;

namespace ConsoleATM
{

    public class StartUp
    {
        public class CardHolder
        {
            public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
            {
                CardNum = cardNum;
                Pin = pin;
                FirstName = firstName;
                LastName = lastName;
                Balance = balance;

            }


            public string CardNum { get; set; }

            public int Pin { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public double Balance { get; set; }

            public static void Main(string[] args)
            {
                void PrintOptions()
                {
                    Console.WriteLine("Please choose from one of the following options..");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Show Balance");
                    Console.WriteLine("4. Exit");
                }

                void Deposit(CardHolder currentUser)
                {
                    Console.WriteLine("How much $$ would you like to deposit?");
                    double deposit = double.Parse(Console.ReadLine());
                    currentUser.Balance += deposit;
                     Console.WriteLine($"Thank you for your {deposit}. Your new balance is: {currentUser.Balance}");
                }

                void WithDraw(CardHolder currentUser)
                {
                    Console.WriteLine("How much $$ would you like to withdraw?");
                    double withdrawal = double.Parse(Console.ReadLine());
                    if (currentUser.Balance < withdrawal)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Insufficient balance: {currentUser.Balance}");
                    }
                    else
                    {
                        currentUser.Balance -= withdrawal;
                        Console.WriteLine($"Your balance now: {currentUser.Balance} {Environment.NewLine}You're good to go!  {Environment.NewLine}Thank you!" );

                    }

                }

                void Balance(CardHolder currentUser)
                {
                    Console.WriteLine($"Current balance: {currentUser.Balance}");
                }


                List<CardHolder> users = new List<CardHolder>();

                users.Add(new CardHolder("1234567891234567", 1245, "John", "Griffin", 150.31));
                users.Add(new CardHolder("1234567258234567", 1275, "Peter", "Gorge", 260.31));
                users.Add(new CardHolder("12345678912758567", 7245, "Ivan", "Ivanov", 190.31));
                users.Add(new CardHolder("1024567891234567", 3245, "Viky", "Bekam", 410.31));
                users.Add(new CardHolder("1234567891234412", 1045, "Ivo", "Velev", 1500.31));


                //Prompt user
                Console.WriteLine("Welcome to SimpleAtm");
                Console.WriteLine("Please insert your debit car: ");

                string debitCardNum = string.Empty;
                CardHolder currentUser;

                while (true)
                {
                    try
                    {
                        debitCardNum = Console.ReadLine();
                        currentUser = users.FirstOrDefault(a => a.CardNum == debitCardNum);
                        if (currentUser != null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Card not recognized.Please try again");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Card not recognized.Please try again");
                    }

                }

                Console.WriteLine("Please enter your pin: ");
                int userPin = 0;

                while (true)
                {
                    try
                    {
                        userPin = int.Parse(Console.ReadLine());
                        currentUser = users.FirstOrDefault(a => a.Pin == userPin);
                        if (currentUser != default)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect pin. Please try again.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect pin. Please try again.");
                    }

                }

                Console.WriteLine($"Welcome {currentUser.FirstName} :");
                int option = 0;
                do
                {
                    PrintOptions();
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }

                    catch
                    {
                    }

                    if (option == 1)
                    {
                        Deposit(currentUser);
                    }
                    else if (option == 2)
                    {
                        WithDraw(currentUser);
                    }
                    else if (option == 3)
                    {
                        Balance(currentUser);
                    }
                    else if (option == 4)
                    {
                        break;
                        ;
                    }
                    else
                    {
                        option = 0;
                    }
                } while (option != 4);

                Console.WriteLine("Thank you! Have a nice day :");
            }

        }
    }
}

