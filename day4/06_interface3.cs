using static System.Console;

// 비교 연산자 >,<,==
class Camera
{
    public void Take() { WriteLine("take picture");  }
}

class Person
{
    public void UseCamera(Camera c) {  c.Take(); }
}

class Program
{
    public static void M1(IComparable ic) { }
    public static void Main()
    {
        int n1 = 10;
        int n2 = 20;

        string s1 = "AAA";
        string s2 = "BBB";

        // 1. 비교 연산자 사용은 숫자 타입만 가능, string 객체는 불가능함
        // 2. CompareTo 메소드 사용
        //      숫자 뿐만 아니라, string도 사용 가능
        //      크기 비교가 가능한 모든 타입에는 CompareTo가 있음
        int ret1 = n1.CompareTo(n2);  // n1>n2 =1 / n1<n2=-1 / n1==n2=0
        int ret2 = s1.CompareTo(s2);

        // int 타입의 CompareTo 메소드 이름과 String 타입의 CompareTo 메소드 이름이 같아야 사용하기 편함
        //      C#의 공통 메소드는 모두 인터페이스로 구현됨
        //      인터페이스는 특정 기능의 이름 통합만을 위해서 사용하기도 한다!!

        // IComparable 인터페이스를 사용하는 모든 타입의 객체를 전달 가능
        M1(s1);
        M1(n1);
    }
}

// C# 언어의 특징
// 공통으로 사용되는 메소드의 이름은
// 1. 인터페이스로 먼저 이름을 약속하고
// 2. 각 타입에서 인터페이스를 구현