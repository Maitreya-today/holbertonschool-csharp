using System;

/// <summary>Class Shape</summary>
public class Shape
{
    /// <summary>Method Area() </summary>
    /// <returns>The area of the shape</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>Class Rectangle that inherits from Shape</summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>Property Width</summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            else
                width = value;
        }
    }
    /// <summary>Property Height</summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            else
                height = value;
        }
    }

}