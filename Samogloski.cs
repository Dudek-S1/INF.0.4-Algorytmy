// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public static class Narzedzie{
    
    public static int Samogloski(string tekst){
        string samogloski="aąeęiouóyAĄEĘIOUÓY";
        int licznikSamoglosek = 0;
        
        if(string.IsNullOrEmpty(tekst)){
            return 0;
        }
        else{
            foreach(char i in tekst){
                if(samogloski.Contains(i)){
                    licznikSamoglosek++;
                }
            }
        }
        return licznikSamoglosek;
    }
    
    public static string Powtorzenia(string tekst){
        string nowyTekst="";
        if(string.IsNullOrEmpty(tekst)){
            return "";
        }else{
            for(int i=0;i<tekst.Length-1;i++){
                char obecnyZnak = tekst[i];
                char nastepnyZnak = tekst[i+1];
                
                if(obecnyZnak!=nastepnyZnak){nowyTekst+=obecnyZnak;}
                

            }
            nowyTekst += tekst[tekst.Length - 1];
            return nowyTekst;
        }
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        string przy = "Ala ma kota";
        string przy2 = "Alaa ma   koota";
        Console.WriteLine(Narzedzie.Samogloski(przy));
        Console.WriteLine(Narzedzie.Powtorzenia(przy2));
    }
}