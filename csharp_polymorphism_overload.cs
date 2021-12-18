using System;  
public class polymoverload{  
    public static int minus(int a,int b){  
        return a - b;  
    }  
    public static int minus(int a, int b, int c)  
    {  
        return a - b - c;  
    }  
}  
public class testpolymoverload
{  
    public static void Main(string[] args)  
    {  
		
        Console.Write(polymoverload .minus(100, 10));  
		Console.Write(polymoverload .minus(100, 10, 3));  
		
    }  
}  