using System;  
public abstract class A
{  
    public abstract void myF();  
}  
public class B : A
{  
    public override void myF()  
    {  
        Console.WriteLine("We are inside B");  
    }  
}  
public class C : A
{  
    public override void myF()  
    {  
        Console.WriteLine("We are inside C");  
    }  
}  
public class mytestClass
{  
    public static void Main()  
    {  
        A a;  
        a = new B();  
        a.myF();  
        a = new C();  
        a.myF();  
    }  
}  