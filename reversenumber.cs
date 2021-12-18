using System;  
  public class myReverse
   {  
     public static void Main(string[] args)  
      {  
       
       int myinput=132, myremainder, myoutput=0;     
       int temp;
	   temp=myinput;
   
       while(myinput!=0)      
       {      
        
        myremainder=myinput%10;        
        myoutput=myoutput*10+myremainder;      
        myinput/=10;      
       }      
       Console.Write("Input number is: "+temp);       
       Console.Write("Output reverse number is therefore: "+myoutput);       
    }  
  }  