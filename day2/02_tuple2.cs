using static System.Console;

// #1. tuple 생성

// sol1. generic 
ValueTuple<int, int, int> vt1 = new ValueTuple<int, int, int>(1, 2, 3);
ValueTuple<int,int,int> vt2 = (1,2,3);  

// sol2. 단축 표기법
//      튜플 참조변수의 정확한 타입은 소괄호 안에 각 타입 명시 : (Type1, Type2, type3, ... )
//      초기화도 소괄호
(int, int, int) t1 = (1, 2, 3);
(int, double, string) t2 = (1, 3.4, "ABC");

// sol3. var 사용
//      튜플은 타입을 직접 표기하기 보단, 그냥 var 사용
var t = (1, 2.3, "abc");

// #2. 요소 접근
// .으로 "Item1", "Item2" 속성에 접근
var t3 = (1, 2, 3);
t3.Item1 = 10;
Console.WriteLine($"{t3.Item1}, {t3.Item2}");



// #3. Named Member
//      요소 각각에 이름 부여 가능

// sol1.
(int one, int two, int three) v3 = (1, 2, 3);  
Console.WriteLine("{0}, {1}", v3.one, v3.two);  // 이름으로 요소 접근
Console.WriteLine($"{v3.one}, {v3.Item1}");     // Item도 계속해서 사용 가능

// sol2. 
var v4 = (one:1, two:2, three:3);

