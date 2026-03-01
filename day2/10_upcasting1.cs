
// upcasting: 파생 타입을 자동으로 부모 타입으로 변환
//      즉, "부모 참조변수가 자식 객체를 참조할 수 있음"
//      객체지향에서 가장 중요한 개념 중 하나
//      더 많은 기능을 가진 자식 타입을 -> 더 적은 기능을 가진 부모 타입으로 변환하는 것


// upcasting은 자식에서 추가된 기능을 무시하면 되므로 안전하지만,
// downcasting은 없는 기능에 접근&사용하려 할 수 있어서 위험함
class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Cat : Animal
{
    public int Speed {  get; set; } = 0;
}

class Program
{
    public static void Main()
    {
        Dog r1 = new Dog(); // ok

        int r2 = new Dog(); // error

        // 부모 참조변수에 자식 객체를 참조할(가리킬) 수 있다.
        Animal r3 = new Dog(); // ?

    }
}


// 핵심2. 컴파일러는 컴파일 시간에 r3가 가리키는 객체의 정확한 타입을 알 수 없음
//      단지, 참조 변수의 타입을 따를 뿐 
//      객체의 실제 타입은 런타임에 결정되기 때문



// 핵심3. 컴파일러는 r3(부모 참조변수)가 Animal 타입인 것만 알기 때문에, 부모 부분 접근만 허용함
//      자식 부분 접근은 error 일으킴
r3.Age = 10; // ok
r3.Color = 10; // error - 런타임에는 메모리에 있더지만, 컴파일시에 컴파일러는 에러로 인식

//      이유: 멤버(필드, 메소드) 접근이 유효 한지를 확인하는 시점 때문임
//      C++, C#, Java : 컴파일 시간에 확인(static type check)
//      Python        : 런타임에 확인(dynamic type check)  -> 실행 하다가 프로그램 중지됨


// 핵심4. 자식 부분에 접근하려면 downcasting 캐스팅해야함
((Dog)r3).Color = 10; // ok
//      단 이경우에, r3가 가리키는 곳이 반드시 Dog인지 개발자가 확신해야 함!
//      아니면 runtime error 발생


// 핵심5. Dog라는 확신이 없으면 is 연산자로 type을 확인하면 됨
if(r3 is Dog)
{
    Dog d = (Dog)r3;        // 타입 캐스팅해서 Dog 참조변수에 할당
    d.Color = 10;           // dog 타입변수로 접근해야 오류가 없읍
}