// C# Tutorial
/*
Console.WriteLine("Enter side A: ");
double sideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter side B: ");
double sideB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("The hypotenuse is: " + Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2)));
*/

/* String Manipulation in C#
String fullName = "Thanh Tung";
String phoneNumber = "0123-456-789";
FullName = FullName.ToUpper();
FullName = FullName.ToLower();
Console.WriteLine(fullName);

phoneNumber = phoneNumber.Replace("-", "/");
Console.WriteLine(phoneNumber);

String userName = fullName.Insert(0, "Mr. ");
Console.WriteLine(userName);

int len = fullName.Length;
Console.WriteLine("Length of fullName: " + len);

String firstName = fullName.Substring(0, 5);
String lastName = fullName.Substring(6);
Console.WriteLine("First Name: " + firstName);
Console.WriteLine("Last Name: " + lastName);
*/

/* If...Else Statement in C#
//Console.WriteLine("Enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());
//if (age < 18)
//{
//    Console.WriteLine(age + " is underage.");
//}
//else if (age >= 18 && age < 60)
//{
//    Console.WriteLine(age + " is an adult.");
//} else
//{
//    Console.WriteLine(age + " is a senior.");
//}
*/

//Random random = new Random();
//int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100

/* Array in C# 
String[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}
cars[4] = "Toyota"; // This line will cause an error because the array size is fixed.
*/

/* Methods in C# 
static void Greet(String name)
{
    Console.WriteLine("Hello, " + name + "!");
}

String? userName = Console.ReadLine();
if (userName != null)
{
    Greet(userName);
}   
*/

/* 
class Calculator
double sumTwo = Calculator.Add(2, 3);
double sumThree = Calculator.Add(1, 2, 3);
Console.WriteLine($"Sum of 2 and 3: {sumTwo}");
Console.WriteLine($"Sum of 1, 2, and 3: {sumThree}");
{
    static public double Add(double a, double b)
    {
        return a + b;
    }

    static public double Add(double a, double b, double c)
    {
        return a + b + c;
    }
}

static double Add(params double[] numbers)
{
    double sum = 0;
    foreach (double num in numbers)
    {
        sum += num;
    }
    return sum;
}
*/

/* Exception Handler 
try
{
    Console.WriteLine("Enter a number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another number: ");
    int denom = Convert.ToInt32(Console.ReadLine());
    int result = num / denom;
    Console.WriteLine("Result: " + result);
} catch (FormatException e)
{
    Console.WriteLine("Input is not a valid number. " + e.Message);
} catch (DivideByZeroException e)
{
    Console.WriteLine("Cannot divide by zero. " + e.Message);
} catch (Exception e)
{
    Console.WriteLine("An error occurred: " + e.Message);
}
*/

/* Conditional Operator 
int age = 20;
bool isAdult = (age >= 18) ? true : false;
string greet = $"Hello {(age >= 18 ? "Adult" : "Minor")}";
*/

/* Multi-dimensional Arrays 
int[,] map = { { 1, 2, 3 }, { 4, 5, 6 } };
*/

/* Class 
using MyFirstC_Program;
Messages.Hello();
*/

Human h1 = new("Alice", 16);
Human h2 = new("John", 16);
h1.Eat();
h2.Sleep();
Console.WriteLine("Population: " + Human.population);

Console.ReadKey();

/* Objects */
class Human
{
    public Human () {         
        name = "Unknown";
        age = 0;
        population++;
    }
    public Human (String name, int age)
    {
        this.name = name;
        this.age = age;
        population++;
    }

    public String name;
    public int age;
    public static int population = 0;

    public void Eat()
    {
        Console.WriteLine(name + " is eating.");
    }

    public void Sleep ()
    {
        Console.WriteLine(name + " is sleeping.");
    }
}




