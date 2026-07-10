//Console.WriteLine("Welcome to the estate calcuator");

//Console.WriteLine("Enter the no of estates");
//int estate = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the no of Duchy");
//int duchy = Convert.ToInt32(Console.ReadLine());

//duchy *= 3;

//Console.WriteLine("Enter the no of Provinces");
//int provinces = Convert.ToInt32(Console.ReadLine());

//provinces *= 6;

//int totalAssets = estate +  duchy + provinces;

//Console.WriteLine("Total assets val: "+ totalAssets);

//Console.Beep();
//Console.WriteLine("\"");
//Console.Title = "Something";

//int age = 23;
//Console.WriteLine($"My age is {age}.");
//Console.WriteLine(@"C:/Users/mohd.a/C#");

//Console.Title = "Defense of Consolas";
//Console.Write("Target Row? ");
//int row = Convert.ToInt32(Console.ReadLine());

//Console.Write("Target Column? ");
//int column = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Deploy to:");
//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("(" + row + ", " + --column + ")");
//Console.WriteLine("(" + --row + ", " + ++column + ")");
//Console.WriteLine("(" + ++row + ", " + ++column + ")");
//Console.WriteLine("(" + ++row + ", " + --column + ")");
//Console.Beep();

//Console.Write("Enter the number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if(number % 2  == 0)
//{
//    Console.WriteLine("Tick");
//}
//else
//{
//    Console.WriteLine("Tock");
//}

//Watch Tower prog
//Console.Write("Enter the x value: ");
//int xCoordinate = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter the y value: ");
//int yCoordinate = Convert.ToInt32(Console.ReadLine());

//if(xCoordinate == 0 && yCoordinate == 0)
//{
//    Console.WriteLine("The enemy is here");
//}
//else if(xCoordinate < 0 && yCoordinate > 0)
//{
//    Console.WriteLine("The enemy is coming from NorthWest");
//}
//else if (xCoordinate == 0 && yCoordinate > 0)
//{
//    Console.WriteLine("The enemy is coming from North");
//}
//else if (xCoordinate > 0 && yCoordinate > 0)
//{
//    Console.WriteLine("The enemy is coming from NorthEast");
//}
//else if (xCoordinate < 0 && yCoordinate == 0)
//{
//    Console.WriteLine("The enemy is coming from West");
//}
//else if (xCoordinate > 0 && yCoordinate == 0)
//{
//    Console.WriteLine("The enemy is coming from East");
//}
//else if (xCoordinate < 0 && yCoordinate < 0)
//{
//    Console.WriteLine("The enemy is coming from SouthWest");
//}
//else if (xCoordinate == 0 && yCoordinate < 0)
//{
//    Console.WriteLine("The enemy is coming from South");
//}
//else if (xCoordinate > 0 && yCoordinate < 0)
//{
//    Console.WriteLine("The enemy is coming from SouthEast");
//}

//Console.WriteLine("WELCOME TO THE STORE");
//Console.Write("What's your Name? ");
//string? Name = Console.ReadLine();
//Console.WriteLine($"Hi {Name}, The following items are available today: " +
//    "\r\n1 – Rope " +
//    "\r\n2 – Torches " +
//    "\r\n3 – Climbing Equipment " +
//    "\r\n4 – Clean Water " +
//    "\r\n5 – Machete " +
//    "\r\n6 – Canoe " +
//    "\r\n7 – Food Supplies ");
//Console.Write("What number do you want to see the price of? ");
//int itemNumber = Convert.ToInt32(Console.ReadLine());

//string response;
//if(Name == "Habib")
//{
//    response = itemNumber switch
//    {
//        1 => "Only for you the Rope cost 5 gold",
//        2 => "Only for you the Torches cost 7.5 gold",
//        3 => "Only for you the Climbing Equiment cost 12.5 gold",
//        4 => "Only for yout the Clean Water Cost 0.5 gold",
//        5 => "Only for you the Machete cost 10 gold",
//        6 => "Only for you the Canoe cost 100 gold",
//        7 => "Only for you the Food Supplies cost 0.5 gold",
//        _ => "Hey, Choose a valid item"
//    };
//}

//else
//{
//    response = itemNumber switch
//    {
//        1 => "The Rope cost 10 gold",
//        2 => "The Torches cost 15 gold",
//        3 => "Climbing Equiment cost 25 gold",
//        4 => "Clean Water Cost 1 gold",
//        5 => "Machete cost 20 gold",
//        6 => "Canoe cost 200 gold",
//        7 => "Food Supplies cost 1 gold",
//        _ => "Hey, Choose a valid item"
//    };
//}

//Console.WriteLine(response);

//Console.WriteLine("WELCOME TO THE STORE");
//Console.Write("What's your Name? ");
//string? Name = Console.ReadLine();
//Console.WriteLine($"Hi {Name}, The following items are available today: " +
//    "\r\n1 – Rope " +
//    "\r\n2 – Torches " +
//    "\r\n3 – Climbing Equipment " +
//    "\r\n4 – Clean Water " +
//    "\r\n5 – Machete " +
//    "\r\n6 – Canoe " +
//    "\r\n7 – Food Supplies ");
//Console.Write("What number do you want to see the price of? ");
//int itemNumber = Convert.ToInt32(Console.ReadLine());

//string item = itemNumber switch
//{
//    1 => "Rope",
//    2 => "Torches",
//    3 => "Climbing Equipment",
//    4 => "Clean Water",
//    5 => "Machete",
//    6 => "Canoe",
//    7 => "Food Supplies",
//    _ => "Enter a valid product Number"
//};

//int price = item switch
//{
//    "Rope" => 10,
//    "Torches" => 16,
//    "Climbing Equipment" => 26,
//    "Clean Water" => 2,
//    "Machete" => 20,
//    "Canoe" => 200,
//    "Food Supplies" => 2,
//    _ => 0
//};

//if (Name == "Habib") price /= 2;

//Console.WriteLine($"The {item} cost {price} gold");

//int playersNumber = -1;
//while (playersNumber < 0 || playersNumber > 10)
//{
//    Console.Write("Enter a number between 0 and 10: ");
//    string? playerResponse = Console.ReadLine();
//    playersNumber = Convert.ToInt32(playerResponse);
//}

//for (int a = 1; a <= 10; a++)
//    for (int b = 1; b <= 10; b++)
//        Console.WriteLine($"{a} * {b} = {a * b}");

//int noOfRows = 5;
//int noOfCols = 5;

//for (int i = 1; i <= noOfRows; i++)
//{
//    for (int j = 1; j <= noOfCols; j++)
//    {
//        Console.Write('*');
//    }
//    Console.WriteLine();
//}

//int totalRows = 5;
//int totalColumns = 10;
//for (int currentRow = 1; currentRow <= totalRows; currentRow++)
//{
//    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
//        Console.Write("*");
//    Console.WriteLine();
//}

//Console.Write("User 1 enter a number between 0 and 100: ");

//int number;
//do
//{
//    Console.Write("User 1, Enter a between 0 and 100 please: ");
//    number = Convert.ToInt32(Console.ReadLine());

//} while (number < 0 || number > 100);

//while (true)
//{
//    Console.Write("User 2 guess the number: ");
//    int guessnum = Convert.ToInt32(Console.ReadLine());

//    if (guessnum > number)
//    {
//        Console.WriteLine("The number is too high");
//        continue;
//    }

//    else if (guessnum < number)
//    {
//        Console.WriteLine("The number is too low");
//        continue;
//    }

//    else
//    {
//        Console.WriteLine("That's the correct no, yay");
//        break;
//    }

//}

//int number;
//do
//{
//    Console.Write("User 1, enter a number between 0 and 100: ");
//    number = Convert.ToInt32(Console.ReadLine());
//}
//while (number < 0 || number > 100);

//Console.Clear();

//Console.WriteLine("User 2, guess the number.");

//while (true)
//{
//    Console.Write("What is your next guess? ");
//    int guess = Convert.ToInt32(Console.ReadLine());

//    if (guess > number) Console.WriteLine($"{guess} is too high.");
//    else if (guess < number) Console.WriteLine($"{guess} is too low.");
//    else break;
//}

//Console.WriteLine("You guessed the number!");


for(int i =1; i<101; i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}: Blue");
    }

    else if(i %3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Red");
    }
    
    else if(i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i}: Normal");
    }
}