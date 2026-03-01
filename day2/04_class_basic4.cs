using static System.Console;

// 핵심. new 이야기

// primitive type[원시 타입] : 언어가 제공, 자동으로 컴파일러가 인식
// user define type[타입 선언] : class(Struct) 등의 문법으로 만들어진 타입

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
        // new에 대해
        // 사실, C#의 모든 변수는 new로 만들어야 한다!!!!
        int n1 = new int();
        double d1=new double();
        Rect r1 = new Rect();


        // 하지만, 기본 타입들은 변수 생성시에 new를 생략할 수 있도록 편의를 제공하는 것! (C/C++과의 통일성을 위해)
        //      "primitive type에게 제공되는 단축표기법"
        // 기본형은 new로 선언을 해도 stack에 value가 저장됨  (heap 사용 안함)
        int n2 = 0;
        double d2 = 3.4;
    }
}