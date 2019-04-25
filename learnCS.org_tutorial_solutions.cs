// Welcome to the Interactive C# Tutorial.
// Start by choosing a chapter and write your code in this window.

using System;
using System.Collections.Generic;

// Printing lines
public class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("I want to learn more than just the framework");
        Console.WriteLine("I want to be able to understand C# as well as I understand Python!");
    }
}

// String concatenation 
public class StringConcatenation
{
   public static void Main()
   {
    	string productName = "TV";
    	int productYear = 2012;
    	float productPrice = 279.99f;

        // test code
    	Console.WriteLine("productName: " + productName);
    	Console.WriteLine("productYear: " + productYear);
    	Console.WriteLine("productPrice: " + productPrice);

   }

   public static void Main()
   {
   		// New comment
   		string firstName = "John";
   		string lastName = "Doe";
   		int age = 27;

   		string sentence = firstName + " " + lastName + " is " + age  + " years old.";

   		Console.WriteLine(firstName + " " + lastName + " is " + age  + " years old.");
   		Console.WriteLine(sentence);
   }
}

// Conditional operators
public class Conditionals
{
    public static void Main()
    {
        int guess = 500;
        
        if (guess == 500)
        {
            Console.WriteLine("Success!")
        }
    }
}

// Arrays
public class Arrays
{
   public static void Main()
   {
      string[] fruits = {"apple", "banana", "orange"};

      // test code
      Console.WriteLine(fruits[0]);
      Console.WriteLine(fruits[1]);
      Console.WriteLine(fruits[2]);
   }
}

// Lists add one item at a time
public class Lists
{
	public static void Main()
	{
	  List<int> primeNumbers = new List<int>();
	  primeNumbers.Add(2);
	  primeNumbers.Add(3);
	  primeNumbers.Add(5);
	  primeNumbers.Add(7);
	  primeNumbers.Add(11);

	  Console.WriteLine(primeNumbers.Count);
	  //Console.WriteLine(primeNumbers);
	  Console.WriteLine(primeNumbers[0]);
	  Console.WriteLine(primeNumbers[1]);
      Console.WriteLine(primeNumbers[2]);
      Console.WriteLine(primeNumbers[3]);
      Console.WriteLine(primeNumbers[4]);
	}
}

// Lists add multiple items from existing list
public class ListsMultiple
{
	public static void Main()
	{
	  List<int> primeNumbers = new List<int>();
	  int[] prefilledPrimes = new int[] {2, 3, 5, 7, 11}

	  primeNumbers.AddRange(prefilledPrimes);

	  Console.WriteLine(primeNumbers.Count);
	  //Console.WriteLine(primeNumbers);
	  Console.WriteLine(primeNumbers[0]);
	  Console.WriteLine(primeNumbers[1]);
      Console.WriteLine(primeNumbers[2]);
      Console.WriteLine(primeNumbers[3]);
      Console.WriteLine(primeNumbers[4]);
	}
}
// Dictionaries
public class Dicctionaries
{
	public static void Main()
	{
		Dictionary<string, int> inventory = new Dictionary<string, int>();
		
		// Main method for adding to a dictionary
		inventory.Add("apple", 3);
		inventory.Add("banana", 2);
		
		// Other way of creating entries in a dictionary
		inventory["orange"] = 5;

		Console.WriteLine(inventory["apple"]);
        Console.WriteLine(inventory["orange"]);
        Console.WriteLine(inventory["banana"]);
	}
}

// For Loops
public class ForLoops
{
	public static void Main()
	{
		string x = "Hi";
        int n = 10;

        for (int i = 0; i < n; i++)
        {
        	Console.WriteLine(x);
        }
	}
}

// While Loops
public class WhileLoops
{
	public static void Main()
	{
		string x = "Hi";
        int n = 10;

        while (n > 5)
        {
        	Console.WriteLine(x);
        	n--;
        }
	}
}

// Methods
public class Methods
{
    public static void Main()
    {

        int x = 2;
        int y = 2;
        int a = Divide(x,y);
        Console.WriteLine(a);

    }

    public static int Divide(int x, int y)
    {
    	return x / y;
    }

}

// Basic Classes
class myClass
{
	public string test = "This works!";
	public string check = "I double checked it does in fact work!";
}

class mySecondClass
{
	public string add = "Multiple classes! HA HA!";
}
    

class MainClass
{
  public static void Main(){
    myClass myObject = new myClass();

    mySecondClass mySecondObject = new mySecondClass();

    Console.WriteLine(myObject.test);
    Console.WriteLine(mySecondObject.add);
    Console.WriteLine(myObject.check);
  }
}

// Car as an example for classes
public class newCar
{
	public int numTyres = 4;
	public int year = 2000;
	public bool runs = true;
}

public class MyPersonalCars
{
	public static void Main()
	{
		newCar car1 = new newCar();
		newCar car2 = new newCar();
		newCar car3 = new newCar();

		Console.WriteLine(car1.numTyres);
        Console.WriteLine(car2.year);
        Console.WriteLine(car3.runs);
	}
}

// Classes with different properties using constructors
class Vehicle
{
	public string modeOfTransport;
	public int numTyres;
	public int year;
	public bool runs;
	public Vehicle(string MofT, int NumTyres, int Year, bool Runs)
	{
		modeOfTransport = MofT;
		numTyres = NumTyres;
		year = Year;
		runs = Runs;
	}

}

public class VehicleChoices
{
	public static void Main()
	{
		Vehicle car = new Vehicle("car", 4, 2000, true);
		Vehicle oldCar = new Vehicle("car", 4, 1980, false);
		Vehicle bike = new Vehicle("bike", 2, 2017, true);

		Console.WriteLine(car.modeOfTransport);
        Console.WriteLine(oldCar.runs);
        Console.WriteLine(bike.numTyres);
	}
}