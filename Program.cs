using System;
using System.Runtime.Serialization.Formatters;

class Program
{

    //b.SayHello();
    static void Main(string[] args)
    {
        /*Console.WriteLine("This is my Main method.");
        Console.WriteLine(args[0]);
        Console.WriteLine(args[1]);

        Student b = new Student();
        b.SayHello();

        datatypes in c# - int , string , bool , float

        1. how to take input
        2. loops
        3. method/functions

        print the sum of two numbers-

        int a;
        int b;
        int c =a+b;


    
        
        
        int a = 10; //variable declaration and initialisation
        Console.WriteLine(a);
        int b=20;
        int c = a+b;
        Console.WriteLine(c);
        Console.WriteLine("enter two numbers ");
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);
        int c = a+b;
        Console.WriteLine("the sum is "+c);

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("hello");

        }
        2*1 = 2
        2*2 = 4
        2*3 = 6.......
        void , int , bool , 


        return_type name_of_the_function(parameters){


    make a function to print your intro and u need to take input from the user for his details.


        }*/

        
    



        int sum=0;

        for(int i = 1; i <= 10; i++)
        {
            sum = 2*i;
            Console.WriteLine(sum); //local scope
        }

        Program ball = new Program();
        ball.Greetings();
          ball.Greetings();
            ball.Greetings();
        }

    void Greetings()
    {
        Console.WriteLine("hello how are you!!");
    }
}
