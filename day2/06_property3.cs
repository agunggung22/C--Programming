
// 핵심. property는 get/set 중에 하나만 만들어도 됨

class Person1
{
    private int age;

    // get/set 중 한개만 만들어도 됨
    public int Age
    {
        // get은 사용 못함
        set
        {
            if (value > 0)
                age = value;
        }
    }
}




class Program
{
    public static void Main()
    {
        Person1 person1 = new Person1();

        person1.Age = 10;       // set 
        //int n = person1.Age;    // get  -> 없으므로 error
    }
}
