// 인스턴스 메소드(static 이 아닌 메소드)
// "객체.메소드이름()" 으로만 호출가능

// entry에서 컴파일러는 static void main 함수를 찾아다님
// 찾으면 그 함수를 실행
// "Program.Main()"

class Program
{
    private int color = 0;
    
    // 인스턴스 메소드의 실체는 F1(this, int a)임 
    public void F1(int a)
    {
        color = 10;
    }
    public void F2(int a) { 
        // 1. 인스턴스 메소드는 => 객체가 있어야 호출 가능함
        // 2. 인스턴스 메소드는 this 사용 가능
    }

    public static void Main()
    {
        // 아직 program 객체는 없음
        //      F1은 객체가 없으므로 호출 불가
        // F1을 호출하려면 객체를 먼저 만들어야함
        Program pg= new Program();
        pg.F1(1);
        pg.F2(0);    // 실제 컴파일러는 Fw(pg,0)으로 인식

        // 2. static 메소드는 객체가 없어도 호출 가능하며 객체가 필요 없음
        // 1. static 메소드는 this 사용 불가
    }
}