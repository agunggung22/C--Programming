
// 핵심. property 초기화
class Person
{
    private int age;
    private string name;

    public int Age
    {
        get => age;
        set => age = value; 
    }
    public string Name
    {
        get => name;
        set => name = value;
    }

}
class Program
{
    public static void Main()
    {
        // 객체 생성 시에 프로퍼티 초기화도 가능
        //      {} 중괄호로 초기화
        //      중괄호 안에 "property 이름 = value"
        //      내부적으로 .set 호출
        Person p1 =new Person { Age = 10 };
        Person p2 = new Person { Age = 10, Name="AAA" };

        // 객체가 함수처럼 생성되었다? => property 초기화 문법 
        Person person1 = new Person { 
            Age = 1, 
            Name = "hyewon" 
        };

    }
}