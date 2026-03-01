
// 핵심. property
//      안전성도 높고, 가독성도 좋은 방법

class Person1
{

    // Property 문법
    //      C++/Java에는 없고 C#에만 있는 고유 특징
    //      getter/setter를 편리하게 만들고 사용하는 문법 
    //      만들 때는 함수처럼, 사용할 때는 필드처럼

    // property 선언 형식
    /*
     접근제어자 반환타입 프로퍼티이름{
     get;
     set;
     }
    */

    // 1. 필드를 개발자가 직접 정의
    //      private으로 선언
    private int age;

    // 2. property로 get/set 제어
    public int Age
    {
        // Person.Age 읽기 => int get_Age() 호출
        get { return age; }

        // Person.Age에 쓰기 => void set_Age(int value) 호출
        set
        {
            if (age > 0) age = value;
        }
    }
}




class Program
{
    public static void Main()
    {
        Person1 person1 = new Person1();

        // property는 클래스 내부/외부 모두에서 필드처럼 사용!!!
        person1.Age = 10;       // 쓰기 => set을 호출, 오른쪽이 value
        int n = person1.Age;    // 읽기 => get을 호출 
    }
}
