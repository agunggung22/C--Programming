
// 핵심. property 만드는 문법 정리

class Person
{
    // 1. 직접 필드를 만들기
    private int age;

    // 2. age에 대한 property 작성
    //      필드의 대문자로 만드는게 관례
    public int Age
    {
        get => age;
        set => age = value;
    }

    // 3. 프로퍼티를 필트처럼 사용
    //      실무에서는 내부에서도 프로퍼티 사용 권장!!!!
    //      get 로직 추가시를 대비해서 
    public bool isOld()
    {
        return Age > 80;
    }
    //-----------------------------------------------------------------
    // 위와 같이 property에 추가 로직 없이, 단순히 private field를 읽고 쓰기만 한다면 아래처럼 편리하게 선언
    //      1. 필드도 자동으로 생성됨(int age 불필요)
    //      2. Age Property의 set/get 기능 자동 추가 
    public int Age { get; set; } = 0;
}