﻿// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

// Value types:
// derived from System.ValueType
// int (4 bytes) -2^31...2^31 - 1
// uint (4 bytes) 0...2^32 - 1
// short (2 bytes) -2^15...2^15 - 1
// ushort (2 bytes) 0...2^16 - 1
// long (8 bytes) -2^63...2^63 - 1
// ulong (8 bytes) 0...2^64 - 1
// bool (1 bytes) false...true
// char (2 bytes) 0...2^16 - 1
// byte (1 byte) 0..255
// sbyte (1 byte) -128...127
// float (System.Single) (single) (4 byte) 7-8 знаков после запятой
// double (System.Double) (8 byte) 14-15 знаков после запятой
// decimal (System.Decimal) (10 byte)
// enum
// struct
// record (50/50)

// Reference types:
// string
// class
// delegate/event
// interface

/// <summary>
/// Represents chess board field
/// </summary>
//struct ChessBoardField
//{
//    public int Horizontal;
//    public char Vertical;
//}

//ChessBoardField x;

//enum Profession
//{
//    Chief = 0,
//    SuChief = 1,
//    Povar = 3
//}

//string str = "1234";

//Profession.Chief

/*
flksdflksfd
*/

//int a = 10;
//object o = new object();

//2 == (sqrt(2))^2
//|a - b| < eps

// (-inf..-5]
// (-5..5)
// [5..+inf)

// IEquatable<T>, IEqualityComparer<T>

//           { -k, x < y
// (x, y) -> { 0, x == y
//           { +k, x > y
// IComparable, IComparable<T>, IComparer<T>

using DigitalCathedral;
// 
// int value = 11;
// 
// Console.Write("Input integer value: ");
// string readFromConsole = Console.ReadLine();
// if (!int.TryParse(readFromConsole, out value))
// {
//     Console.WriteLine("Invalid input!");
//     Environment.Exit(1);
// }
// Console.WriteLine(value);
// 
// // a AND b: 1 AND 1 = 1, otherwise 0
// // a OR b: 0 OR 0 = 0, otherwise 1
// 
// // "1234" -> 1234
// //if (value <= -5 && value % 2 == 1)
// //{
// //    Console.WriteLine("Value LT or EQ -5 AND value is odd");
// //}
// //else if (value <= -5 && value % 2 == 0)
// //{
// //    Console.WriteLine("Value LT or EQ -5 AND value is even");
// //}
// //else if (value < 5)
// //{
// //    Console.WriteLine("Value GT -5 and LT 5");
// //}
// //else
// //{
// //    Console.WriteLine("Value GT or EQ 5");
// //}
// 
// // condition
// //     ? 
// //     :
// 
// string toPrint = (value <= -5 && value % 2 == -1)
//     ? "Value LT or EQ -5 AND value is odd"
//     : (value <= -5 && value % 2 == 0)
//         ? "Value LT or EQ -5 AND value is even"
//         : value < 5
//             ? "Value GT -5 and LT 5"
//             : "Value GT or EQ 5";
// Console.WriteLine(toPrint);
// 
// switch (value)
// {
//     case 2:
//         Console.WriteLine("Value == 2");
//         break;
//     case 3:
//         Console.WriteLine("Value == 3");
//         break;
//     case 10:
//         Console.WriteLine("Wow! Value == 10!");
//         break;
//     case 100:
//         Console.WriteLine("OMG, value is 100!!!");
//         break;
//     default:
//         Console.WriteLine("Value is not in { 2, 3, 10, 100 }");
//         break;
// }
// 
// const int numbersCount = 10;
// 
// Console.Write("for: ");
// int i = 1;
// for (; i <= numbersCount; i++)
// {
//     if (i == 4)
//     {
//         continue;
//     }
// 
//     if (i == 9)
//     {
//         break;
//     }
//     
//     Console.Write(i);
//     Console.Write(" ");
// }
// 
// Console.WriteLine();
// Console.Write("while: ");
// i = 1;
// while (i <= numbersCount)
// {
//     Console.Write("{0} ", i++);
// }
// 
// Console.WriteLine();
// Console.Write("do/while: ");
// i = 1;
// do
// {
//     Console.Write("{0} ", i++);
// }
// while (i <= numbersCount);
// 
// Console.WriteLine();
// Console.Write("foreach: ");
// int[] values = new int[] { 10, 20, 30, 40, 50 };
// 
// foreach (int currentValue in values)
// {
//     Console.Write($"{currentValue} ");
// }

// T voice(duck*)
// {
//     
// }
// 
// void insert(list* l, int value)
// {
//     // TODO: ?!
// }

// list l = new list();
// l.insert(10);
// l.value1 = 20;
//Animal a = new Animal();
//Console.WriteLine(a.ToString());
//
//var str1 = "12345";
//Console.Write("Input string: ");
//var readStr = Console.ReadLine();
//var str2 = string.Intern("123" + readStr);
//
//Console.WriteLine(object.ReferenceEquals(str1, str2));

// Animal cat = new Dog();
// string voiceResult = cat.Voice();
// Console.WriteLine(voiceResult);
// Console.WriteLine();
// 
// const int animals_count = 6;
// Animal[] animals = new Animal[animals_count];
// for (int i = 0; i < animals_count; i++)
// {
//     animals[i] = i % 2 == 0
//         ? new Cat("Ponchik")
//         : new Dog();
// }
// 
// Animal a = new Cat("Busya");
// Console.WriteLine(a);
// 
// Console.WriteLine(animals[0]);
// 
// foreach (var animal in animals)
// {
//     Console.WriteLine(animal.Voice());
// }
// 
// Console.WriteLine();
// 
// // Animal animal1 = new Animal();
// // Animal animal2 = new Animal("123456");
// 
// // math.h abs abs

// var animal = new Animal(1, 123.45, "string");
// object animal2 = new Animal(1, 123.45, "string");
// Animal animal3 = null;
//
// Console.WriteLine(animal == animal2);
// Console.WriteLine(animal.Equals(animal2));

try
{
    Student st = new Student("Ivanov", "Ivan", "Ivanovich", "M1O-301B-21", "1234-123-12", 3);
    
    Console.WriteLine("No exceptions were thrown");
}
catch (ArgumentNullException ex)
{
    // 
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    // 
    Console.WriteLine(ex.Message);
}
Console.WriteLine("after try/catch...");

var fraction = new Fraction(2, 5);
var fraction2 = new Fraction(1, 7);
Console.WriteLine(fraction.Equals(fraction2));

var multiplicationResult = Fraction.Multiplication(fraction, fraction2);

Console.WriteLine(fraction.CompareTo(fraction2));