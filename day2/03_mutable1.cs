// mutable.cs

// 핵심. string은 immutable하다

// mutable   : 객체의 상태를 변경할수 있는것
// immutable : 객체의 상태를 변경할수 없는것 / 초기화한 이후에 메모리 수정 불가

// #1. int 타입 변수는 mutable 합니다.
int n = 10;
n = 20;    // 변경 ok

// #2. string은 immutable
//      "" 자체도 string literal 객체이기 때문에, string literal은 수정 불가능

// 어디 메모리에 저장?
// C / C++ : 문자열 리터럴이 정적 영역
// C#/Java : 문자열 리터럴이 힙(힙 내부의 Intern Pool)에 저장됨
//      string intern pool: 문자열 리터럴을 저장/공유하기 위한 힙 공간
//      동일한 문자열을 하나만 만들어서 공유하는 영역
string s1 = "abcd";  





