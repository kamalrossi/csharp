using System;  
  public class myFibo
   {  
     public static void Main(string[] args)  
      {  
      
       int a=0,b=1,fN=0,n=10;      
       Console.Write(" "+a);    
       Console.Write(" "+b);    

       for(int i=0;i<n;i++){      
        fN=a+b;
        a=b;
        b=fN;
        Console.Write(" "+fN);    
       }      
       
     }  
  }  
