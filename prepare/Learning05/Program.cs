using System;


class Program
{
    static void Main(string[] args)
    {    
        // Create a list of List of Shapes.
        List<Shape> shapes = new List<Shape> ();

        // Create different shapes and add them to the list.
        
        // Create an instance,call the getColor() and getArea()) method and return 
        // the value you want.
         Square s1 = new Square("Red", 3);
        shapes.Add(s1);
        

        Rectangle s2 = new Rectangle ("Blue", 3,2);
        shapes.Add(s2);

        Circle s3 = new Circle("Black",8 );
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
        
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }    
    }
}