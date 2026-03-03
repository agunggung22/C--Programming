using System;
using static System.Console;

// 객체지향 언어에서 사용되는 용어

// 핵심 : static method vs instance method

// instance method : "변수.메소드이름()" 으로 호출하는 메소드
//                   객체가 보관중인 데이타와 관련 된 기능 수행

// static method : 타입.메소드이름() 으로 호출하는 메소드
//                 특정 데이타와는 관련없고, 타입과 연관된 기능수행

int num = 10;               
string s = num.ToString();  

// property도 instance와 static으로 나뉨
Console.WriteLine(s.Length);  // instance property
Console.WriteLine(int.MaxValue); // int type의 static property



// 문자열을 숫자로 변경하는 2가지 방법 
int n1 = Convert.ToInt32(s);    // convert 클래스의 static method
int n2 = int.Parse(s);          // Parse 클래스의 static method 