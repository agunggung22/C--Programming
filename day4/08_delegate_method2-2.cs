using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public void IMethod(int arg) => WriteLine("IMethod");

    public void Foo() // 컴파일러 -> void Foo(Program this)
    {
        // 여기서 instance method 호출
        this.IMethod(1);  // 정확한 표기 "객체.인스턴스메소드()"
        IMethod(1);       // this 생략 가능

        // static method 는 타입이름으로 
        Program.SMethod(1);
        SMethod(1);
    }
    public static void Main()
    {
        // 자신의 static method 등록
        MyFunc f1 = Program.SMethod;
        MyFunc f2 = SMethod;

        // 인스턴스 메소드 등록은 마찬가지로, 객체가 필요함
        // MyFunc f3 = IMethod; // error

        // 현재 main 안에는 객체가 없으므로 객체를 만들어야함
        Program pg = new Program();
        MyFunc f3 = pg.IMethod;
    }

}