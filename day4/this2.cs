
using static System.Console;

// this 사용 1. 이름 충돌이 있을 때 현재 객체의 필드임을 나타내기 위해
// this 사용 2. this를 반환하면 method를 연속으로 호출 가능

class Point
{

    private int x = 0;
    private int y = 0;

    public Point(int a, int b) => (x, y) = (a, b);


    public void Set(int x, int y){      
        // 매개변수 이름이 필드와 겹칠 때 => 가까운 매개변수가 멀리있는 필드를 가림
        // 객체의 필드를 명시적으로 지칭할 필요가 있음
        //      객체의 멤버임을 바로 알 수 있어서 가독성 좋음
        this.x = x;                         
        this.y = y;
    }  
    public Point SetX(int x)
    {
        this.x = x;
        return this;
    }
    public Point SetY(int y)
    {
        this.y = y;
        return this;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);

        p1.Set(10, 20);     // Set(p1, 10, 20)

        // 연쇄 호출 기술에 사용가능
        // Java에서 매우 널리 사용됨
        // Java에서는 "빌더"라는 기술 
        p1.SetX(10).SetY(20).SetX(5);

        // 다른 언어에서는 "method chaining"
        // Rust에서도 널리 사용
    }
}