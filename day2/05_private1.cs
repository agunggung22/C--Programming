using static System.Console;

// 핵심. 접근제어자 : public, private
// public: 어디서든 접근 가능
// private: 클래스 내부에서만 접근 가능 (== 자신의 메소드로만 접근 가능)


// 자전거를 관리하는 프로그램을 만들고 싶음
// -> 자전거 타입을 먼저 선언

class Bike
{
    private int gear = 0;

    // 타입 안전성 확보
    // 값이 유효한지 확인한 후 상태를 변경 => 필드는 항상 안전한 상태를 유지 가능
    public void SetGear(int gear)
    {
        if(gear>1 && gear<=20)
            this.gear = gear;
    }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

        // private이 필요한 경우
        // 사용자가 기어를 음수 등의 잘못된 값으로 설정할 가능성 존재 (타입 안전성 낮음)
        // b.gear = -10; 

        // 상태에 간접 접근!
        b.SetGear(-10);     // 잘못된 값이므로 무시됨
        b.SetGear(10);      // ok
    }
}


