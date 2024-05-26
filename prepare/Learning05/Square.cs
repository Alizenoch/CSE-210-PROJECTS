    // This class inherits from the base class.  
    public class Square : Shape
    {
        private double _side;

      // Created a constructor that accepts the color and the side, and then call the base 
      // constructor with the color

        public Square(string color,double side) : base(color)
        {
            _side = side;
        }

        // Override the GetArea() from the base class and fill  in the body
        // of this function to return the area.

        public override double GetArea()
        {
            return _side * _side;
        }
   
    }



  