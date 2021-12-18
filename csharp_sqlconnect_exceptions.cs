using System;  
using System.Data.SqlClient;  
namespace SQLConnectException
{   class mydbconnectException  
    {  
        static void Main(string[] args)  
        {  
            new mydbconnectException().connectdbfuncException();  
        }  
        public void connectdbfuncException()  
        {  
                     
                     SqlConnection con = null;
                     try{
                        con=new SqlConnection("data source=.; database=account; integrated security=SSPI");
                        con.Open(); 
                        Console.WriteLine("We are successfully connected to database");      
                     }
                    catch(Exception e){
                        Console.WriteLine("We are halted in connecting to database"+e);      
                     }
                    finally  
                    {   
                        con.Close();  
                    }   
                 
               
            
        }  
    }  
}  