using static System.Console;

// 핵심
// => C# 의 모든 변수는
// 1. 데이타(값)을 저장하고
// 2. 데이타 관련 메소드(method, 함수)를 제공하고
// 3. 데이타 관련 속성(property) 를 제공한다.

// #1. 모든 변수는 데이타를 저장한다
int n = 10;
string s = "abcd";

// #2. 모든 변수는 자신이 저장한 데이타 관련 메소드(함수)를 제공한다.
// 메소드가 없는 변수는 없음
string s2 = n.ToString(); // n은 int인데 어떻게 메소드가 있지? => C#은 int도 object이므로 메소드가 있음

string s3 = 10.ToString();   // 리터럴도 메소드가 있음.....?  => 리터럴도 object임 


// #3. 모든 변수는 자신이 저장한 데이타 관련 속성(property) 제공한다.
int n = s.Length;
s.