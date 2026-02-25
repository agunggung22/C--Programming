using System;
using System.Collections.Specialized;
using System.Reflection.Metadata;
using static System.Console;


delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        // delegate 변수에는 여러개의 함수를 등록 가능

        MyFunc f = Foo;
        f += Goo;
        f += Foo;
        f(10);      // Foo, Goo, Foo 호출(등록순)

        Console.WriteLine();
        f -= Foo;   // 마지막 foo를 삭제????
        f(10);

        Console.WriteLine();
        f = Goo;  // 기존에 등록된 모든 메소드 제거 후 Goo 등록
        f(10);
       
    }
    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
    public static void Goo(int arg)
    {
        WriteLine($"Goo : {arg}");
    }
}