class Shape
{
    private int color = 0;

    public void SetColor(int c)
    {
        color = c;
    }   
}

class Rect : Shape
{
    public void Draw()
    {
        int c = color; // ?
    }
}

class Program 
{     
    public static void Main()
    {
        Shape s = new Shape();
        s.color = 10; // error
    }

}
