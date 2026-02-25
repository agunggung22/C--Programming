using static System.Console;

class Button
{
	public void UserPressButton()
	{
		// 버튼을 눌렀을 때의 동작을 여기서 구현하면, 모든 버튼이 동일한 동작을 함
	}
}

class Program
{
	public static void Main()
	{
		Button btn1 = new Button(); // 이순간 GUI 버튼이 만들어 지고
		Button btn2 = new Button();
	
		btn1.UserPressButton(); // 사용자가 버튼을 누르면 이 메소드가 호출된다고 가정. 
        btn2.UserPressButton(); 		
	}
}