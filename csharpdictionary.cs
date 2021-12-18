using System;  
using System.Collections.Generic;  
public class myDictionary
{  
    public static void Main(string[] args)  
    {  
        Dictionary<string, string> testPlayer = new Dictionary<string, string>();  
        testPlayer.Add("100","A");  
        testPlayer.Add("299","B");  
        testPlayer.Add("399","C");  
        testPlayer.Add("499","D");  
        
        foreach (KeyValuePair<string, string> i in testPlayer)  
        {  
            Console.WriteLine(i.Key+" "+i.Value);  
        }  
    }  
}  