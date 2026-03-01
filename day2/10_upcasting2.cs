
// upcasting : 객체지향에서 가장 중요한 개념 중 하나

class Animal
{
    public int Age { get; set; } = 0;
}

class Dog : Animal
{
    public int Color { get; set; } = 0;
}

class Cat : Animal
{
    public int Speed { get; set; } = 0;
}

class Program
{
    //public static void NewYear(Dog d) => ++d.Age   // Dog만 전달 가능

    public static void NewYear(Animal animal)   // Animal / Dog / Cat 객체를 자동 upcasting으로 전달 가능
    {
        ++animal.Age;

        // 자식 멤버에 접근하려면
        //      is로 타입 확인
        if(animal is Dog)
        {
            Dog dog =(Dog)animal;
            dog.Color = 10;
        }
        if(animal is Cat cat) // downcasting까지
        {
            cat.Speed = 10;
        }
    }

    // 인자가 object면 모든 타입이 사용가능한 메서드가됨!!
    public static void Foo(object obj)
    {
        // 하지만 object의 멤버만 접근 가능해서... 쓸모가.. 
    }

    public static void Main()
    {
        NewYear(new Dog());
        NewYear(new Cat()); // 매개변수의 타입이 Dog인데 Cat을 전달 할 수가 있나?

        // animal 배열에는 모든 자식 저장 가능

    }
}

