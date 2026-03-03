using static System.Console;

// 핵심 #9. abstract method
// abstract : 구현의 일부를 자식에게 강제 


// virtual 메소드: 기반 클래스는 기본 구현을 제공 -> 자식 클래스가 기본 구현을 사용하거나 재정의 가능
// abstract 메소드: 기반 클래스가 구현 없이, 자식에게 구현을 강제함 -> 파생 클래스가 반드시 구현해야함
//      이름을 약속해놔야 shape 참조 변수로 Draw 메소드를 부를 수 있기 때문!!

// 구현의 담당부
// 가상 메소드는 부모 담당 / 추상 메소드는 자식 담당
// -> 재정의를 "옵션"으로 하려면 virtual로 하고, 재정의를 필수로 할거면 abstract 


// 만약 abstract method가 한개라도 있다면, 클래스도 abstract class 여야함
//      abstract 클래스 == 내부에 추상 메소드가 있다는 의미 

// abstact 클래스
//      독립적인 객체 생성 불가(new 키워드 사용 불가)
//      참조 변수로만 사용 가능 (virtual 문법으로 동적 바인딩 -> 다형성 가능)
abstract class Shape
{
    private int color = 0;
    public void SetColor(int c) { color = c; }                  // 기본 메소드 있어도 됨 (interface는 추상 메소드만 있어야함)

    // Shape은 추상화된 개념 -> 실체가 없어서 Draw 구현 없는게 논리적임
    //public virtual void Draw() { WriteLine("Draw Shape"); }   // virtual method
    public abstract void Draw();                                // abstract method

    public abstract Shape Clone();  
    
    public virtual int GetArea() { return -1; }
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
            else if (cmd == 9)
            {
                foreach (var e in s)
                {
                    e.Draw();
                }
            }
            else if (cmd == 8)
            {
                Console.Write("몇번째 만들었던 도형을 복제할까요 >> ");
                int k = int.Parse(Console.ReadLine());

                s.Add(s[k].Clone());

            }
        }
    }
}

