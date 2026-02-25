using System;
using static System.Console;

// delegate 만드는법

// 1. 함수 모양을 그대로 복사해서 전역에 : void Foo(int arg)
// 2. 함수 이름만 원하는 이름으로 변경 : MyCunc
// 3. 반환 타입 앞에 delegate 추가
delegate void MyFunc(int arg);

// 위 코드로 MyFunc는 타입 이름이 되었음
//      int, Point, Rect와 같은 층위인 타입!!

class Program
{
    public static void Main()
    {
        MyFunc f = Foo;
        // f는 Foo에 대한 호출 정보가 담겨있음
        //  핵심 정보: Foo 메소드의 메모리 주소

        f(10); //Foo(10) 동일
        f.Invoke(10); //위와 동일
    }

    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}