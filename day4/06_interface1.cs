using static System.Console;

class Camera
{
	public void Take() { WriteLine("take picture"); }
}

// 시간이 지나서, Digital Camera 출시 
class DigitalCamera
{
    public void Take() { WriteLine("take Digital picture"); }
}

// 새로운 DigitaCamera 때문에 기존의 Person 클래스도 변경해야됨 [OCP 위반]
// OCP를 위반하는 디자인패턴
class Person
{
	public void useCamera(Camera c) { c.Take(); }

	// digital camera를 다루는 메소드 오버로딩
	public void useCamera(DigitalCamera dc) { dc.Take(); }
}

class Program 
{
	public static void Main()
	{
		Person p = new Person();
		Camera c = new Camera();

		p.useCamera(c);

		DigitalCamera dc = new DigitalCamera();
		p.useCamera(h); // error - 디카를 다루는 메소드는 없음 

    }

	public static void M1(IComparable ic)
	{
	}

}
