public class Circle :Shape
{
    protected double _radius = 1.0;
    public Circle(){}
    public Circle(double radius)
    {
      _radius = radius;
    }
    public Circle(double radius,string color,Boolean filled)
    {
      _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetArea()
    {
        return Math.PI*_radius*_radius;
    }
    public double GetPerimeter()
    {
        return 2*Math.PI*_radius;
    }
    public string ToString()
    {
        return $"Circle [{Shape.Equals} [{_color} , {_filled}] , {_radius} ]";
    }
    
}