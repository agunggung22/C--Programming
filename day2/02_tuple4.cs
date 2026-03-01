using static System.Console;

// 핵심.튜플은 언제 사용?
// 여러 개의 값을 반환할 때!!


// 1. 함수는 기본 적으로 한개의 값을 반환 합니다.
string Get1()
{
    return "john";
}

string ret1 = Get1();

// 2. 여러 개의 값을 반환하고 싶으면? -> tuple 반환
(string, int) Get2()                // 반환 타입으로 tuple 선언
{
    return ("John", 20);            // return tuple
}

var ret2 = Get2();                  
Console.WriteLine($"{ret2.Item1}, {ret2.Item2}");


// 3. named tuple이 좋다
(string Name, int Age) Get3()       // 반환 타입 선언에 -> named tuple 문법 사용
{
    return ("John", 20);
}
var ret3 = Get3();                  // ret3: (string Name, int Age) 튜플 타입
Console.WriteLine($"{ret3.Name}, {ret3.Age}");


// 다른 언어는?
// C++ : struct 구조체 
// java: 클래스
// python: 튜플 있음 