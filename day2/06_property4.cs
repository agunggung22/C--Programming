
// 핵심. expression bodied로 구현

class Person
{
    private int age;
    
    public int Age
    {
        get => age;
        set => age = value;
    }
    // C# 에서는 expression bodied 를 매우 많이 사용
    //      한줄이 아니라, if 등을 사용하려면 {} 로 구현

    public int Age
    {
        
    }
}
class Program
{
    public static void Main()
    {
        Person p = new Person();

        p.Age = 10;     // 쓰기(set)
        int n = p.Age;  // 읽기(get)

    }
}