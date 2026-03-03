using static System.Console;

class Program
{
    public static void Main()
    {
        // <객체지향 프로그래밍의 기본 개념>

        // 사각형의 면적을 구하는 함수 
        int GetRectArea(int x1, int y1, int x2, int y2)
        {
            return (x2 - x1) * (y2 - y1);
        }

        int area = GetRectArea(1, 1, 10, 10);

        // 사각형을 다루고 싶음 -> 사각형 타입이 필요함
        // 하지만 int, string 이런 타입밖에 없는데..?
        // 조합해서 먼저, 사각형 타입을 만드는 것임
        // 이후 이 타입을 다루면 됨

        // 타입을 만들 때 사용하는 키워드: class, struct
        class Rect
        {
            // 사각형 한 개를 표현하는데 필요한 데이터 
            // => 필드 정의
            public int left;     // x1
            public int top;     // y1
            public int right;   // x2
            public int bottom;  // y2

            // 사각형과 관련된 기능
            // => 메소드 정의
            public int GetArea()
            {
                return (right - left)(top - bottom);
            }
        }


        // 이제 사각형이 필요하면 "Rect" 타입을 사용하면 됨
        Rect rc = new Rect();
        rc.left = 1;
        rc.top = 1;
        rc.right = 10;
        rc.bottom = 10;

        int area=rc.GetArea();
    }
}

