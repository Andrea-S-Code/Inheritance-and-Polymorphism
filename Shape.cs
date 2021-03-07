using System;
using System.Collections.Generic;
using System.Text;

//Base class or Parent class.  
class Shape
{
    public Shape(int height, int width, int Area)
    {
        Height = height;
        Width = width;
        Area = (int)(Height * Width);
    }

    public Shape() { }
    public double Height;
    public double Width;


    public virtual void GetArea()
    {
        Console.WriteLine("Shape"); ;
    }


    public virtual void ShowDim()
    {
        Console.WriteLine("Width and height are " +
        Width + " and " + Height);

    }

    public virtual int CalculateArea(int Height, int Width)
    {
        return Height * Width;
    }

}