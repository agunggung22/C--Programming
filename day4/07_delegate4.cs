using System;
using static System.Console;

// 아래 코드에는 클래스가 몇 개 있을까?
// 1. 빌드 한다
// 2. "developer command prompt" 실행 수 "ildasm" 실행
// 3. ildasm에서 "Day4/bin/debug/net10.0/day4.dll 열어보기

delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        MyFunc f = Foo; // 보통 이렇게 사용함
    }

    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}