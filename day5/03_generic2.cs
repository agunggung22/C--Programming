
// 핵심. 메소드의 제네릭 문법 


class Program
{

    public static double Add<T1, T2>(T1 a, T2 b)
    {
        return b;
    }

    public static void Main()
    {
        int n = Add(1, 1.2);  // int, double
        int n = Add(2.1, 1);  // double, int
    }
}