
// 핵심. 한 줄 메소드: 반환값 또는 한줄 expression 쓰면 됨
//      "expression bodied" 라고 부름
int add1(int a, int b) => a + b;  

Console.WriteLine( add1(3, 4) );   


// 다른 언어에서 볼 수 없는 C#만의 특징으로 아주 널리 사용됨!!
int add2(int a, int b) => a + b;
void sayHello() => Console.WriteLine("Hello");