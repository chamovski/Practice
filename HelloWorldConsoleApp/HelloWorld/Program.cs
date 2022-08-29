using HelloWorld.NamespaceEx;
using System;

int myNumber = 20;
string myName = "Ivan";
bool myBool = false;
DateTime myDateTime = DateTime.Now;
object myObject = new { name = "Ivan", age = 21, code = true };
double[] myArray = new double[] { 3.2, 2.66, 10.5 };
List<double> myArray2 = new List<double>() { 3.2, 2.66, 10.5 };

Console.WriteLine("myNumber: " + myNumber);
Console.WriteLine("myName: " + myName);
Console.WriteLine("myBool: " + myBool);
Console.WriteLine("myDateTime: " + myDateTime);
Console.WriteLine("myObject: " + myObject);

foreach (double numbers in myArray)
{
    Console.WriteLine("numbers: " + numbers);
}

foreach (double numbers in myArray2)
{
    Console.WriteLine("numbers: " + numbers);
}
Class1.MyName = "Ivan";
Class1.myMethod();



int userNumber;
Console.WriteLine("Enter a number from 1 to 100 :");
userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userNumber.GetType());