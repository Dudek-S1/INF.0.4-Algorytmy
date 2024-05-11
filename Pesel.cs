// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.IO;

class HelloWorld
{
    static char SprawdzPlec(string pesel)
    {
        char cyfraPlec = pesel[9];
        if (int.Parse(cyfraPlec.ToString()) % 2 == 0)
        {
            return 'K'; // Zwróć 'K' dla płci żeńskiej
        }
        else
        {
            return 'M'; // Zwróć 'M' dla płci męskiej
        }
    }
    static bool SumaKontrolna(string pesel)
    {
        int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        float S = 0;
        float M = 0;
        float R = 0;
        char cyfraKontrolna = pesel[10];
        for (int i = 0; i < 10; i++)
        {
            S += int.Parse(pesel[i].ToString()) * wagi[i];
        }
        M = S % 10;
        if (M == 0)
        {
            R = 0;
        }
        else
        {
            R = 10 - M;
        }
        if (R == float.Parse(cyfraKontrolna.ToString()))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static string Data(string pesel)
    {
        string dzien = pesel[4].ToString();
        dzien += pesel[5].ToString();
        string rok = pesel[0].ToString();
        rok += pesel[1].ToString();

        int miesiac1 = int.Parse(pesel[2].ToString());
        int miesiac2 = int.Parse(pesel[3].ToString());

        string miesiac = "";
        if (miesiac1 == 8 || miesiac1 == 9)
        {
            //1800-1899
            rok = rok.Insert(0, "18");
            if (miesiac1 == 8)
            {
                miesiac=0.ToString()+miesiac2.ToString();
            }
            else
            {
                miesiac = 1.ToString() + miesiac2.ToString();
            }
        }
        else if (miesiac1 == 0 || miesiac1 == 1)
        {
            //1900-1999	
            rok = rok.Insert(0, "19");
            if (miesiac1 == 0)
            {
                miesiac = 0.ToString() + miesiac2.ToString();
            }
            else
            {
                miesiac = 1.ToString() + miesiac2.ToString();
            }
        }
        else if (miesiac1 == 2 || miesiac1 == 3)
        {
            //2000-2099	
            rok = rok.Insert(0, "20");
            if (miesiac1 == 2)
            {
                miesiac = 0.ToString() + miesiac2.ToString();
            }
            else
            {
                miesiac = 1.ToString() + miesiac2.ToString();
            }
        }
        else if (miesiac1 == 4 || miesiac1 == 5)
        {
            //2100-2199	
            rok = rok.Insert(0, "21");
            if (miesiac1 == 4)
            {
                miesiac = 0.ToString() + miesiac2.ToString();
            }
            else
            {
                miesiac = 1.ToString() + miesiac2.ToString();
            }
        }
        else if (miesiac1 == 6 || miesiac1 == 7)
        {
            //2200-2299
            rok = rok.Insert(0, "22");
            if (miesiac1 == 6)
            {
                miesiac = 0.ToString() + miesiac2.ToString();
            }
            else
            {
                miesiac = 1.ToString() + miesiac2.ToString();
            }
        }

        return "Osoba Została urodzona Dnia: " +dzien+" w Miesiącu: "+miesiac +" Roku: "+rok;
    }

    public static void Main(string[] args)
    {
        string numer_pesel = "";
        Console.WriteLine("Podaj pesel:");
        numer_pesel = Console.ReadLine();
        Console.WriteLine("Pesel to: " + numer_pesel);
        char plec = SprawdzPlec(numer_pesel);
        Console.WriteLine(plec == 'K' ? "Kobieta" : "Mezczyzna");
        bool zgodnosc = SumaKontrolna(numer_pesel);
        Console.WriteLine(zgodnosc == true ? "zgodnosc Sumy Kontrolnej" : "brak zgodnosc Sumy Kontrolnej");
        Console.WriteLine(Data(numer_pesel));

    }
}