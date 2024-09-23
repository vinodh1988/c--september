using System;

public static class MyExtensions
{
    public static string LenString(this string str)
    {
        return str+str.Length;
    }

    public static string GenId(this string str,int id){
        return str+id;
    }

    public static int NearestEven(this int no){
        return (no+1)%2==0?no+1:no+2;
    }
}

class MainClass
{
    public static void Main(string[] s){
        string name="joseph";
        Console.WriteLine(name.LenString());
        Console.WriteLine(name.GenId(124233));
        int p=99;
        Console.WriteLine(p.NearestEven());
    
        
    }
}


