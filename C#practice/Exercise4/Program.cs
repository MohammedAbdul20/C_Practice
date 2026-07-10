
////Area of the Triangle Program.
//Console.WriteLine("Enter the base of the triangle: ");
//double Base = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the height of the Triangle: ");
//double Height = Convert.ToDouble(Console.ReadLine());

//double Area = (Base * Height) / 2;

//Console.WriteLine("The area of the triangle is: " +  Area);

//int a = 5;
//int b = 2;
//int result = a / b;
//Console.WriteLine(result);

Console.WriteLine("enter the no of chocolates: ");
int chocolates = Convert.ToInt32(Console.ReadLine());

int eachPersonChocoShare = chocolates / 4;
float chocolatesForPet = chocolates % 4;

Console.WriteLine("The chcolates for each person is: " + eachPersonChocoShare + " and choco for pet is: " + chocolatesForPet);