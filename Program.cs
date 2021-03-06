using Inheritance;
using System;

//https://www.c-sharpcorner.com/UploadFile/9582c9/inheritance-with-example-in-C-Sharp/​
//1. Take a few sentences to give an example of why you would use Inheritance. 
//Do the same for polymorphism. You can put these answers in the .cs file as comments.
// 1) Inheritance:You would use inheritance to create a general class that defines a common set for a general class. 
//This class can then be inherited by other, more specific classes, each adding those things that are unique to it.
//Polymorphism: used when you need to define one interface and have multiple implementations for it

class MainClass : Shape
{
    public static void Main(string[] args)
    {
        Triangle t1 = new Triangle();
        t1.Width = (int)8.0;
        t1.Height = (int)6.0;
        t1.side3 = (int)7.0;
        //Display triangle 1
        t1.GetArea();
        Console.WriteLine("Triangle is " + t1.CalculateArea((int)t1.Height, (int)t1.Width));
        Console.WriteLine("Triangle is " + t1.CalculateArea((int)t1.Height, (int)t1.Width), (int)t1.side3);
        t1.ShowDim();
        t1.ShowStyle();
        //Triangle Angles
        Console.WriteLine(t1.DisplayAngles((int)t1.Height, (int)t1.Width, (int)t1.side3));


        Circle c1 = new Circle();
        c1.Width = (int)2.0;
        c1.Height = (int)2.0;
        //Display Circle 1
        Console.WriteLine();
        c1.GetArea();
        Console.WriteLine("Circle area is " + c1.CalculateArea((int)c1.Height, (int)c1.Width));
        c1.ShowDim();

        Rectangle r1 = new Rectangle();
        r1.Width = (int)2.0;
        r1.Height = (int)2.0;
        //Display rectangle 1
        Console.WriteLine();
        r1.GetArea();
        Console.WriteLine("Area of a Rectangle is " + r1.CalculateArea((int)r1.Height, (int)c1.Width));
        r1.ShowDim();

    }

}
