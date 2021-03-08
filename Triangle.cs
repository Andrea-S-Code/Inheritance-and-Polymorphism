using System;
using System.Collections.Generic;
using System.Text;


// Triangle is derived from Shape.  
//Drived class or Child class.  
class Triangle : Shape
{
    public Triangle() { }
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

    public void DisplayAngles()
    {
        Console.WriteLine("Angles of the triangle is " + Style);
        float CalculateArea1 = Triangle.CalculateArea((int)Height, (int)Width, (int)side3);
        Console.WriteLine(CalculateArea1);

    }

    public static float CalculateArea(int Height, int Width, int side3)
    {
        float alpha = (float)Math.Acos((Width + side3 - Height) / (2 * Width * side3));
        float betta = (float)Math.Acos((Height + side3 - Width) / (2 * Height * Width));
        float gamma = (float)Math.Acos((Height + Width - side3) / (2 * Height * Width));

        alpha = (float)(alpha * 180 / Math.PI); 
        betta = (float)(betta * 180 / Math.PI);
        gamma = (float)(gamma * 180 / Math.PI);

        Console.WriteLine("Angles of the triangle are: " + alpha + " " + betta + " " + gamma);

        return alpha;
        

    }

    
}

