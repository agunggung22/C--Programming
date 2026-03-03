using static System.Console;



class Date
{
    // 강의에서는 간단히 하기 위해 auto impl 사용
    public int Year { get; set; };
    public int Month { get; set; };
    public int Day { get; set; };

    // private필드 + get/set메서드는 필드를 캡슐화
    // 프로퍼티는 외부에 get/set을 간단히 제공하는 문법
    //      결국 실무에선 => 필드(데이터) 접근용 인터페이스가 됨
    public Date(int year, int month, int day)
        => (Year, Month, Day) = (year, month, day);

    

    // Date 타입을 다루는 여러 메서드 정의
    public Date AfterDays(int ds)
    {
        Date tmp = new Date(Year, Month , Day + ds);
        return tmp;
    }

    // 날짜 관련 메소드를 만들려면, 먼저 월별 날짜수를 정의해둬야함
    private static int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

}

class Program
{
    public static void Main()
    {
        Date d1 = new Date(2025, 2, 23);

        // 필요한 메소드
        Date d2 = d1.AfterDays(1000);
    }
}