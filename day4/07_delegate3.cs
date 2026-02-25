using System;
using static System.Console;



// 1. 함수 모양을 그대로 복사해서 전역에 : void Foo(int arg)
// 2. 함수 이름만 원하는 이름으로 변경 : MyCunc
// 3. 반환 타입 앞에 delegate 추가
delegate void MyFunc(int arg);

// delegate의 정확한 원리
// 1. 사용자가 위 규칙에 맞게 코드를 만들어 놓으면
// 2. C# 컴파일러가 아래 클래스를 자동 구현
/*
class MyFunc: MultiCastDelegate   // 클래스 이름: MyFunc
{
    // 반환타입 : void
    // 인자: int 1개       인 함수 메모리 주소를 보관하기 위한 코드

    // Invoke() 메소드
    // ()연산자 
}
*/


class Program
{
    public static void Main()
    {
        // 기존 규칙: 모든 객체는 new로 만들어야함 -> delegate도 아래가 정확한 표기법
        MyFunc f2 = new MyFunc(Foo);

        // 하지만 단축표기법도 존재
        int n = 0;      // int n = new int()
        MyFunc f = Foo; // 보통 이렇게 사용함
    }

    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}