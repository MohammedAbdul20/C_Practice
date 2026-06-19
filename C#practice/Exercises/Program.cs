Console.WriteLine("What kind of thing are we talking about?");
string? a = Console.ReadLine();//Stores a thing 
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string? b = Console.ReadLine();//Stores a Adjective 
/* this variable here adn below it stores words like doom and 3000*/
string c = "Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");