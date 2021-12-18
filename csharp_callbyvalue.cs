using System;  
namespace tCV
{  
    class mytCV
    {  
        public void plus(int t)  
        {  
            t=t+1;
            Console.WriteLine("Changed value"+t);  
            
        }  
        
        static void Main(string[] args)  
        {  
            int t = 1;  
            Console.WriteLine("Early stage value" + t);  
            mytCV b= new mytCV();
            b.plus(t); 
            Console.WriteLine(" value after call by value" + t);  
        }  
    }  
}  