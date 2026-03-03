// public field vs setter/getter

// 1. age의 접근제어자: public
//      안전성 낮음
//      가독성 좋음 ✔️
class Person1
{
    public int age;
}

// 2. age의 접근제어자는 private && 외부에서는 getMethod/setMethod 메소드로 접근
//      안전성 확보 ✔️
//      가독성 떨어짐 
class Person2
{
    private int age;

    public int GetAge() => age;
    public void SetAge(int value)
    {
        if (value > 0)
            age = value;
    }
}

// 3. 안전성도 높고, 가독성도 좋게 할 수 없을까?
//      property!!!
class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
        Person2 p2 = new Person2();

        // #1. publie field
        p1.age = -10;
        p1.age = 10;
        int n1 = p1.age;


        // #2.setter/getter 사용
        p2.SetAge(-10);
        p2.SetAge(10);
        int n2 = p2.GetAge();
    }
}
