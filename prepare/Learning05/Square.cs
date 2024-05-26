using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public class Square : Shape 
{

    

    public Square (string color, double side) : base(color)
    {
        _side = side;
    }

    private double _side;

    public override double GetArea()
    {
       return _side * _side; 
    }


}