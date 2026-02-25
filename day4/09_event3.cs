using static System.Console;

delegate void Handler();

class Button
{
    //public Handler Click = null;
    // event 키워드
    //      없으면 : =,+=,-= 모두 사용 가능
    //      있으면 : +=, -=만 사용 가능
    //          실수 대비

    public void UserPressButton()
    {
        if (Click != null)
        {
            Click();
        }
    }
}

class Program
{
    public static void Main()
    {
        Button btn1 = new Button();

        btn1.Click = Foo;
        //btn1.Click += Goo;
        btn1.Click = Goo;   // 의도는 += 이었는데 실수함 => 초기화됨

        // 2개를 담아놔서 2개가 호출됨
        btn1.UserPressButton();

    }
    public static void Foo() { WriteLine("Foo"); }
    public static void Goo() { WriteLine("Goo"); }
}