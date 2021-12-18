using System;  
public class A{  
    public virtual void myFunc(){  
        Console.WriteLine("inside virtul function...");  
    }  
}  
public class B: A  
{  
    public override void myFunc()  
    {  
        Console.WriteLine("now working as polymorphism instance...");  
    }  
      
}  
public class myClass
{  
    public static void Main()  
    {  
        A a= new B();  
        a.myFunc();  
    }  
}  