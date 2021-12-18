using System;  
using System.Data.SqlClient;  
namespace SQLConnect
{  
    class mydbconnect  
    {  
        static void Main(string[] args)  
        {  
            new mydbconnect().connectdbfunc();  
        }  
        public void connectdbfunc()  
        {  
            using (  
                     
                     SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI")  
                 )  
            {  
                con.Open();  
                Console.WriteLine("Connection Established Successfully");  
            }  
        }  
    }  
}  