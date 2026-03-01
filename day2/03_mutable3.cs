

// 핵심1. 때떄로, new와 단축표기법의 동작이 다른 경우가 있음
// string 생성의 2가지 종류
// 1. ""로 생성 => string intern pool(메모리 공유)
string s1 = "abcd";

// 2. new로 생성 (메모리 공유 안함)
string s2 = new string("efgh")


// 핵심. 객체는 참조변수지만, new로 생성하면 각자 고유의 메모리가 할당됨!! 이는 string에도 마찬가지로 적용된다. 

// 1. heap의 string intern pool : 문자열 리터럴을 저장하는 공간
//      immutable하고, 동일한 문자열을 새로 만들지 않고 메모리를 공유함
string s1 = "AAA";      // intern pool의 string literal "AAA"의 주소 참조
string s2 = "AAA";      // 동일한 주소 참조 


// 2. new로 생성하면 string intern pool에 저장하지 않고, 독립적인 인스턴스 메모리 할당
//      권장하진 않음 (비효율적, 메모리 낭비)
string s3 = new string("AAA");      // heap에 독립적으로 문자열 저장
string s4 = new string("AAA");

//immutable의 장점
// 1. 동일 데이타를 공유해서 메모리 절약
// 2. 여러개의 cpu가 동시접근해도 문제 없는, 즉 멀티코어에 최적화됨
// 3. 컴파일러가 다양한 방법으로 최적화 가능
// => stringbuilder는 성능이 나쁘고 동시 접근시 동기화 필요 


// 같은 메모리 주소를 공유하는지 확인하는 방법
Console.WriteLine($"{object.ReferenceEquals(s1, s2)}");  // true
Console.WriteLine($"{object.ReferenceEquals(s3, s4)}");  // false

// == 연산자는, 메모리랑 상관 없이, 같은 문자열인지만 확인
Console.WriteLine($"{s1==s3}");  // true


// 프로그래밍 철학: immutable한게 최고다 

// Rust: 모든 변수는 기본적으로 immutable
// let n = 10;
// n = 20 
// let mut n = 10; // 변경은 키워드 선언 필요