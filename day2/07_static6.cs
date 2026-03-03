using static System.Console;



class Date
{
  
    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public Date(int year, int month, int day)
        => (Year, Month, Day) = (year, month, day);

    
    private static int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public static int HowManyDays(int month)
    {
        return days[month];
    }

    public Date Tomorrow()
    {
        Date tmp = new(Year, Month, Day + 1);
        return tmp;
    }


    // static method, instance method를 모두 제공하는 것도 많이 쓰이는 기술.
    public static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || ((year % 4 == 0) && (year & 100 != 0));
    }
    // 메소드 오버로딩: 동일한 기능을 하는 여러 메소드를 만들 수 있음
    //      메소드 이름은 동일해야함
    //      메소드 매개변수 시그니쳐는 달라야함 
    //      반환값은 상관 없음

    public int IsLeapYear()
    {
        // static method 호출하면서 자신의 Year 전달
        return IsLeapYear(Year);
    }
}

class Program
{
    public static void Main()
    {
        // 윤년인지 조사하는 IsLeepYear() 메소드 
        //      메소드 오버로딩

        // sol1. instance method 로 제공
        Date d = new Date(2022, 4, 31);
        bool b1 = d.IsLeepYear();

        // sol2. static method로 제공
        bool b2 = Date.InLeepYear(2024);
    }
}