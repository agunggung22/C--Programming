using static System.Console;

delegate void Handler();
class Button
{
    // public ? Click = null;  // 물음표에는 함수를 보관하는 타입이 필요함 => 이럴때 delegate를 사용함
    // Handler : delegate 로, 함수 정보를 보관하는 타입
    public Handler Click = null;

    public void UserPressButton()
    {
        // 저장된 함수 타입이 있으면
        if(Click != null)
        {
            // 해당 함수를 실행한다!!!!
            Click();
        }
    }
}

class Program
{
    public static void Main()
    {
        Button btn1 = new Button(); // GUI 버튼이 만들어 지고
        Button btn2 = new Button();

        // 버튼을 누를때 호출될 함수를 미리! 등록
        btn1.Click = Foo;
        btn2.Click = Goo;

        btn1.UserPressButton(); // 사용자가 버튼을 누르면 이 메소드가 호출된다고 가정. 
        btn2.UserPressButton();
    }
    public static void Foo() { WriteLine("Foo")};
    public static void Goo() { WriteLine("Goo")};

}