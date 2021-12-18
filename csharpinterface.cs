using System;  
public interface A
{  
    void myFunc();  
}  
public class B : A
{  
    public void myFunc()  
    {  
        Console.WriteLine("We are inside B");  
    }  
}  
public class C : A
{  
    public void myFunc()  
    {  
        Console.WriteLine("we are inside C...");  
    }  
}  
public class myClass
{  
    public static void Main()  
    {  
        A a;  
        a = new B();  
        a.myFunc();  
        a = new C();  
        a.myFunc();  
    }  
}  