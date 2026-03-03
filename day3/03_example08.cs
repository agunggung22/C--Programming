using static System.Console;

// 핵심: virtual vs non-virtual
// 파생 클래스에서 재정의할 메소드면 virtual, 아니면 non-virtual

// non-virtual 메소드도 자식클래스에서 new로 오버라이드가 가능하잖아요, 그럼 new로 재정의하는 문법은 보통 언제 쓰는건가요??
// new는 문법적으로만 제공될 뿐 실제로 객체지향에서 자주 샤용되는 문법은 아님
// 코드리뷰시에: "new가 왜 필요함?? 하는정도"
class Shape
{
    private int color = 0;

    // 이 메소드는 virtual로 할까 non-virtual로 할까?
    public void SetColor(int color) {  this.color = color; }
    // 파생 클래스가 재정의할(override) 메소드 아님
    // 성능이 더 좋은 non-virtual로 하기 

    public virtual int GetArea() { return 0; }
    // 파생 클래스마다 넓이를 구하는 방식이 다르기 때문에, override할 클래스
    // 다형성을 위해 virtual로 하기

    public virtual void Draw() { WriteLine("Draw Shape"); }

    public virtual Shape Clone()
    {
        Shape s = new Shape();
        s.color = color;
        return s;
    }
}



class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }
    public override Shape Clone()
    {
        return new Rect();
    }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }
    public override Shape Clone()
    {
        return new Circle();
    }
}

class Program
{
    public static void Main()
    {
        List<Shape> s = new List<Shape>();

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
            else if (cmd == 8)
            {
                Console.Write("복제할 도형의 번호를 입력해주세요: ");
                int k = int.Parse(Console.ReadLine());
                s.Add(s[k].Clone());

            }
            else if (cmd == 9)
            {

                foreach (var e in s)
                {
                    e.Draw();
                }
            }
        }
    }
}
