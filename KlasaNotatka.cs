// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

************************************************
klasa: <Notatka>
opis: <Klasa tworzy notatki>
pola: <licznik_notatek - przechowuje liczbe utworzonych notatek>
    <id- reprezentuje id klasy>
    <tytul - przechowuje tytul utworzonej notatki>
    <tresc - przechowuje tresc utworzonej notatki>

autor: <numer zdającego>
************************************************

class Notatka{
    private static int licznik_notatek =0;
    private int id;
    protected string tytul;
    protected string tresc;
    
    //konstruktor
    public Notatka(string tyt,string tre){
        licznik_notatek++;
        id = licznik_notatek;
        tytul = tyt;
        tresc = tre;
    }
    
    public void wyswietl(){
        Console.WriteLine("Tytul: "+tytul);
        Console.WriteLine("Tresc: "+tresc);
    }
    
    public void diagnostyka(){
        Console.WriteLine(id+";"+tytul+";"+tresc);
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Notatka zakupy = new Notatka("Zakupy","Cola Ziemniaki  Kurczak");
        Notatka szkola = new Notatka("Szkola","Sprawdzain Wos  program react");
        
        Console.WriteLine("Notatka zakupy:\n");
        zakupy.wyswietl();
        Console.WriteLine("\nDiagnostyka:");
        zakupy.diagnostyka();
        
        Console.WriteLine("\n---------------\n");
        
        Console.WriteLine("Notatka szkola:\n");
        szkola.wyswietl();
        Console.WriteLine("\nDiagnostyka:");
        szkola.diagnostyka();
        
    }
}