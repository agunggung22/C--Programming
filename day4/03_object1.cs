/*
class Object
{
    // 2개의 static method
    public static bool Equals(object? objA, object? objB) { ... };
    public static bool ReferenceEquals(object? objA, object? objB) { ...};

    // 2개의 non-virtual method
    public Type GetType() { ... };
    protected object MemberwiseClone() { ... };

    
    // 3개의 virtual method
    public virtual bool Equals(object? obj) { ... };
    public virtual int GetHashCode() { ... };
    public virtual string? ToString() { ... };
}
*/

class Car 
{
    
}

class Program
{
    public static void Main()
    {
        Car c = new Car();
        var s = c.ToString();   
    }

}
