
// 핵심. auto property는 public 필드랑 같은거 아니냐?
//       == 안전성 체크하는 매리트가 없는 데 왜 굳이 property를 쓰나?

class Person1
{
    //      한줄(auto) property : 내부적으로 필드와 get/set 만들어줌
    //      유효성 확인 없긴함 ✔️
    // but OCP 원칙 : 유지보수 시에 property를 추가하더라도 -> main 함수는 변화 없음!
   
    public int Age { get; set; } = 0;
}

class Person2
{
    // public 필드 : 값의 유효성 확인 없음
    //      하지만, 유지보수를 고려했을 때, 추후에 property로 변경하면 -> 의존성 때문에 main 코드도 수정해야함
    public int age = 0;
}

class Program
{
    public static void Main()
    {

        // 즉, 당장은 유효성 검사가 필요하지 않더라도 
        // 항상. public 보다는 auto property가 낫다!!!!
        Person p1 = new Person();
        Person p2 = new Person();

        p1.Age = 10;
        p2.Age = 10;
    }
}