// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.IO;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i;
        float n;
        string n1;
        
        n1 = Console.ReadLine();
        n = float.Parse(n1);
        i=2;
        while(n>1){
            if(n%i==0){
                n=n/i;
                Console.WriteLine(i);
            }
            else{
                i=i+1;
            }
        }
        
     
    }
}