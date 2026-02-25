using static System.Console;

// 충전기와 핸드폰 
// 핸드폰 기종이 미래에 바뀌어도 지금 충전기로 충전 가능해야함[OCP 만족]
// 하드웨어는 대부분 OCP를 만족함 => 핸드폰/충전기는 표준을 지키기 때문

// 소프트웨어도 OCP를 만족하려면?
// interface 사용
// 카메라를 무조건 만들지 말고, 카메라가 지쳐야 하는 규칙을 먼저 설계

// 모든 카메라가 만들어야 하는 메소드를 약속
// 구현은 파생클래스 담당
// 모든 메소드는 abstract, 키워드는 생략됨
interface ICamera
{
    // 필드는 못만듬

    // 접근지정자를 표기 ❌
    void Take();        // hd camera든 digital camera든 모든 카메라는 찍을 수 있어야함
}

// 진짜 카메라는 없더라도 기능은 존재 ⭕
// 기능을 사용하는 코드는 작성 가능
class Person
{
    // 핵심: 구체적인 클래스가 아닌 규칙(interface)의 이름을 사용
    // 자바도 이랬나??
    public void useCamera(ICamera c) { c.Take(); }
}

// 이제 모든 카메라는 카메라 규칙(인터페이스)를 지켜야 함
//      구현 담당
class Camera : ICamera
{
    // 인터페이스에서는 override 키워드 안씀
    public void Take() { WriteLine("take picture"); }
}

class DigitalCamera : ICamera
{
    public void Take() { WriteLine("take Digital picture"); }
}




class Program
{
    public static void Main()
    {
        Person p = new Person();
        Camera c = new Camera();

        p.useCamera(c);

        // 새로운 카메라 추가
        DigitalCamera dc = new DigitalCamera();
        p.useCamera(h);   // person을 수정하지 않아도 동작 [OCP 만족]

    }

    public static void M1(IComparable ic)
    {
    }

}

// 추상클래스: 지켜야 하는 규칙(abstract method) + 다른 멤버도 가능
// 인터페이스 : 지켜야 하는 규칙만 가능

// 표현
// "모든 카메라는 Camera 추상 클래스를 상속 받아야 한다"
// "모든 카메라는 ICamera 인터페이스를 구현해야 한다"

// C++: 추상 클래스 문법만 제공. 인터페이스 개념도 추상클래스로 구현
// C#, Java: 둘을 분리. abstract class로 추상 메소드만 구현하면 같은 동작 하긴함

// 추상 클래스(물려받을 멤버들이 있는)는 소규모 프로젝트에서는 괜찮지만,
// 대규모, 현업 프로젝트는 모두 interface를 사용함
// 여러 예외가 있는데 굳이 공통을 좁혀서 물려받는 상황을 만들 필요 없음
//      카메라에 int color 필드를 추가하면 흑백 카메라는 못쓰잖아


// 용어 정리
// 강한결합(tightly couplint)
//      클래스가 다른 클래스를 사용할 때, 클래스 이름을 직접 알고 쓰는 것
//      유연성이 없고 확장 불가능한 디자인
//      예시) Person::UseCamera(Camera)  : Camera 이름을 직접 사용

// 약한 결합(loosely coupling)
//      클래스가 다른 클래스를 사용할 때, 인터페이스를 사용하는 것
//      확장성 있고, 유연한 디자인
//      예시) Person::UseCamera(ICamera) : ICamera라는 규칙을 사용하는것

// C#, Java는 모든 것이 인터페이스일 정도로 널리 사용