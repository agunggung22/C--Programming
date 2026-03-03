using static System.Console;

// 핵심. 생성자 

class Rect
{
    public int left = 0;
    public int top = 0;
    public int rigth = 0;
    public int bottom = 0;


    public int GetArea()
    {
        return (right - left) * (bottom - top);
    }

    public Rect(int left, int top, int rigth, int bottom)
    {
        this.left = left;
        this.top = top;
        this.rigth = rigth;
        this.bottom = bottom;
    }

    public Rect(int left, int top, int rigth, int bottom)
        => (this.left, this.top, this.rigth, this.bottom) = (left, top, rigth, bottom);

    public Rect() => (left, top, rigth, bottom) = (0, 0, 0, 0);
}

class Program
{
    public static void Main()
    {
        // 용어 차이

        // 변수 variable : 변하는 수
        int n = 10;
        n = 20;

        // 객체(object): 상태를 가지고 행동을 할 수 있는 하나의 사물채
        Rect rc1 = new Rect(1, 1, 10, 10);

        // 물론, 변수는 객체라 할 수 있습니다. (변수 << 객체)
        
        // 관례적 차이
        // 변수는 언어 자체가 제공하는 타입들 (primitive type)
        // 객체는 사용자가 직접 선언한 타입들 (user define type, reference type)
        
        // Window w = new Window()에서 w는 Window 객체
    }
}