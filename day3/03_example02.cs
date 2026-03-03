using static System.Console;

// 핵심 3. 
// 모든 도형을 보관하기 위해 Shape 클래스를 사용했지만,
// 부모 참조 변수로는 자식 클래스에서 생성한 고유 멤버에 접근이 불가능함 

class Shape
{
    public int color;
}
class Rect : Shape
{
    public void Draw() { WriteLine("Draw Rect"); }  // 자식의 고유 멤버
}
class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}
class Program
{
    public static void Main()
    {
        // 만들어지는 모든 도형을 보관하기 위한 컬렉션
        List<Shape> s = new List<Shape>(); // 모든 도형을 보관할수 있다

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1)
            {
                s.Add(new Rect());
            }
            else if (cmd == 2)
            {
                s.Add(new Circle());
            }
            else if (cmd == 9)
            {
                // 아래 코드는 왜 오류일까?
                // 자식 생클래스가 추가한 draw를 호출할 수 없음
                foreach (var e in s) // e는 shape 클래스
                    e.Draw();        // draw 메소드는 자식의 고유 메소드
            }

            
        }
    }