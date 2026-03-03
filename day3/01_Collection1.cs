// Collection 

class Program
{
    public static void Main()
    {
        // 기본 배열[Array] : 크기를 변경할 수 없음. 삽입/삭제 불가능
        //      불편하지만 List보다 빠름
        int[] arr = { 1, 2, 3, 4, 5 };

        // List<>          : 크기를 변경할 수 었음. 삽입/삭제 가능
        //      <type> 은 generic 문법
        //      편리하지만 느림
        //      힙에 저장됨
        List<int> s = new List<int>();

        s.Add(1);  
        s.Add(2);
        s.Add(3);

        // 접근법은 배열과 동일함
        s[0] = 10;

        // C++, C#, Java: 배열도 있고 List도 존재
        //      C++의 List는 vector
        // python : List만 존재
    }
}
