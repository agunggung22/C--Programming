using static System.Console;

// 사용자 정의 타입도 비교 가능하게 하려면
// => 비교 함수를 제공하면 됩니다.
// => 그런데, 다른 C# 타입과 동일한 이름을 사용하면 좋습니다.
// => IComparable 인터페이스를 구현

class Label : IComparable  // 상속받고 추상메소드를 구현하지 않으면 error
{
    private string title;

    public Label(string s) => title = s;

    public int CompareTo(object? obj)
    {
        Label other = (Label)obj;
        // 멤버가 title 한개고 title은 string이므로 CompareTo 이미 존재 => 호출
        return title.CompareTo(other.title);
    }
}
class Label2 
{
    private string title;

    public Label2(string s) => title = s;

    public int CompareTo(object? obj)
    {
        Label2 other = (Label2)obj;
        // 멤버가 title 한개고 title은 string이므로 CompareTo 이미 존재 => 호출
        return title.CompareTo(other.title);
    }
}

class Program
{

    public static void M1(IComparable ic) { }

    public static void Main()
    {
        Label d1 = new Label("GOOD");
        Label d2 = new Label("BAD");

        // 사용자 정의 타입인 Label 도 크기 비교가 되도록 해봅시다.
        int ret = d1.CompareTo(d2);

        // CompareTo 이름이 있어도
        // IComparable 상속을 표기하지 않으면 (다형성)매개변수로 사용 불가
        Label2 e1 = new Label2("Good");
        M1(d1);     // ok
        M1(e1);     // error
    }
}
