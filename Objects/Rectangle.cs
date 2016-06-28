namespace RectangleCheck
{
  public class Rectangle
  {
    private int _length;
    private int _width;
    public Rectangle(int Length, int Width)
    {
      _length = Length;
      _width = Width;
    }
    public int GetLength()
    {
      return _length;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
    public int GetWidth()
    {
      return _width;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }
    public int GetArea()
    {
      return _length * _width;
    }
    public bool IsSquare()
    {
      if (_length == _width)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
