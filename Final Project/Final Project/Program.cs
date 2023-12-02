using System;

class Program
{
    static void Main()
    {
        ShowMenu();
    }

    static void ShowMenu()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("1 - Act 9 & 10");
        Console.WriteLine("2 - Act 11");
        Console.WriteLine("3 - Act 12");
        Console.WriteLine("4 - Act 13");
        Console.WriteLine("5 - Act 14 & 15");
        Console.WriteLine("6 - Act 16");
        Console.WriteLine("7 - Act 17");
        Console.WriteLine("8 - Act 18");
        Console.WriteLine("9 - Act 19");
        Console.WriteLine("10 - Act 20");
        Console.WriteLine("11 - Act 21");
        Console.WriteLine("12 - Act 22");
        Console.WriteLine("13 - Act 23");
        Console.WriteLine("14 - Act 24");
        Console.WriteLine("15 - Act 25");
        Console.WriteLine("16 - Act 26");
        Console.WriteLine("17 - Act 27");
        Console.WriteLine("18 - Act 28");
        Console.WriteLine("19 - Act 29");
        Console.WriteLine("20 - Act 30");
        Console.WriteLine("0 - Exit\n\n");

        Console.Write("Pick Choice:");
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        ProcessChoice(choice);
    }

    static void ProcessChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                Act9_10();
                break;
            case 2:
                Act11();
                break;
            case 3:
                Act12();
                break;
            case 4:
                Act13();
                break;
            case 5:
                Act14_15();
                break;
            case 6:
                Act16();
                break;
            case 7:
                Act17();
                break;
            case 8:
                Act18();
                break;
            case 9:
                Act19();
                break;
            case 10:
                Act20();
                break;
            case 11:
                Act21();
                break;
            case 12:
                Act22();
                break;
            case 13:
                Act23();
                break;
            case 14:
                Act24();
                break;
            case 15:
                Act25();
                break;
            case 16:
                Act26();
                break;
            case 17:
                Act27();
                break;
            case 18:
                Act28();
                break;
            case 19:
                Act29();
                break;
            case 20:
                Act30();
                break;


            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Re-Enter.");
                break;
        }

        ShowMenu();
    }

    static void Act9_10()
    {
        string name, Father, Gender, Birthdate, Mstatus, Religion, Qualification, Experience, Preaddress, Peraddress, MobileNum, Email, Date, Place;


        Console.WriteLine("******************************");
        Console.WriteLine("*       INFORMATION          *");
        Console.WriteLine("******************************");


        Console.WriteLine("Enter your name");
        name = Console.ReadLine();

        Console.WriteLine("Enter your Father's Name");
        Father = Console.ReadLine();

        Console.WriteLine("Gender");
        Gender = Console.ReadLine();

        Console.WriteLine("Martial Status");
        Mstatus = Console.ReadLine();

        Console.WriteLine("Religion");
        Religion = Console.ReadLine();

        Console.WriteLine("Qualification");
        Qualification = Console.ReadLine();

        Console.WriteLine("Experience");
        Experience = Console.ReadLine();

        Console.WriteLine("Present Address");
        Preaddress = Console.ReadLine();

        Console.WriteLine("Permanent Address");
        Preaddress = Console.ReadLine();

        Console.WriteLine("Mobile No");
        MobileNum = Console.ReadLine();

        Console.WriteLine("Email");
        Email = Console.ReadLine();

        Console.WriteLine("Date");
        Date = Console.ReadLine();

        Console.WriteLine("Place");
        Place = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("__________________");
        Console.WriteLine("     BIO-DATA     ");
        Console.WriteLine("__________________");



        Console.WriteLine("Name:                        " + name);
        Console.WriteLine("Father's Name:               " + Father);
        Console.WriteLine("Gender:                      " + Gender);
        Console.WriteLine("Martial Status:              " + Mstatus);
        Console.WriteLine("Religion:                    " + Religion);
        Console.WriteLine("Qualifications:              " + Qualification);
        Console.WriteLine("Experience:                  " + Experience);
        Console.WriteLine("Present Address:             " + Preaddress);
        Console.WriteLine("Permanent Address:           " + Preaddress);
        Console.WriteLine("Mobile No.:                  " + MobileNum);
        Console.WriteLine("Email ID:                    " + Email);
        Console.WriteLine("");
        Console.WriteLine("\tDECLARATION      ");
        Console.WriteLine("I hereby declare that the above information is true and correct to the best of my knowledge and belief.");
        Console.WriteLine("");
        Console.WriteLine("Date:                       " + Date);
        Console.WriteLine("Place:                      " + Place);

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();

    }
    static void Act11()
    {
        string Num1 = "";
        string Num2 = "";
        int Sum = 0;
        Console.Write("Enter the first number: ");
        Num1 = Console.ReadLine();
        Console.Write("Enter the Second number: ");
        Num2 = Console.ReadLine();
        Sum = int.Parse(Num1) + int.Parse(Num2);

        Console.Clear();
        
        Console.Write("The sum of " + Num1 + " and " + Num2 + " is: " );
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(Sum);

        Console.WriteLine("\n \n");



        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act12()
    {
        string Num1 = "";
        string Num2 = "";
        int Sum, Diff, Prod, Qoe = 0;



        Console.WriteLine("Enter the first number: ");
        Num1 = Console.ReadLine();
        Console.WriteLine("Enter the Second number: ");
        Num2 = Console.ReadLine();
        Sum = int.Parse(Num1) + int.Parse(Num2);
        Diff = int.Parse(Num1) - int.Parse(Num2);
        Prod = int.Parse(Num1) * int.Parse(Num2);
        Qoe = int.Parse(Num1) / int.Parse(Num2);


        Console.Clear();

        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        Console.WriteLine("Outcomes");
        Console.WriteLine("");
        Console.WriteLine("_________________________________________");
        Console.WriteLine("The sum of " + Num1 + " and " + Num2 + " is:            " + Sum);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("_________________________________________");
        Console.WriteLine("The difference of " + Num1 + " and " + Num2 + " is:     " + Diff);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("_________________________________________");
        Console.WriteLine("The product of " + Num1 + " and " + Num2 + " is:        " + Prod);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("_________________________________________");
        Console.WriteLine("The quotient of " + Num1 + " and " + Num2 + " is:       " + Qoe);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("_________________________________________");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act13()
    {
        string Amount = "";
        string Discount = "";
        string Money = "";
        string Change = "";
        double per, change, due;

        Console.Write("Enter Your Total Product Amount: ");
        Amount = Console.ReadLine();
        Console.Write("Enter Discount Rate: ");
        Discount = Console.ReadLine();
        Console.WriteLine("__________________________");
        per = (double.Parse(Discount) / 100) * double.Parse(Amount);
        Console.WriteLine("Total Discount: " + per);
        due = double.Parse(Amount) - per;
        Console.WriteLine("Amount Due " + due);
        Console.WriteLine("__________________________");
        Console.Write("Amount Tendered: ");
        Money = Console.ReadLine();
        Console.WriteLine("__________________________");
        change = double.Parse(Money) - (double.Parse(Amount) - per);
        Console.WriteLine("Your Change is: " + change);

        
        
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act14_15()
    {
        string Price1 = "";
        string Price2 = "";
        string Price3 = "";
        string QTY1 = "";
        string QTY2 = "";
        string QTY3 = "";
        string discount = "";
        string totaldiscount = "";
        string DueAmount = "";
        string Money = "";
        string change = "";
        double TotalAmount, TotalDiscount, AmountDue, totalchange;



        Console.WriteLine("Product #1");
        Console.Write("Enter Price: ");
        Price1 = Console.ReadLine();
        Console.Write("Enter QTY: ");
        QTY1 = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Product #2");
        Console.Write("Enter Price: ");
        Price2 = Console.ReadLine();
        Console.Write("Enter QTY: ");
        QTY2 = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Product #3");
        Console.Write("Enter Price: ");
        Price3 = Console.ReadLine();
        Console.Write("Enter QTY: ");
        QTY3 = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");




        TotalAmount = (double.Parse(Price1) * double.Parse(QTY1)) + (double.Parse(Price2) * double.Parse(QTY2)) + (double.Parse(Price3) * double.Parse(QTY3));
        Console.WriteLine("Total Amount: " + TotalAmount);

        Console.Write("Enter Discount Rate (%): ");
        discount = Console.ReadLine();

        Console.WriteLine("_______________________");
        TotalDiscount = (double.Parse(discount) / 100) * TotalAmount;
        Console.WriteLine("Total Discount: " + TotalDiscount);



        AmountDue = TotalAmount - TotalDiscount;
        Console.Write("Ammount Due (less discount) " + AmountDue);
        Console.WriteLine("");

        Console.WriteLine("_______________________");
        Console.Write("Amount Tendered: ");
        Money = Console.ReadLine();



        Console.WriteLine("_______________________");
        totalchange = double.Parse(Money) - (TotalAmount - TotalDiscount);
        Console.WriteLine("Your Change is: " + totalchange);

       

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act16()
    {
        string o1 = "";
        string o2 = "";
        double Option, celsius, fahrenheit;
        string UserInput = "";

        while (true)
        {

            Console.WriteLine("Enter [1] Celsius to Fahrenheit Conversion");
            Console.WriteLine("Enter [2] Fahrenheit to Celsius Conversion");
            Console.Write("Select Your Option: ");



            Option = double.Parse(Console.ReadLine());


            if (Option == 1)
            {
                Console.Write("Please enter degree Celsius : ");
                celsius = double.Parse(Console.ReadLine());

                fahrenheit = (9 * celsius / 5) + 32;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nThe " + celsius + " Celsius is equal to " + fahrenheit + " Fahrenheit\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Do you want to convert another?: ");
                UserInput = Console.ReadLine();

                if (UserInput.ToLower() == "yes")
                {

                    Console.WriteLine("");
                    Console.WriteLine("Proceeding ");
                    Console.Clear();


                }

                else if (UserInput.ToLower() == "no")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Exiting");
                    Console.Clear();
                    break;

                }

                else
                {
                    Console.WriteLine("Exiting");
                    Console.Clear();
                   
                }


            }
            else if (Option == 2)
            {
                Console.Write("Please enter degree Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine());


                celsius = 5 * (fahrenheit - 32) / 9;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nThe " + fahrenheit + " fahrenheit is equal to " + celsius + " Celsius\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Do you want to convert another?: ");
                UserInput = Console.ReadLine();

                if (UserInput.ToLower() == "yes")
                {

                    Console.WriteLine("");
                    Console.WriteLine("Select Your Option: ");

                }

                else if (UserInput.ToLower() == "no")
                {
                    Console.WriteLine("Exiting");
                    Console.Clear();
                    break;
                }


            }


            else

                Console.WriteLine("Invalid");
                Console.Clear();
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();

    }
    static void Act17()
    {
        int grade = 0;

        Console.Write("Please enter your grade: ");
        grade = int.Parse(Console.ReadLine());

        if (grade > 60)
        {
            Console.WriteLine("Congrats! " + "You Passed!\n\n");
            
        }
        Console.WriteLine("Press Any Key To Continue:");

        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act18()
    {
        int grade = 0;

        Console.Write("Please enter your grade: ");
        grade = int.Parse(Console.ReadLine());

        if (grade > 60)
        {
            Console.WriteLine("Congrats! " + "You Passed!\n\n");
        }
        else
        {
            Console.WriteLine("You Failed!\n\n");
        }
        Console.WriteLine("Press Any Key To Continue:");

        Console.ReadLine();
        Console.Clear();

       
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();

    }
    static void Act19()
    {
        string order1 = "";
        string order2 = "";
        double percentage, amount = 0;


        Console.Write("Please enter amount of 1st order: ");
        order1 = Console.ReadLine();

        Console.Write("Please enter amount of 2nd order: ");
        order2 = Console.ReadLine();

        amount = (double.Parse(order1) + double.Parse(order2));

        if (amount <= 500)
        {

            percentage = amount * 0.05;
            Console.WriteLine("The 5% of " + amount + " is: " + percentage);
        }

        else
        {
            percentage = amount * 0.15;
            Console.WriteLine("The 15% of " + amount + " is: " + percentage);
        }
        

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act20()
    {
        string o1 = "";
        string o2 = "";
        double Option, celsius, fahrenheit;
        string UserInput = "";

        while (true)
        {

            Console.WriteLine("Enter [1] Celsius to Fahrenheit Conversion");
            Console.WriteLine("Enter [2] Fahrenheit to Celsius Conversion");
            Console.Write("Select Your Option: ");
            Option = double.Parse(Console.ReadLine());
            Console.Clear();


            if (Option == 1)
            {
                Console.Write("Please enter degree Celsius : ");
                celsius = double.Parse(Console.ReadLine());

                fahrenheit = (9 * celsius / 5) + 32;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("The " + celsius + " Celsius is equal to " + fahrenheit + " Fahrenheit\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Do you want to convert another?: ");
                UserInput = Console.ReadLine();

                if (UserInput.ToLower() == "yes")
                {

                    Console.WriteLine("");
                    Console.WriteLine("Proceeding ");
                    Console.Clear();


                }

                else if (UserInput.ToLower() == "no")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Exiting");
                    break;

                }

                else
                {
                    Console.WriteLine("Exiting");
                }


            }
            else if (Option == 2)
            {
                Console.Write("Please enter degree Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine());


                celsius = 5 * (fahrenheit - 32) / 9;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The " + fahrenheit + " fahrenheit is equal to " + celsius + " Celsius\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Do you want to convert another?: ");
                UserInput = Console.ReadLine();

                if (UserInput.ToLower() == "yes")
                {

                    Console.WriteLine("");
                    Console.WriteLine("Select Your Option: ");
                    Console.Clear();

                }

                else if (UserInput.ToLower() == "no")
                {
                    Console.WriteLine("Exiting");
                    break;
                }


            }


            else

                Console.WriteLine("Invalid");

        }
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Press Any Key To Continue:");

        Console.ReadLine();
        Console.Clear();

       
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act21()
    {
        int Operation;
        double First, Second, Sum, Dif, Prod, Qoe;
        string input;

        do
        {
            Console.Clear();
            Console.WriteLine("Select An Operation \n [1] ADDITION \n [2] SUBTRACTION \n [3] MULTIPLICATION \n [4] DIVISION ");

            Console.Write("Your Option: ");
            Operation = int.Parse(Console.ReadLine());
            Console.Clear();

            if (Operation < 1 || Operation > 4)
            {
                Console.WriteLine("Invalid");
                return;
            }

            Console.Write("Enter First Number: ");
            First = double.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            Second = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            

            switch (Operation)
            {
                case 1:
                    
                    Console.WriteLine("ADDITION");
                    Sum = First + Second;
                    Console.WriteLine("The SUM of " + First + " and " + Second + " is " + Sum + "\n\n");
                    break;

                case 2:
                    Console.WriteLine("SUBTRACTION");
                    Dif = First - Second;
                    Console.WriteLine("The DIFFERENCE of " + First + " and " + Second + " is " + Dif + "\n\n");
                    break;

                case 3:
                    Console.WriteLine("PRODUCT");
                    Prod = First * Second;
                    Console.WriteLine("The PRODUCT of " + First + " and " + Second + " is " + Prod + "\n\n");
                    break;

                case 4:
                    if (Second == 0)
                    {
                        Console.WriteLine("QOETIENT");
                        Console.WriteLine("Error: Division by zero is not allowed." + "\n\n");
                    }
                    else
                    {
                        Console.WriteLine("QOETIENT");
                        Qoe = First / Second;
                        Console.WriteLine("The QOETIENT of " + First + " and " + Second + " is " + Qoe + "\n\n");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4." + "\n\n");
                    break;
            }

            Console.Write("Do you want to make another computation? (yes/no): ");
            input = Console.ReadLine().ToLower();
        } while (input.ToLower() == "yes");

        Console.WriteLine("\n \n Press Any Key To Continue:");

        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act22()
    {
        int Operation;
        double First, Second, Sum, Dif, Prod, Qoe;
        string input;


        do
        {
            Console.Clear();
            Console.WriteLine("Select An Operation \n [1] ADDITION \n [2] SUBTRACTION \n [3] MULTIPLICATION \n [4] DIVISION ");

            Console.Write("Your Option: ");
            Operation = int.Parse(Console.ReadLine());
            Console.Clear();

            if (Operation > 0 && Operation <= 4)
            {

                Console.Write("Enter First Number: ");
                First = double.Parse(Console.ReadLine());
                Console.Write("Enter Second Number: ");
                Second = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");


                if (Operation == 1)
                {
                    Sum = First + Second;
                    Console.WriteLine("The SUM of " + First + " and " + Second + " is " + Sum);
                }
                else if (Operation == 2)
                {
                    Dif = First - Second;
                    Console.WriteLine("The DIFFERENCE of " + First + " and " + Second + " is " + Dif);
                }
                else if (Operation == 3)
                {
                    Prod = First * Second;
                    Console.WriteLine("The PRODUCT of " + First + " and " + Second + " is " + Prod);
                }

                else if (Operation == 4)
                {
                    if (Second == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Qoe = First / Second;
                        Console.WriteLine("The QOETIENT of " + First + " and " + Second + " is " + Qoe);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.Write("Do you want to make another computation? (yes/no): ");
            input = Console.ReadLine().ToLower();
        } while (input == "yes");

        

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act23()
    {
        int first, second, third, Max;

        Console.Write("Enter First Number: ");
        first = int.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        second = int.Parse(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        third = int.Parse(Console.ReadLine());





        if (first > second && first > third)
        {
            Console.WriteLine("The highest value among " + first + " , " + second + " , " + third + " is: " + first);
        }

        else if (second > third && second > first)
        {
            Console.WriteLine("The highest value among " + first + " , " + second + " , " + third + " is: " + second);
        }

        else
        {
            Console.WriteLine("The highest value among " + first + " , " + second + " , " + third + " is: " + third);
        }
    

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act24()
    {
        double quiz1, midterm, final;
        double GWA, QT, TM, TF;

        Console.Write("Enter the score of the quiz: ");
        quiz1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Your Quiz is " + quiz1 + " / " + "100");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.Clear();



        Console.WriteLine("MIDTERM EXAM:");
        Console.Write("Enter the score of the midterm exam: ");
        midterm = int.Parse(Console.ReadLine());

        Console.WriteLine("Your Midterm Exam is " + midterm + " /" + "100");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.Clear();

        Console.Write("Enter the score of the final exam: ");
        final = int.Parse(Console.ReadLine());

        Console.WriteLine("Your Final Exam is " + final + " / " + "100");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.Clear();



        QT = (quiz1 / 100) * 100;
        Console.WriteLine("Total Quiz: " + QT);

        TM = (midterm / 100) * 100;
        Console.WriteLine("Total Midterm Exam: " + TM);

        TF = 100 * (final / 100);
        Console.WriteLine("Total Final Exam: " + TF);

        GWA = ((QT + TM + TF) / 3.0);
        Console.WriteLine("Your GWA is: " + GWA);

        Console.WriteLine();
        if (GWA >= 90)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You Got A!");
        }

        else if (GWA >= 70 && GWA < 90)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You Got B!");
        }

        else if (GWA >= 50 && GWA < 70)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You Got C!");
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You Got F!");
        }

        
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();

    }
    static void Act25()
    {
        Console.Write("Enter order 1: ");
        double order1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter order 2: ");
        double order2 = Convert.ToDouble(Console.ReadLine());

        double total = order1 + order2;

        if (total <= 500)
        {
            double discount = total * 0.05;
            Console.WriteLine("5% of your total: " + discount);
        }
        else
        {
            double discount = total * 0.15;
            Console.WriteLine("15% of your total : " + discount);
        }
      

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();

    }
    static void Act26()
    {
        int i = 1;
        int num = 0;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Please enter a number: ");
        num = int.Parse(Console.ReadLine());
        Console.Clear();
        while (i <= num)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(i.ToString() + " H");
            Thread.Sleep(100);
            Console.Write("e");
            Thread.Sleep(100);
            Console.Write("l");
            Thread.Sleep(100);
            Console.Write("l");
            Thread.Sleep(100);
            Console.Write("o");
            Thread.Sleep(100);
            Console.Write(" W");
            Thread.Sleep(100);
            Console.Write("o");
            Thread.Sleep(100);
            Console.Write("r");
            Thread.Sleep(100);
            Console.Write("l");
            Thread.Sleep(100);
            Console.Write("d");
            Thread.Sleep(100);

            Console.WriteLine("  ");
            Thread.Sleep(100);
            i++;

        }
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act27()
    {
        int i = 1;
        int num = 0;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Please enter a number: ");
        num = int.Parse(Console.ReadLine());
        Console.Clear();

        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(i.ToString() + " Hello World ");
            Thread.Sleep(250);
            i++;

        } while (i <= num);

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act28()
    {
        int num = 0;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Please enter a number: ");
        num = int.Parse(Console.ReadLine());
        Console.Clear();

        for (int i = 1; i <= num; i++)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(i.ToString() + " H");
            Thread.Sleep(100);
            Console.Write("e"); Thread.Sleep(150);
            Console.Write("l"); Thread.Sleep(150);
            Console.Write("l"); Thread.Sleep(150);
            Console.Write("o"); Thread.Sleep(150);
            Console.Write(" W"); Thread.Sleep(150);
            Console.Write("o"); Thread.Sleep(150);
            Console.Write("r"); Thread.Sleep(150);
            Console.Write("l"); Thread.Sleep(150);
            Console.Write("d"); Thread.Sleep(150);
            Console.WriteLine("  "); Thread.Sleep(100);

        }

        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act29()
    {
        int i = 1;
        int a = 1;
        int num = 0;

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter an Integer Number betwee 1 - 10: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("\n ");

        Console.ForegroundColor = ConsoleColor.White;
        for (i = 0; i <= num; i++)
        {
            for (a = 0; a <= i; a++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n \nThe Inverted Output \n \n ");

        Console.ForegroundColor = ConsoleColor.White;
        for (i = num; i >= 1; i--)
        {
            for (a = i; a >= 1; a--)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
    static void Act30()
    {
        Console.WriteLine("Please Enter The Size of the Matrix: ");
        string UserInput = Console.ReadLine();

        int num = int.Parse(UserInput);

        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + "\t");
        }

        Console.WriteLine("");

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= num; j++)
            {
                Console.Write((j * i) + "\t");
            }
            Console.WriteLine("");
        }
        Console.WriteLine("\n");
        Console.WriteLine("Press Any Key To Continue:");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Returning To Main Menu...");
        Thread.Sleep(200);
        Console.Write("L"); Thread.Sleep(250);
        Console.Write("o"); Thread.Sleep(250);
        Console.Write("a"); Thread.Sleep(250);
        Console.Write("d"); Thread.Sleep(250);
        Console.Write("i"); Thread.Sleep(250);
        Console.Write("n"); Thread.Sleep(250);
        Console.Write("g"); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.Write("."); Thread.Sleep(250);
        Console.WriteLine("");
        Thread.Sleep(150);
        Console.Clear();
    }
}

