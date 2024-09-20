using System;

class Third {
    public static void Main(string[]  args){
        Console.WriteLine("Name:");
        string name= Console.ReadLine();
        Console.WriteLine("Age:");
        int age= int.Parse(Console.ReadLine());
        Console.WriteLine("Score:");
        float score= float.Parse(Console.ReadLine());

        Console.WriteLine("name: {0} age: {1} score: {2}",name,age,score);
    }
}


