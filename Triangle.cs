using System;
using System.Collections.Generic;
using System.Text;


// Triangle is derived from Shape.  
//Drived class or Child class.  
class Triangle : Shape
{
    public string Style; // style of triangle  

    public int side3 { get; internal set; }

    // Return area of triangle.  
    public override int CalculateArea(int Height, int Width)
    {
        return Height * Width / 2;
    }

    // Display a triangle's style.  
    public void ShowStyle()
    {
        Console.WriteLine("Triangle is " + Style);
    }

    public static float CalculateArea(int Height, int Width, int side3)
    {
        return (Height + Width + side3) / 2;
    }

    public int DisplayAngles(int Height, int Width, int side3)

    {
        float a = (Height*Height);
        float b = (Width*Width);
        float c = (side3*side3);


        float alpha = (float)Math.Acos((((b + c - a) / (2 * Width * side3))));
        float betta = (float)Math.Acos(((a + c - b) / (2 * Height * side3)));
        float gamma = (float)Math.Acos(((a + b - c) / (2 * Height * Width)));

        alpha = (float)(alpha * 180 / Math.PI);
        betta = (float)(betta * 180 / Math.PI);
        gamma = (float)(gamma * 180 / Math.PI);

        Console.WriteLine("Angles of the triangle are: " + alpha + " " +betta + " " + gamma);

        return 000000000000000000000000000000; //This is here becuase it needed a return value (means nothing)
    }
    
    
}
