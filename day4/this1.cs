// this1.cs   추가
using static System.Console;

class Point
{
    // 필드는 heap 메모리에 각 객체마다 존재
    private int x = 0;
    private int y = 0;

    public Point(int a, int b) => (x, y) = (a, b);

    // 메소드는 code mem에 한개만 존재 => 호출한 객체를 어떻게 찾는걸까?
    // 사용자 코드                       // 컴파일 코드
    public void Set(int a, int b)
    {      // void Set(Point this, int a, int b)
        x = a;                          //{     this.x = a; this.y=b;    }
        y = b;
    }

    // 메소드에서 this는 메소드를 호출한 객체를 지칭 
    // C++, Java, C#: 사용자가 객체 인자를 받는 코드를 따로 만들지 않아도 됨
    //      컴파일러 담당
    // Python, swift, Rust : 사용자가 직접 객체 인자를 받는 코드를 만들여야함
    //      개발자 담당
    //      객체지향 언어로 쓰기 불편하지 않나..?
    //      ex) self
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        // 아래 코드의 정확한 원리는
        p1.Set(10, 20);     // Set(p1, 10, 20)
        p2.Set(10, 20);
    }
}