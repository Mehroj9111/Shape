namespace HomeWork11;
public abstract class Shape
{
    protected string _color = "red";
    protected Boolean _filled = true;
    public Shape(){}
    public Shape(string color,Boolean filled )
    {
        _color = color;
        _filled = filled;
    }
    public string GetColor()
    {
      return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public Boolean IsFilled()
    {
        return _filled;
    }
    public void SetFilled(Boolean filled)
    {
        _filled = filled;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public string ToString()
    {
        return $"Shape [{_color } , {_filled}]";
    }
}