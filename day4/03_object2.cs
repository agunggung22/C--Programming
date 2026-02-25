class Program
{
    public static void Foo(object obj)
    {
        // obj 가 어떤 타입인지 알고 싶다

    }
    public static void Main()
    {
        int n = 10;
        double d = 3.14;

        Foo(n);
        Foo(d);
        Foo("abc");
    }

}
