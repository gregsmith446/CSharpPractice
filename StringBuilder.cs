using System;
using System.Text;

namespace cSharp_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder buildAString = new StringBuilder("Hellllllooooo World!!!");
            Console.WriteLine(buildAString);
        }
    }
}

// 1 Append()/AppendLine()

// Use Append method of StringBuilder to add or append a string to StringBuilder. 
// AppendLine() method appends the string with a newline at the end.

// StringBuilder sb = new StringBuilder("Hello ",50);

// sb.Append("World!!");
// sb.AppendLine("Hello C#!");
// sb.AppendLine("This is now a new line.");

// Console.WriteLine(sb);

// OUTPUT
// Hello World!! Hello C#!.
// This is new line.

// 2 AppendFormat()
// Use AppendFormat method to format input string into specified format and then append it.

// StringBuilder amountMsg = new StringBuilder("Your total amount is ");
// amountMsg.AppendFormat("{0:C} ", 25);

// Console.WriteLine(amountMsg);

// OUTPUT
// Your total amount is $ 25.00

// 3 Insert()
// The Insert() method inserts the string at specified index in StringBuilder.

// StringBuilder sb = new StringBuilder("Hello World!!",50);
// sb.Insert(5," C#");

// Console.WriteLine(sb);

// OUTPUT
// Hello C# World!!

// 4 Remove()
// The Remove() method removes the string at specified index with specified length.

// StringBuilder sb = new StringBuilder("Hello World!!",50);
// sb.Remove(6, 7);

// Console.WriteLine(sb);

// OUTPUT
// Hello

// 5 Replace()
// The Replace() method replaces all occurance of a specified string with a specified replacement string.

// StringBuilder sb = new StringBuilder("Hello World!!",50);
// sb.Replace("World", "C#");

// Console.WriteLine(sb);

// OUTPUT
// Hello C#!!

// 6 ToString()
// Use ToString() method to get string from StringBuilder.

// StringBuilder sb = new StringBuilder("Hello World!!");

// string str = sb.ToString(); 

// OUTPUT "Hello World!!"

// Points to Remember :
// StringBuilder is mutable.
// StringBuilder performs faster than string when appending multiple string values.
// Initialize StringBuilder as class e.g. StringBuilder sb = new StringBuilder()
// Use StringBuilder when you need to append more than three or four strings.
// Use Append() method to add or append strings with StringBuilder.
// Use ToString() method to get the string from StringBuilder.